﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionAssignment
{
    internal class Validation
    {
        public static bool FirstNameValidation(string fName) // Creating a method for First name validation
        {                    
            string pattern = "^[A-Z][a-z]{2,}$"; // Regex for first name validation
            //If name entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(fName, pattern)) 
            {
                Console.WriteLine($"\nYour first name \"{fName}\" is valid");
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour first name \"{fName}\" is not valid");
                Console.WriteLine("\nPlease follow naming convention of first name");
                return false;
            }
        }
        public static bool LastNameValidation(string lName) // Creating a method for Last name validation
        {
            string pattern = "^[A-Z][a-z]{2,}$"; // Regex for last name validation
            //If name entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(lName, pattern))
            {
                Console.WriteLine($"\nYour last name \"{lName}\" is valid");
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour last name \"{lName}\" is not valid");
                Console.WriteLine("\nPlease follow naming convention of last name");
                return false;
            }
        }
        public static bool EmailValidation(string email) // Creating a method for Email validation
        {
            string pattern = "^[0-9a-zA-Z]+[./+_-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9-]+[.][a-zA-Z]{2,}([.][a-zA-Z]{2,}){0,1}$"; // Regex for Email validation
            //If email address entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine($"\nYour Email address \"{email}\" is valid");
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour Email address \"{email}\" is not valid");
                return false;
            }
        }
        public static bool MobileNumberValidation(string mobileNo) // Creating a method for Mobile Number validation
        {
            string pattern = "^[0-9]{1,15}[ ][0-9]{10}$"; // Regex for Mobile number validation
            //If Mobile Number entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(mobileNo, pattern))
            {
                Console.WriteLine($"\nYour Mobile Number \"{mobileNo}\" is valid");
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour Mobile Number \"{mobileNo}\" is not valid");
                return false;
            }
        }
        public static bool PasswordValidation(string password) // Creating a method for password validation
        {
            string pattern1 = @"^((?=.{8,}$)(?=.*[0-9])(?=.*[A-Z])[A-Za-z0-9]{0,30}?[@~!#$%^&+*]{1}[a-zA-Z0-9]{0,30})$"; // Regex for password validation up to rule 4
            //If password entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(password, pattern1))
            {
                Console.WriteLine($"\nYour password \"{password}\" is valid");
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour password \"{password}\" is not follow password rules");
                return false;
            }
        }
    }
}

