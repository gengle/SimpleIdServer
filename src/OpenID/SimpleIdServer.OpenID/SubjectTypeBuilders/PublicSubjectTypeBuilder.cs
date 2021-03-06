﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.OAuth.Api;
using System.Threading.Tasks;

namespace SimpleIdServer.OpenID.SubjectTypeBuilders
{
    public class PublicSubjectTypeBuilder : ISubjectTypeBuilder
    {
        public string SubjectType => SUBJECT_TYPE;

        public static string SUBJECT_TYPE = "public";

        public Task<string> Build(HandlerContext context)
        {
            return Task.FromResult(context.User.Id);
        }
    }
}
