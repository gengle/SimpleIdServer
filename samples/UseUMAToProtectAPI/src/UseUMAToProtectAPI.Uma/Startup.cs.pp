﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Newtonsoft.Json;
using SimpleIdServer.Jwt;
using SimpleIdServer.Jwt.Extensions;
using SimpleIdServer.Uma;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;

namespace $rootnamespace$
{
    public class Startup
    {
        private readonly IHostingEnvironment _env;

        public Startup(IHostingEnvironment env)
        {
            _env = env;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var openidJsonWebKey = ExtractOpenIDJsonWebKey();
            var oauthJsonWebKey = ExtractOAuthJsonWebKey();
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new List<CultureInfo>
                {
                    new CultureInfo("en"),
                    new CultureInfo("fr")
                };
                options.DefaultRequestCulture = new RequestCulture("en");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });
            services.AddLogging();
            services.AddSIDUma(options =>
            {
                options.OpenIdJsonWebKeySignature = openidJsonWebKey;
            })
            .AddAuthentication(c =>
                {
                    c.AddCookie(UMAConstants.SignInScheme);
                    c.AddOpenIdConnect(UMAConstants.ChallengeAuthenticationScheme, options =>
                     {
                         options.ClientId = "umaClient";
                         options.ClientSecret = "umaClientSecret";
                         options.Authority = "https://localhost:60000";
                         options.ResponseType = OpenIdConnectResponseType.CodeIdToken;
                         options.SaveTokens = true;
                     });
                })
            .AddScopes(DefaultConfiguration.DefaultScopes)
            .AddJsonWebKeys(new List<JsonWebKey> { oauthJsonWebKey });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(LogLevel.Information);
            var options = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(options.Value);
            app.UseSID();
        }

        private JsonWebKey ExtractOAuthJsonWebKey()
        {
            using (var rsa = RSA.Create())
            {
                var json = File.ReadAllText(Path.Combine(_env.ContentRootPath, "oauth_key.txt"));
                var dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                rsa.Import(dic);
                return new JsonWebKeyBuilder().NewSign("1", new[]
                {
                    KeyOperations.Sign,
                    KeyOperations.Verify
                }).SetAlg(rsa, "RS256").Build();
            }
        }

        private JsonWebKey ExtractOpenIDJsonWebKey()
        {
            var json = File.ReadAllText(Path.Combine(_env.ContentRootPath, "openid_puk.txt"));
            var dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            var rsaParameters = new RSAParameters
            {
                Modulus = dic.TryGet(RSAFields.Modulus),
                Exponent = dic.TryGet(RSAFields.Exponent)
            };
            JsonWebKey sigJsonWebKey;
            using (var rsa = RSA.Create(rsaParameters))
            {
                sigJsonWebKey = new JsonWebKeyBuilder().NewSign("1", new[]
                {
                    KeyOperations.Verify
                }).SetAlg(rsa, "RS256").Build();
            }

            return sigJsonWebKey;
        }
    }
}