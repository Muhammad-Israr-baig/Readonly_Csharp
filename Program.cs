using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
namespace READ_ONLY
{
    class Program
    {
       const float pi = 3.1459f;   // const ones declared canot be changed ,compile time 
        readonly  float pie=3.1004f; // readonly doesnot neccessary needed to be declared at the intial and can be changed vary to vary in object
        Program()                    // readonly are run time
        {
            pie = 3.1459f;
        }


        static void Main(String[] args)
        {
            int rad;
            float res;
            System.Console.WriteLine("Enter the value of the radius:");
            rad = Convert.ToInt32(Console.ReadLine());
            res = pi * rad * rad;
            System.Console.WriteLine($"The Area is {res}");
            Program p = new Program();
            res = p.pie * rad * rad;
            System.Console.WriteLine($"The Area is {res}");



            


        }
    }
}