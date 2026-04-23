using Soenneker.Tests.HostedUnit;

namespace Soenneker.Intercom.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class IntercomOpenApiClientRunnerTests : HostedUnitTest
{
    public IntercomOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
