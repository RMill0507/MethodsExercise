﻿using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    internal class Program
    {
        
        public static int Multi(int num1, int num2) 
        {
            var answer = num1 * num2;
            return answer;

        }
       
        public static int Subtract(int num1, int num2)
        {
            var answer = num1 - num2;
            return answer;
        }
        public static int Sum(int num1, int num2,int num3)
        {
          var answer = num1 + num2 + num3;
            return answer;
        }

        static void Main(string[] args)
        {

           



            // -----------------Exercise 1-------------------------
            //Name: Rob
            //Favorite Color: Green
            //Favorite Animal: Grizzly Bear
            //Favorite Artist: George Strait

            Console.WriteLine("Hello, What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awsome color. What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Awesome! What is your favorite artist?");
            var artist = Console.ReadLine();

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Artist: {artist}");

            Console.WriteLine($"There once was a guy named {userName}");
            Console.WriteLine($"His favorite color is {color}");
            Console.WriteLine($"His favorite animal is a {animal}");
            Console.WriteLine($"He likes listening to {artist}");
            
            // -------------------Exercise 2----------------------------
            var amountOfTrucks = Sum(2, 6, 10);
            Console.WriteLine(amountOfTrucks);

            var amountOfBaseballs = Subtract(2, 6);
            Console.WriteLine(amountOfBaseballs);

            var totalFootballs = Multi(2, 10);
            Console.WriteLine(totalFootballs);








        }






        

        




    }
}