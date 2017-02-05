using System;
using NUnit.Framework;

namespace AOUT.CH3.LogAnFM2.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void overrideTestWithoutStub()
        {
            TestableLogAnalyzer logan = new TestableLogAnalyzer();
            logan.IsSupported = true;
            bool result = logan.IsValidLogFileName("file.exe");
            Assert.True(result,"...");
        }
        class TestableLogAnalyzer : LogAnalyzerUsingFactoryMethod
        {
            public bool IsSupported;
            protected override bool IsValid(string fileName)
            {
                return IsSupported;
            }
        }
    }
}
