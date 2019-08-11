using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1A
{
    class Pet
    {
        private string name;

        private int age;

        private bool isFemale;

        private string setAndGetPetName(string petName)
        {
            name = petName;
            return name;
        }

        private int setAndGetPetAge(int petAge)
        {
            age = petAge;
            return age;
        }

        private bool setAndGetPetIsFemale(string yn)
        {
            switch(yn)
            {
                case "Y":
                case "y":
                case "YES":
                case "Yes":
                case "yes":
                case "Female":
                case "female":
                case "FEMALE":
                    isFemale = true;
                    break;
                case "N":
                case "n":
                case "NO":
                case "No":
                case "no":
                case "male":
                case "Male":
                case "MALE":
                    isFemale = false;
                    break;
            }

            return isFemale;
        }

        private void ReadAndSavePetData()
        {
            Console.WriteLine("Greetings from a Pet object!");
            Console.ReadLine();

            Console.WriteLine("What is the name of your pet?");
            setAndGetPetName(Console.ReadLine());

            Console.WriteLine("What is the age of " + name + "?");
            setAndGetPetAge(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Is your pet a female (y/n)?");
            setAndGetPetIsFemale(Console.ReadLine());
        }

        public void Start()
        {
            ReadAndSavePetData();
            DisplayPetInfo();
        }

        public void DisplayPetInfo()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Name: " + name + " Age: " + age);
            if(!isFemale)
            {
                Console.WriteLine(name + " is a good boy");
            }
            else
            {
                Console.WriteLine(name + " is a good girl!");
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            Console.ReadLine();
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
