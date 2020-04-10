﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SimpleIdServer.Scim.Commands.Handlers;
using SimpleIdServer.Scim.Helpers;
using SimpleIdServer.Scim.Persistence;

namespace SimpleIdServer.Scim.Api
{
    [Route(SCIMConstants.SCIMEndpoints.Groups)]
    public class GroupsController : BaseApiController
    {
        public GroupsController(IAddRepresentationCommandHandler addRepresentationCommandHandler, IDeleteRepresentationCommandHandler deleteRepresentationCommandHandler, IReplaceRepresentationCommandHandler replaceRepresentationCommandHandler, IPatchRepresentationCommandHandler patchRepresentationCommandHandler, ISCIMRepresentationQueryRepository scimRepresentationQueryRepository, ISCIMSchemaQueryRepository scimSchemaQueryRepository, IAttributeReferenceEnricher attributeReferenceEnricher, IOptionsMonitor<SCIMHostOptions> options, ILogger<GroupsController> logger) : base(SCIMConstants.SCIMEndpoints.Groups, addRepresentationCommandHandler, deleteRepresentationCommandHandler, replaceRepresentationCommandHandler, patchRepresentationCommandHandler, scimRepresentationQueryRepository, scimSchemaQueryRepository, attributeReferenceEnricher, options, logger)
        {
        }
    }
}
