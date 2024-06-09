using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    /// <summary>
    /// User Fortunes
    /// </summary>
    public class UserFortune
    {
        private readonly User user;

        private string[] VactionLocation = {
            "Chernobyl, Ukraine",
            "Boca Raton, FL",
            "Nassau, Bahamas",
            "Ponta Negra, Brazil",
            "Portland, Oregon",
            "Baton Rouge, LA"};

        private string[] Transportation =
        {
           "Maserati",
           "Stallion",
           "Chariot",
           "Taxi",
           "Rickshaw",
           "Motor Scooter",
            "Flying saucer"};
        public UserFortune(User user)
        {
            this.user = user;
        }

        /// <summary>
        /// Get the number of years to retirement
        /// </summary>
        public int Retirement { get => RetirementYears(); }

        /// <summary>
        /// Get the location of their Vacation home
        /// </summary>
        public string Location { get => VacationHome(); }

        /// <summary>
        /// Gets the Type of Transportation
        /// </summary>
        public string Transport { get => Transportation[(int)user.FavoriteColor]; }

        /// <summary>
        /// Gets the Bank Balance
        /// </summary>
        public string Balance { get => BankBalance(); }

        public override string ToString()
        {
            return $"Retirement in {Retirement}\nVacation Home {Location}\nTransport {Transport}\nBalance {Balance}";
        }

        /// <summary>
        /// Get the Vaction Home Location base on Siblings
        /// </summary>
        /// <returns>Vaction Home location</returns>
        private string VacationHome()
        {
            string retValue = string.Empty;
            // if greater then 3 siblings 
            // Use the max length of the array
            if(user.Siblings>3)
            {
                retValue = VactionLocation[VactionLocation.Length - 1];
            }
            else
            {
                //Get the Number of siblings + 1 element from the array
                retValue = VactionLocation[user.Siblings + 1];
            }
            return retValue;
        }

        /// <summary>
        /// Get the RetirementYears based
        /// </summary>
        /// <returns>returns either 12 for even numbers and 14 for odd</returns>        
        private int RetirementYears()
        {
            int years = 14;
            if(user.Age % 2 == 0) {
                years = 12;
            }
            return years;
        }

        /// <summary>
        /// Bank Balance
        /// </summary>
        /// <returns>Bank Balance at Retirement</returns>
        private string BankBalance()
        {
            string retValue = "$0.00";
            if(user.BirthMonth >=1 && user.BirthMonth <=4)
            {
                retValue = "$256,000.76";
            }
            else if(user.BirthMonth>=5 && user.BirthMonth<=8) 
            {
                retValue = "$3,687,105.42";
            }
            else if(user.BirthMonth>=9 && user.BirthMonth<=12)
            {
                retValue = "$86.23";
            }
            return retValue;
        }

    }
}
