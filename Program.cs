using System;

namespace Assignment_1_Reciept_1
{ // Programer: Marlena Fabrick
 //  Date: 1/30/2021
 //  Purpose: Add up sum of groceries, multiply tax, and achieve total.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("       ABCD Super Market Reciept");
            Console.WriteLine("==========================================================================");
            Console.WriteLine("");
            Console.WriteLine("");
            decimal number1; // declare first number to add
            decimal number2; // declare second number to add
            decimal number3; // declare second number to add
            decimal number4; // declare first number to add
            decimal number5; // declare second number to add
            decimal number6; // declare second number to add
            decimal add; //declare sum of number1, number2, number3, number4, number5, and number6
            decimal tax; // Multiplication for tax
            decimal total; // combines tax and sum for the total.
        

            Console.Write("              Apple: "); // prompt user
                                     //a = Console.ReadLine();

            number1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("             Orange: "); // prompt user
                                      // read second number from user
            number2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("         Watermelon: "); // prompt user
                                          // read third number from user
            number3 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("              Water: "); // prompt user
                                     //read fourth number from user

            number4 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("             Grapes: "); // prompt user
                                      // read fifth number from user
            number5 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("               Milk: "); // prompt user
                                    // read sixth number from user
            number6 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("==========================================================================");
            Console.WriteLine("");
            Console.WriteLine("");

             add = number1 + number2 + number3 + number4 + number5 + number6;
             tax = add * 0.065m ;
             total = add + tax;
         

            Console.WriteLine("           Subtotal: ${0}", String.Format("{0:0.00}", add)); // display sum
            Console.WriteLine("                Tax: ${0}", String.Format("{0:0.00}", tax)); // display tax
            Console.WriteLine("              Total: ${0}", String.Format("{0:0.00}", total)); // display total
        }
    }
}
