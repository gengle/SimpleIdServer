﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.AspNetCore.Authentication.Cookies;
using SimpleIdServer.OAuth.Options;
using SimpleIdServer.OpenID.SubjectTypeBuilders;

namespace SimpleIdServer.OpenID.Options
{
    public class OpenIDHostOptions : OAuthHostOptions
    {
        public OpenIDHostOptions() : base()
        {
            DefaultSubjectType = PublicSubjectTypeBuilder.SUBJECT_TYPE;
            DefaultMaxAge = null;
            DefaultAcrValue = "sid-load-01";
            AuthenticationScheme = "MultiAccount";
            CookieName = CookieAuthenticationDefaults.CookiePrefix + AuthenticationScheme;
            SessionCookieName = CookieAuthenticationDefaults.CookiePrefix + "Session";
        }

        /// <summary>
        /// OAUTH2.0 client's default subject type.
        /// </summary>
        public string DefaultSubjectType { get; set; }
        /// <summary>
        ///  OAUTH2.0 client's default max age in seconds.
        /// </summary>
        public double? DefaultMaxAge { get; set; }
        /// <summary>
        /// Default ACR value.
        /// </summary>
        public string DefaultAcrValue { get; set; }
        /// <summary>
        /// Cookie name.
        /// </summary>
        public string CookieName { get; set; }
        /// <summary>
        /// Authentication scheme.
        /// </summary>
        public string AuthenticationScheme { get; set; }
        /// <summary>
        /// Session cookie name.
        /// </summary>
        public string SessionCookieName { get; set; }
    }
}
