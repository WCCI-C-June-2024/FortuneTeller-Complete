using System.Globalization;

namespace FortuneTeller
{

    /// <summary>
    /// User Class...
    /// </summary>
    public class User
    {
        //Private fields
        private string firstName = null!;
        private string lastName = null!;
        private int age;
        private int birthMonth;
        private RoygbivEnum favoriteColor;
        private int siblings;


        /// <summary>
        /// First Name of the User.
        /// </summary>
        /// <remarks>This should never be empty</remarks>
        public string FirstName { get => firstName; set => firstName = UserValdation.ValidateFirstName(value); }
        /// <summary>
        /// Last Name of the User
        /// </summary>
        /// <remarks>This should not be Empty</remarks>
        public string LastName { get => lastName; set => lastName = UserValdation.ValidateLastName(value); }
        /// <summary>
        /// Age of User.
        /// </summary>
        /// <remarks>This must be greater then 0 and less then 130</remarks>
        public int Age { get => age; set => age = UserValdation.ValidateAge(value); }

        /// <summary>
        /// The birth month of the user
        /// </summary>
        /// <remarks>This needs to be between 1 and 12. January - December</remarks>
        public int BirthMonth { get => birthMonth; set => birthMonth = UserValdation.ValidateBirthMonth(value); }

        /// <summary>
        /// Favorite ROYGBIV Color 
        /// </summary>
        /// <remarks>Red, orange, yellow, green, blue, indigo, violet.</remarks>
        public RoygbivEnum FavoriteColor { get => favoriteColor; set => favoriteColor = value; }

        /// <summary>
        /// The Siblings of the user.
        /// </summary>
        public int Siblings { get => siblings; set => siblings = UserValdation.ValidateSiblings(value); }


        /// <summary>
        /// Used to display the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{lastName}, {firstName}\nAge {age} years\nBirth Month {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(BirthMonth)}\nFavorite Color {favoriteColor}\nSiblings {Siblings}";
        }
    }
}