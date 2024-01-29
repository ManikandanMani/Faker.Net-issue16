// See https://aka.ms/new-console-template for more information
using ClassLib;
using System;
namespace ConsoleApp
{
    class Test
    {
        static void Main()
        {
            Console.WriteLine(new GetFakerStringInstance().GetFakerString());
            Console.WriteLine( GetStaticFakerStringInstance.GetFakerString());



        }

    }
}