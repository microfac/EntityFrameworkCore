// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.TestUtilities.Xunit;
using Xunit.Abstractions;

namespace Microsoft.EntityFrameworkCore.Query
{
    public class GearsOfWarQueryInMemoryTest : GearsOfWarQueryTestBase<GearsOfWarQueryInMemoryFixture>
    {
        public GearsOfWarQueryInMemoryTest(GearsOfWarQueryInMemoryFixture fixture, ITestOutputHelper testOutputHelper)
            : base(fixture)
        {
            //TestLoggerFactory.TestOutputHelper = testOutputHelper;
        }

        [ConditionalFact(Skip = "issue #12295")]
        public override Task Double_order_by_on_nullable_bool_coming_from_optional_navigation()
        {
            return base.Double_order_by_on_nullable_bool_coming_from_optional_navigation();
        }
    }
}
