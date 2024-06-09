

using FortuneTeller;

namespace FortuneTest
{

    /// <summary>
    /// User Property Validation 
    /// </summary>
    [TestFixture]
    public class UserValidationTest
    {
        private User testUser;


        /// <summary>
        /// Setup test user
        /// </summary>
        [SetUp]
        public void Setup()
        {
           testUser = new User();
        }

        /// <summary>
        /// Test first name empty validation
        /// </summary>
        [Test]
        public void First_Name_Test_for_Empty()
        {
            Assert.Throws<ValidateException>(() => testUser.FirstName.Equals(""));
        }

        /// <summary>
        /// test first name not greater then 50
        /// </summary>
        [Test]
        public void First_Name_Can_Not_Be_Greater_Then_50()
        {
            string pad = "Name";
            Assert.Throws<ValidateException>(() => testUser.FirstName = pad.PadLeft(200));
        }

        /// <summary>
        /// Test last name not empty
        /// </summary>
        [Test]
        public void Last_Name_Test_for_Empty()
        {
            Assert.Throws<ValidateException>(() => testUser.LastName = string.Empty);
        }

        /// <summary>
        /// test last name not greater then 50
        /// </summary>
        [Test]
        public void Last_Name_Can_Not_Be_Greater_Then_50()
        {
            string pad = "Name";
            Assert.Throws<ValidateException>(() => testUser.LastName = pad.PadLeft(200));
        }

        /// <summary>
        /// Test for age not greater then 130
        /// </summary>
        [Test]
        public void Age_Can_Not_Be_Greater_130()
        {
            Assert.Throws<ValidateException>(() => testUser.Age = 131);
        }

        /// <summary>
        /// Test age can not be less then 0
        /// </summary>
        [Test]
        public void Age_Can_Not_Be_Less_0()
        {
            Assert.Throws<ValidateException>(() => testUser.Age = -1);
        }
        /// <summary>
        /// Birth month less then 1
        /// </summary>
        [Test]
        public void Birth_Can_Not_Be_Less_1()
        {
            Assert.Throws<ValidateException>(() => testUser.BirthMonth = 0);
        }

        /// <summary>
        /// Birth month greater then 12
        /// </summary>
        [Test]
        public void Birth_Can_Not_Be_Greater_12()
        {
            Assert.Throws<ValidateException>(() => testUser.BirthMonth = 13);
        }
        /// <summary>
        /// Test Siblings less then 0
        /// </summary>
        [Test]
        public void Siblings_Can_Not_Be_Less_0()
        {
            Assert.Throws<ValidateException>(() => testUser.Siblings = -1);
        }
        /// <summary>
        /// Test Siblings greater then 13
        /// </summary>
        [Test]
        public void Siblings_Can_Not_Be_Greater_13()
        {
            Assert.Throws<ValidateException>(() => testUser.Siblings = 19);
        }
      
    }
}

