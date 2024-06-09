using FortuneTeller;

namespace FortuneTest
{
    /// <summary>
    /// Run test to check user fortune
    /// </summary>
    [TestFixture]
    public class UserFortuneTest
    {
        private User testUser;
        /// <summary>
        /// Setup test user
        /// </summary>
        [SetUp]
        public void Setup()
        {
            testUser = new User()
            {
                FavoriteColor = RoygbivEnum.Blue,
                Age = 20,
                Siblings = 5,
                BirthMonth = 7,
                FirstName = "Test FirstName",
                LastName = "Test Last Name"
            };

        }
        /// <summary>
        /// Run test based on age
        /// </summary>
        /// <param name="age"></param>
        /// <param name="results"></param>
        /// <param name="comment"></param>
        [Test]
        [TestCase(2, 12, "Even number produce 12 years")]
        [TestCase(3, 14, "Odd number produce 14 years")]
        [TestCase(30, 12, "Even number produce 12 years")]
        [TestCase(49, 14, "Odd number produce 14 years")]
        [TestCase(87, 14, "Odd number produce 14 years")]
        public void Retirement_Years_By_Age(int age, int results, string comment)
        {
            testUser.Age = age;
            UserFortune fortune = new UserFortune(testUser);
            Assert.That(results, Is.EqualTo(fortune.Retirement));
        }

        /// <summary>
        /// Run test based on siblings
        /// </summary>
        /// <param name="siblings"></param>
        /// <param name="results"></param>
        /// <param name="comment"></param>
        [Test]
        [TestCase(0, "Boca Raton, FL", "No Siblings")]
        [TestCase(1, "Nassau, Bahamas", "1 Siblings")]
        [TestCase(2, "Ponta Negra, Brazil", "2 Siblings")]
        [TestCase(3, "Portland, Oregon", "3 Siblings")]
        [TestCase(4, "Baton Rouge, LA", "4 Siblings")]
        [TestCase(5, "Baton Rouge, LA", "5 Siblings")]
        public void Vacation_Location_By_Number_of_Siblings(int siblings, string results, string comment)
        {
            testUser.Siblings = siblings;
            UserFortune fortune = new UserFortune(testUser);
            Assert.That(results, Is.EqualTo(fortune.Location));
        }

        /// <summary>
        /// Run Test based on color
        /// </summary>
        /// <param name="color"></param>
        /// <param name="results"></param>
        /// <param name="comment"></param>
        [Test]
        [TestCase(RoygbivEnum.Red, "Maserati", "Color is Red")]
        [TestCase(RoygbivEnum.Orange, "Stallion", "Color is Orange")]
        [TestCase(RoygbivEnum.Yellow, "Chariot", "Color is Yellow")]
        [TestCase(RoygbivEnum.Green, "Taxi", "Color is Green")]
        [TestCase(RoygbivEnum.Blue, "Rickshaw", "Color is Blue")]
        [TestCase(RoygbivEnum.Indigo, "Motor Scooter", "Color is Indigo")]
        [TestCase(RoygbivEnum.Violet, "Flying saucer", "Color is Violet")]
        public void Transportation_Type_By_Favorite_Color(RoygbivEnum color, string results, string comment)
        {
            testUser.FavoriteColor = color;
            UserFortune fortune = new UserFortune(testUser);
            Assert.That(results, Is.EqualTo(fortune.Transport));
        }
        /// <summary>
        /// Run Test based on Birth month
        /// </summary>
        /// <param name="month"></param>
        /// <param name="results"></param>
        /// <param name="comment"></param>
        [Test]
        [TestCase(1, "$256,000.76", "Balance if January")]
        [TestCase(2, "$256,000.76", "Balance if Febuary")]
        [TestCase(3, "$256,000.76", "Balance if March")]
        [TestCase(4, "$256,000.76", "Balance if April")]
        [TestCase(5, "$3,687,105.42", "Balance if May")]
        [TestCase(6, "$3,687,105.42", "Balance if June")]
        [TestCase(7, "$3,687,105.42", "Balance if July")]
        [TestCase(8, "$3,687,105.42", "Balance if August")]
        [TestCase(9, "$86.23", "Balance if September")]
        [TestCase(10, "$86.23", "Balance if October")]
        [TestCase(11, "$86.23", "Balance if November")]
        [TestCase(12, "$86.23", "Balance if December")]
        public void Bank_Balance_By_Month_Test(int month, string results, string comment)
        {
            testUser.BirthMonth = month;
            UserFortune fortune = new UserFortune(testUser);
            Assert.That(results, Is.EqualTo(fortune.Balance));
        }
    }
}
