using System;
using NUnit.Framework;

namespace Test40
{
    [TestFixture]
    public class TestFor40
    {
        [Test]
        public void Example()
        {
            Assert.AreEqual(new Version(4, 0, 0, 0), typeof(int).Assembly.GetName().Version);
        }
    }
}
