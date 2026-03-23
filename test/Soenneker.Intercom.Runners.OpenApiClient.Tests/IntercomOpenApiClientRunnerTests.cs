using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Intercom.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class IntercomOpenApiClientRunnerTests : FixturedUnitTest
{
    public IntercomOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
