using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;
using System.Xml.Linq;
using static C_learning2.class1;

namespace C_learning2
{
    public static class Program
    {
        public static void Main()
        {
            //070426
            Console.WriteLine(roll);

            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");

            Console.WriteLine(largervalue);

            Console.WriteLine($"Dice roll: {roll4} + {roll5} + {roll6} = {totalroll456}");

            if ((roll4 == roll5) || (roll5 == roll6) || (roll4 == roll6))
            {
                if ((roll4 == roll5) && (roll5 == roll6))
                {
                    Console.WriteLine("You rolled triples! +6 bonus to total!");
                    totalroll456 += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles! +2 bonus to total!");
                    totalroll456 += 2;
                }
                Console.WriteLine($"Your total including the bonus: {totalroll456}");
            }

            if (totalroll456 >= 16)
            {
                Console.WriteLine("You win a new car!");
            }
            else if (totalroll456 >= 10)
            {
                Console.WriteLine("You win a new laptop!");
            }
            else if (totalroll456 == 7)
            {
                Console.WriteLine("You win a trip for two!");
            }
            else
            {
                Console.WriteLine("You win a kitten!");
            }

            Console.WriteLine(result);
            if (message.Contains("fox"))
            { Console.WriteLine("What does the fox say?"); }



            if (daysuntilexp is <= 10 and > 5)
            {
                Console.WriteLine("Your subscription will expire soon.Renew now!");
            }
            if (daysuntilexp is <= 5 and > 1)
            {
                Console.WriteLine($"Your subscription expires in {daysuntilexp} days. Renew now and save 10%! ");
                discountPercentage = 10;
            }
            if (daysuntilexp == 1)
            {
                Console.WriteLine($"Your subscription expires within a day!. Renew now and save 20%! ");
                discountPercentage = 20;
            }
            if (daysuntilexp == 0)
            {
                Console.WriteLine("Your subscription has expired");
            }
            else
            {
                Console.WriteLine();

            }

            //080426
            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";
            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");

            }

            Console.WriteLine($"We have {sum} items in inventory.");

            foreach (string productid in productsids)
            {
                if (productid.StartsWith("B"))
                {
                    //Console.WriteLine($"The name starts with 'B' !");
                    Console.WriteLine(productid);
                }


            }
        }
    }
}
    

