using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LINQ.Test
{
    [TestClass]
    public class ExtensionsTest
    {
        [TestMethod]
        public void MyContains()
        {
            var text = "ABCD";
            text.MyContains("BC").Should().Be(true);
            text.MyContains("BA").Should().Be(false);
        }
    }
}
