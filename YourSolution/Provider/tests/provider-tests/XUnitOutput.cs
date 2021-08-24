using Xunit.Abstractions;
using PactNet.Infrastructure.Outputters;

namespace provider_tests
{
    public class XUnitOutput : IOutput
    {
        private readonly ITestOutputHelper _output;

        public XUnitOutput(ITestOutputHelper output)
        {
            _output = output;
        }

        public void WriteLine(string line)
        {
            _output.WriteLine(line);
        }
    }
}
