using System;
using static System.Console;

// Write a program named BlenderS for a blender company that performs the following three tasks.

// Task 1: Displays the company motto, which is “Make your things smooth”. This motto should be surrounded by a border composed of repeated #*. 

// Task 2: The program prompts the user for a name, street address, city, zip code, and quantity of blenders ordered at $35.50 each. 

// Task 3: Display all the input data as well as calculate and display the following using an attractive format (as in the screenshot): 
// • Amount due before tax, defined as number ordered times price each
// • Sales tax, defined as 5% of the amount due
// • Net due, defined as amount due before tax, plus tax

namespace PartB
{
    class BlenderS
    {
        static void Main(string[] args)
        {
            ////////////////////TASK1/////////////////////////
            //Display the company motto
            WriteLine(" #*#*#*#*#*#*#*#*#*#*#*#*#*#*#* \n #*  Make your things smooth #* \n #*#*#*#*#*#*#*#*#*#*#*#*#*#*#* \n");

            ////////////////////TASK2////////////////////////
            //Declare values
            string name, address, city, zip;
            int quantity;
            const double blender = 35.50, tax = 0.05;
            double total, totaldue, tax_amount;
            //Set minimum/maximum number of order
            const int MIN_ORDER = 1, MAX_ORDER = 999;
            //Ask customer to input personal information
            WriteLine("Please input your information \n");
            //Name
            WriteLine(" NAME: ");
            name = ReadLine();
            //Address
            WriteLine(" ADDRESS: ");
            //City
            address = ReadLine();
            WriteLine(" CITY: ");
            //Zipcode
            city = ReadLine();
            WriteLine(" ZIPCODE: ");
            //Quantity
            zip = ReadLine();
            WriteLine(" Quantity of blenders (enter between 1 - 999): ");
            quantity = Convert.ToInt32(ReadLine());
            //Display message alert once if the customer entered an invalid quantity
            if ((quantity < MIN_ORDER) || (quantity > MAX_ORDER))
            {
                WriteLine("\n!!The quantity is too few or too many. Please enter the value between 1 - 999!!\n");
                WriteLine(" Quantity of blenders (enter between 1 - 999): ");
                quantity = Convert.ToInt32(ReadLine());
            } 
            
            ///////////////////TASK3///////////////////////
            //Display all the combined input data as shipping information
            WriteLine("\n ------------------ Receipt for -----------------------\n");
            WriteLine("<<PURCHASER>>\n {0}\n", name);
            WriteLine("<<SHIPPING ADDRESS>>\n {0}, {1}, {2}", address, city, zip);
            //Calculate amout due before tax
            total = blender * quantity;
            //Calculate tax amount
            tax_amount = total * tax;
            //Calculate total due
            totaldue = total + tax_amount;
            //Display all required data
            WriteLine("\n-------------------------------------------------------\n");
            WriteLine("{0} blender(s) for ${1} each\n", quantity, $"{blender:0.00}");
            WriteLine("{0,-30}{1,-30}", "Total: ", $"${total:0.00}");
            WriteLine("{0,-30}{1,-30}", "Tax Amount: ", $"${tax_amount:0.00} (Tax rate: {tax*100}%)");
            WriteLine("{0,-30}{1,-30}", "Total Due: ", $"${totaldue:0.00}");
            WriteLine("\n--------------Thank you for your order-----------------");

            ReadKey();
        }
    }
    
}
