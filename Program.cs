﻿using System;

namespace tinyTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            tinyMath.Factorial(10);
            Console.WriteLine(tinyMath.ans);
            tinyMath.Subtract(10, 8);
			Console.WriteLine(tinyMath.ans);
            tinyMath.Add(10, 8);
			Console.WriteLine(tinyMath.ans);
            tinyMath.Divide(10, 5);
			Console.WriteLine(tinyMath.ans);
            tinyMath.Multiply(10, 5);
			Console.WriteLine(tinyMath.ans);
            tinyMath.Square(10);
			Console.WriteLine(tinyMath.ans);
            tinyMath.Cube(10);
			Console.WriteLine(tinyMath.ans);
			tinyMath.Power(10, -4);
			Console.WriteLine(tinyMath.ans);

        }
    }
}