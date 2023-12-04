namespace ConsoleAppTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
        public void TestOfInt()
        {  //Arrange
            int number1 = 2;
            int number2 = 2;
            // Act
            //Assert
            Assert.That(number2, Is.EqualTo(number1));
        }

        [Test]
        public void TestOfFloat()
        {  //Arrange
            float number1 = 12345678901234567890;
            float number2 = 12345678901234567890;
            // Act
            //Assert
            Assert.That(number2, Is.EqualTo(number1));
        }

        [Test]
        public void TestOfString()
        {  //Arrange
            string name1 = "Adam";
            string name2 = "Adam";
            // Act
            //Assert
            Assert.That(name2, Is.EqualTo(name1));
        }
}