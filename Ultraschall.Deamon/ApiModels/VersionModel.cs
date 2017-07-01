// Copyright (c) 2017 Ultraschall. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ultraschall.Deamon.ApiModels
{
    public class VersionModel
    {
        public int Major { get; set; }

        public int Minor { get; set; }

        public int Patch { get; set; }

        public string Build { get; set; }

        public string Value
        {
            get
            {
                return $"{this.Major}.{this.Minor}.{this.Patch}-{this.Build}";
            }
        }
    }
}
