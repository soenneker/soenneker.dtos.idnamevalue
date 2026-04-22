using Soenneker.Tests.HostedUnit;

namespace Soenneker.Dtos.IdNameValue.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class IdNameValueTests : HostedUnitTest
{
    public IdNameValueTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
