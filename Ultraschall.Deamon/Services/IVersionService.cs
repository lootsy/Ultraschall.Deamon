// Copyright (c) 2017 Ultraschall. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Ultraschall.Deamon.ApiModels;

namespace Ultraschall.Deamon.Services
{
    public interface IVersionService
    {
        VersionModel GetVersion();
    }
}
