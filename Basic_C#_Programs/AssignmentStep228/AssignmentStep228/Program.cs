﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ASSIGNMENT (Step 228)
//Perform these actions and create a console app that includes the following:
//1. Create a class. In that class, create a void method that takes two integers as parameters. Have the method do a math operation on the first integer and display the second integer to the screen.
//2. In the Main() method of the console app, instantiate the class.
//3. Call the method in the class, passing in two numbers.
//4. Call the method in the class, specifying the parameters by name.

namespace AssignmentStep228
{
    public class Program
    {
        public static int numOne = 1995;
        public static int numTwo = 2021;

        static void Main(string[] args)
        {

            MyMathClass myClass = new MyMathClass();
            myClass.SubtractionMethod(18, 22);
            myClass.SubtractionMethod(numOne, numTwo);

            Console.ReadLine();
        }
    }
}
