using System;
using Xunit;

namespace TestHealthCheckVersion
{
    public class TestHCV
    {
        [Fact]
        public void TestStartAssemblyVersion()
        {
            #region Arrange
            var hcv = new HCV();
            #endregion
            #region Act
            string v = hcv.GetStartingAssemblyInformation();
            #endregion
            #region Assert
            Assert.Equal("1.0.0.0", v);
            #endregion
        }
        [Fact]
        public void TestHCVAssemblyVersion()
        {
            #region Arrange
            var hcv = new HCV();
            #endregion
            #region Act
            string v = hcv.GetHCVAssemblyInformation();
            #endregion
            #region Assert
            Assert.Equal("1.0.0.0", v);
            #endregion
        }
    }
}
