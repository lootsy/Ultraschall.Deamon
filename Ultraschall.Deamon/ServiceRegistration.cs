// Copyright (c) 2017 Ultraschall. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Ultraschall.Deamon.Services;

namespace Ultraschall.Deamon
{
    public static class ServiceRegistration
    {
        public static void AddUltraschall(this IServiceCollection services)
        {
            Register(services);
        }

        public static void Register(IServiceCollection services)
        {
            services.AddSingleton<IVersionService>(new VersionService());
        }
    }
}
