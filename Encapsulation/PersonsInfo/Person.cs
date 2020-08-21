using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PersonsInfo
{ 
  

    public class Person
    {
        

        public Person(string name, string lastName, int age, decimal salary)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        

        public string FirstName
        {
            get 
            { 
                return firstName;
            }
            private set
            {
                if (ValidateName(value))
                {
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException("First firstName cannot contain fewer than 3 symbols!");
                }
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            private set
            {
                if (ValidateName(value))
                {
                    lastName = value;
                }
                else
                {
                    throw new ArgumentException("Last firstName cannot contain fewer than 3 symbols!");
                }
                    
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                   
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
                salary = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age > 30)
            {
                Salary += Salary * percentage / 100;
            }
            else
            {
                Salary += Salary * percentage / 200;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }
        private bool ValidateName(string name)
        {
            return name?.Length > 2;
        }
    }
}