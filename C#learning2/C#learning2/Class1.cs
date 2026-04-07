using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace C_learning2
{

    public static class class1
    {
        //070426
        public static Random dice = new();
        public static int roll = dice.Next(1, 7);

        public static int roll1 = dice.Next();
        public static int roll2 = dice.Next(101);
        public static int roll3 = dice.Next(50, 101);

        public static int firstvalue = 500;
        public static int secondvalue = 600;
        public static int largervalue = Math.Max(firstvalue, secondvalue);
        
        public static int roll4 = dice.Next(1, 7);
        public static int roll5 = dice.Next(1, 7);
        public static int roll6 = dice.Next(1, 7);
        public static int totalroll456 = roll4 + roll5 + roll6;

        public static string message = "The quick brown fox jumps over the lazy dog.";
        public static bool result = message.Contains("dog");

        public static Random rand = new();
        public static int daysuntilexp = rand.Next(12);
        public static int discountPercentage = 0;













    }


}

  
       
    
      
    


