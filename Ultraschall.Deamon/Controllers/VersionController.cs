// Copyright (c) 2017 Ultraschall. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ultraschall.Deamon.ApiModels;
using Ultraschall.Deamon.Services;

namespace Ultraschall.Deamon.Controllers
{
    [Route("api/[controller]")]
    public class VersionController : Controller
    {
        private IVersionService service;

        public VersionController(IVersionService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }

        // GET api/version
        [HttpGet]
        public VersionModel Get()
        {
            return this.service.GetVersion();
        }
    }
}
