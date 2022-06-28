using JobNimubsAssessment;

namespace JobNimbusAssessment.Tests
{
    public class BracesCheckerTests
    {
        private BracesChecker _bracesChecker;

        [SetUp]
        public void Setup()
        {
            _bracesChecker = new BracesChecker();
        }

        [TestCase("")]
        [TestCase("{}")]
        [TestCase("{}{}")]
        [TestCase("{}, {}, {}")]
        [TestCase("{{ ... }}")]
        [TestCase("{abc...xyz}")]
        [TestCase("[()]{}{[()()]()}")]
        public void AreBracesMatched_ValidCases(string input)
        {
            // Arrange
            // Use TesCase as input

            // Act
            bool result = _bracesChecker.AreBracesMatched(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestCase("}")]
        [TestCase("{")]
        [TestCase("}{")]
        [TestCase("}{}{")]
        [TestCase("{{}")]
        [TestCase("{}}")]
        public void AreBracesMatched_InvalidCases(string input)
        {
            // Arrange
            // Use TesCase as input

            // Act
            bool result = _bracesChecker.AreBracesMatched(input);

            // Assert
            Assert.IsFalse(result);
        }
    }
}