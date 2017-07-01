// Copyright (c) 2017 Ultraschall. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ultraschall.Deamon.Services;

namespace Ultraschall.Deamon.Tests
{
    [TestClass]
    public class VersionServiceUnitTest
    {
        [TestMethod]
        public void VersionCheck()
        {
            var service = new VersionService();
            var version = service.GetVersion();
            Assert.AreEqual(1, version.Major);
            Assert.AreEqual(0, version.Minor);
            Assert.AreEqual(0, version.Patch);
            Assert.AreEqual("alpha.1", version.Build);
            Assert.AreEqual("1.0.0-alpha.1", version.Value);
        }
    }
}
