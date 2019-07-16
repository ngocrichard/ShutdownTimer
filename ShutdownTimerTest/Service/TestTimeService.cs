using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShutdownTimer.Services;

namespace ShutdownTimerTest.Service
{
    [TestClass]
    public class TestTimeService
    {
        public TimeService timeService;

        [TestInitialize]
        public void TestInit()
        {
            timeService = new TimeService();
        }

        [TestMethod]
        public void Test_TimeSpanToString_SimleValue_ShouldConvert()
        {
            // Arrange
            var timeSpan = new TimeSpan(20, 45, 34);
            var expected = "20:45:34";

            // Act
            var result = timeService.TimeSpanToString(timeSpan);

            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void Test_StringToTimeSpan_SimleValue_ShouldConvert()
        {
            // Arrange
            var timeStr = "03:12:58";
            var expected = new TimeSpan(3, 12, 58);

            // Act
            var result = timeService.StringToTimeSpan(timeStr);

            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void Test_StringToTimeSpan_HourOutOfRange_ShouldThrowException()
        {
            // Arrange
            var timeStr = "24:12:58";

            // Act
            Action action = () => timeService.StringToTimeSpan(timeStr);

            // Assert
            Assert.ThrowsException<Exception>(action);
        }

        [TestMethod]
        public void Test_StringToTimeSpan_MinuteOutOfRange_ShouldThrowException()
        {
            // Arrange
            var timeStr = "03:60:58";

            // Act
            Action action = () => timeService.StringToTimeSpan(timeStr);

            // Assert
            Assert.ThrowsException<Exception>(action);
        }

        [TestMethod]
        public void Test_StringToTimeSpan_SecondOutOfRange_ShouldThrowException()
        {
            // Arrange
            var timeStr = "17:24:60";

            // Act
            Action action = () => timeService.StringToTimeSpan(timeStr);

            // Assert
            Assert.ThrowsException<Exception>(action);
        }
    }
}
