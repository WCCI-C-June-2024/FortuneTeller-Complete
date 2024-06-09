using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    //User Validation 
    internal static class UserValdation
    {
        /// <summary>
        /// Validate the first name
        /// </summary>
        /// <param name="name"></param>
        public static string ValidateFirstName(string name)
        {
            string ErrorString;
            // Check for null or empty first name
            if (string.IsNullOrEmpty(name))
            {
                ErrorString = "First name can not be empty";
            }
            //Check length is less then 50
            else if (name.Length > 50)
            {
                ErrorString = "First Name can not be longer then 50 character";
            }
            else
            {
                // Return the value
                return name;
            }
            // if here did not pass validation, throw Validation Exception
            throw new ValidateException(ErrorString);
        }

        /// <summary>
        /// Validate the last name.
        /// </summary>
        /// <param name="name"></param>
        public static string ValidateLastName(string name)
        {
            string ErrorString;

            // Check for null or empty
            if (string.IsNullOrEmpty(name))
            {
                ErrorString = "Last Name can not be empty";
            }
            //Check length less then 50
            else if (name.Length > 50)
            {
                ErrorString = "Last Name can not be longer then 50 character";
            }
            else
            {
                // Return the value
                return name;
            }
            // if here did not pass validation, throw Validation Exception
            throw new ValidateException(ErrorString);
        }

        /// <summary>
        /// Validates age to be greater or equal then 0
        /// or less then 131
        /// </summary>
        /// <param name="howOld"></param>
        /// <returns>the int of the age</returns>
        /// <exception cref="ValidateException"></exception>
        public static int ValidateAge(int howOld)
        {
            string ErrorString;
            // checks the value to be greater then or equal to 0
            if (howOld < 0)
            {
                ErrorString = "User's Age has to be at lest 0 years old";
            }
            // checks the value to be less then or equal to 130
            else if (howOld > 130)
            {
                ErrorString = "User's Age has to be less then 131 years old";
            }
            else
            {
                // Return the value
                return howOld;
            }
            // if here did not pass validation, throw Validation Exception
            throw new ValidateException(ErrorString);
        }

        /// <summary>
        /// Validates the month from 1 to 12
        /// </summary>
        /// <param name="month"></param>
        /// <returns>month</returns>
        /// <exception cref="ValidateException"></exception>
        public static int ValidateBirthMonth(int month)
        {
            string ErrorString;
            // checks the value to be greater or equal to 1 
            if (month <= 0)
            {
                ErrorString = "Birth Month must be greater then 0";
            }
            // checks the value to be less then or equal to 12
            else if (month > 12)
            {
                ErrorString = "Birth Month must be less then or equal to 12";
            }
            else
            {
                // Return the value
                return month;
            }
            // if here did not pass validation, throw Validation Exception
            throw new ValidateException(ErrorString);
        }

        /// <summary>
        /// Validates Siblings to be greater then 0
        /// or less then 10
        /// </summary>
        /// <param name="siblings"></param>
        /// <returns>the int of the age</returns>
        /// <exception cref="ValidateException"></exception>
        public static int ValidateSiblings(int siblings)
        {
            string ErrorString;
            // the checks the vale to be greater or equal 0 
            if (siblings < 0)
            {
                ErrorString = "User's Siblings Count has to be at lest 0";
            }
            // checks the value to be less or equal 13 
            else if (siblings > 13)
            {
                ErrorString = "User's Siblings count has to be less then 13";
            }
            else
            {
                // Return the value
                return siblings;
            }
            // if here did not pass validation, throw Validation Exception
            throw new ValidateException(ErrorString);
        }
    }
}
