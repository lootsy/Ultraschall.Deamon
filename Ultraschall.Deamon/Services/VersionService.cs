// Copyright (c) 2017 Ultraschall. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ultraschall.Deamon.ApiModels;

namespace Ultraschall.Deamon.Services
{
    public class VersionService : IVersionService
    {
        private VersionModel version;

        public VersionService()
        {
            this.version = new VersionModel
            {
                Major = 1,
                Minor = 0,
                Patch = 0,
                Build = "alpha.1"
            };
        }

        public VersionModel GetVersion()
        {
            return this.version;
        }
    }
}
