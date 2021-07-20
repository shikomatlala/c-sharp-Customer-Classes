using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrder
{
    class CustomerModel
    {
        private int customerID;
        private string name;
        private string surname;
        private string emailAddress;
        private string phoneNumber;
        public int age { get; set; }


        //GETTERS & SETTERS
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                //Ensure that the phone numbers are only numaric values
                int length = value.Length;
                bool isNumeric = true;
                for(int x =0; x < length;x++)
                {
                    if (!isNum(value[x]))
                    {
                        isNumeric = false;
                    }
                }

                if (isNumeric)
                    phoneNumber = value;
                else
                    phoneNumber = "NULL";
            }
        }
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }
            set
            {
                emailAddress = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                bool snameGood = true;
                if (value.Length > 0)
                {
                    for (int x = 0; x < value.Length; x++)
                    {
                        if (!isAlpha(value[x]))
                        {
                            snameGood = false;
                            Console.WriteLine("Name has contain alphabets only");
                            x = value.Length + 1;
                        }

                    }
                    if (snameGood)
                    {
                        //Set the firstletter to uppercase

                        string firstLetter = value[0].ToString();
                        firstLetter.ToUpper();
                        value = value.Substring(0, 1).ToUpper() + value.Substring(1);
                        surname = value;
                        Console.WriteLine(surname);



                    }
                }
                else
                    Console.WriteLine("Invalid Surname");
            }
        }
        public int CustomerID //Set get customeriD
        {
            get
            {
                return customerID;
            }
            set
            {
                try
                {
                    customerID = value;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Cannot convert " + value + " to int");
                }
                 
            }
        }
        public string Name
        {
            get
            {
                return name; 
            }
            set
            {
                //Make sure that the value that you have entered is an alphabet only
                bool nameGood = true;
                if (value.Length > 0)
                {
                    for (int x = 0; x < value.Length; x++)
                    {
                        if (!isAlpha(value[x]))
                        {
                            nameGood = false;
                            Console.WriteLine("Name has contain alphabets only");
                            x = value.Length + 1;
                        }
           
                    }
                    if (nameGood)
                    {
                        //Set the firstletter to uppercase
                
                        string firstLetter = value[0].ToString();
                        firstLetter.ToUpper();
                        value = value.Substring(0, 1).ToUpper() + value.Substring(1);
                        name = value;
                        Console.WriteLine(name);
                        


                    }
                }
                else
                    Console.WriteLine("Invalid Name");
            }
        }


        static bool isAlpha(char x)
        {
            bool alphaFound = true;
            for (int y = 97; y <= 122; y++)
            {
                if (Convert.ToInt32(x) == y)
                {
                    //Console.WriteLine(y);
                    alphaFound = true;
                    y = 130;
                }
                else
                    alphaFound = false;
            }
            return alphaFound;
        }
        static bool isNum(char x)
        {
            bool numFound = true;
            for(int y = 48; y <= 57; y++)
            {
                if (Convert.ToInt32(x) != y)
                {
                    numFound = false;
                    y = 58;
                }
            }
            return numFound;

        }
    }
}
