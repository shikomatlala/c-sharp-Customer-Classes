using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrder
{
    class Program
    {

        static void Main(string[] args)
        {
            //Let us check if the value is numeric

            CustomerModel x1 = new CustomerModel();
            Console.Write("CUSTOMER ID :  ");
            try
            {
                x1.CustomerID = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("Cannot convert the format to int value has been set automatically");
                x1.CustomerID = 0;
            }
            Console.Write("NAME :  ");
            x1.Name = Console.ReadLine();
            Console.Write("SURNAME :  ");
            x1.Surname = Console.ReadLine();
            Console.Write("EMAIL ADDRESS :  ");
            x1.EmailAddress = Console.ReadLine();
            Console.Write("PHONE NUMBER :  ");
            x1.PhoneNumber = Console.ReadLine();

            Console.WriteLine(x1.PhoneNumber);
            Console.ReadLine();

            Console.ReadLine();
        } 

    }
}

//char x = 'a';
////char y = '0';
//char z = '9';

//bool numFound = true;

//if(numFound)
//{
//    Console.WriteLine(x + " is a number");
//}
//else
//{

//    Console.WriteLine(x + " is not a number");
//}

//CustomerModel x1 = new CustomerModel();
//x1.CustomerID = 1;
//            x1.Name = "shiko";
//            x1.Surname = "Matlala";
//            x1.EmailAddress = "shikomatlala@gmail.com";
//            x1.PhoneNumber = "0129093322";

//            Console.WriteLine(x1.Name + "\n" + x1.Surname + "\nCustomerID " + x1.CustomerID + "\n" + x1.EmailAddress + "\n" + x1.PhoneNumber);

//            Console.ReadLine();

////Create our object
//CustomerModel people = new CustomerModel();
////people.customerID = 1;
////people.name = "Shiko";
////people.surname = "Matlala";
////people.emailAddress = "shikomatlala@gmail.com";


//CustomerModel people2 = new CustomerModel(2, "Bonolo", "Shilaluke", "bonololuke@gmail.com", "012");
////CustomerModel people3 = new CustomerModel();
////people2();


////Print the customer that I just created
////Console.WriteLine(people.emailAddress +  "  " + people.name + " " + people.surname);
//Console.WriteLine();
//Console.WriteLine(people2.customerID.ToString() + " \n" + people2.name + " \n" + people2.surname + " \n" + people2.emailAddress + " \n" + people2.phoneNumber);

