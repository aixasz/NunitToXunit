﻿// Copyright (c) 2018 Jetabroad Pty Limited. All Rights Reserved.
// Licensed under the MIT license. See the LICENSE.md file in the project root for license information.

using NUnit.Framework;

namespace NUnitToXUnit.Testing
{
    [TestFixture]
    public class Unittest : object
    {
        [TearDown]
        public void TearDown()
        {
            // some cleanup here
        }
    }
}
