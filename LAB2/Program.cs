using LAB2.Constructions;
using System;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            var constr = new Construction(32,21,3,1,"aboba");
            constr.BuildMaterial = "abobusy";
            Console.WriteLine(constr.BuildMaterial);
        }
    }
}
