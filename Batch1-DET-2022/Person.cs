using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Person
    {
        string FirstName;
        string LastName;
        string Email;
        DateOnly DOB;

        public Person(string firstName, string lastName, string email, DateOnly dOB)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.DOB = dOB;
        }
        public Person(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }
        public Person(string firstName, string lastName, DateOnly dOB)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DOB = dOB;
        }
        private static int CalculateAge(DateOnly DOB)
        {
            int age = 0;
            age = DateTime.Now.Year - DOB.Year;
            if (DateTime.Now.DayOfYear < DOB.DayOfYear)
                age = age - 1;

            return age;
        }
        public int BirthYear()
        {
            return DOB.Year;
        }
        public string GetInfo()
        {
            return $"{FirstName} {LastName}";
        }

        public string IsAdult()
        {
            int age = CalculateAge(DOB);
            if (age > 18)
            {
                return "Is Adult";
            }
            else
            {
                return "Is not an Adult";
            }
        }
        public string GetSunSign()
        {
            string str = string.Empty;
            int month = DOB.Month;
            int day = DOB.Day;
            if (((month == 3) && (day >= 21 || day <= 31)) || ((month == 4) && (day >= 01 || day <= 20)))
            {
                return "Aires";
            }
            if (((month == 4) && (day >= 21 || day <= 31)) || ((month == 5) && (day >= 01 || day <= 21)))
            {
                return "Taurus";
            }
            if (((month == 5) && (day >= 21 || day <= 31)) || ((month == 6) && (day >= 01 || day <= 21)))
            {
                return "Gemini";
            }
            if (((month == 6) && (day >= 22 || day <= 31)) || ((month == 7) && (day >= 01 || day <= 22)))
            {
                return "Cancer";
            }
            if (((month == 7) && (day >= 23 || day <= 31)) || ((month == 8) && (day >= 01 || day <= 22)))
            {
                return "leo";
            }
            if (((month == 8) && (day >= 23 || day <= 31)) || ((month == 9) && (day >= 01 || day <= 21)))
            {
                return "Virgo";
            }
            else
            {
                return "SUN SIGN UNKOWN";
            }
        }
        public string BDayStatus()
        {
            var dateNow = DateOnly.FromDateTime(DateTime.Now);
            if (DOB == dateNow)
            {
                return "IT IS THE PERSON'S BIRTHDAY";
            }
            else
            {
                return "IT IS NOT THE PERSON'S BIRTHDAY";
            }
        }
        public string DefaultUsername()
        {
            return $"{FirstName}{LastName}{DOB.Year}";
        }
        public string ChineseZodiac()
        {
            int year = DOB.Year;
            if (year % 12 == 0) { return "Monkey"; }
            else if (year % 12 == 1) { return "Rooster"; }
            else if (year % 12 == 2) { return "Dog"; }
            else if (year % 12 == 3) { return "Pig"; }
            else if (year % 12 == 4) { return "Rat"; }
            else if (year % 12 == 5) { return "Ox"; }
            else if (year % 12 == 6) { return "Tiger"; }
            else if (year % 12 == 7) { return "Rabbit"; }
            else if (year % 12 == 8) { return "Dragon"; }
            else if (year % 12 == 9) { return "Snake"; }
            else if (year % 12 == 10) { return "Horse"; }
            else { return "Sheep"; }
        }
    }
}