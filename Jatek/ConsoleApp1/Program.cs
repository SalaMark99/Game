using System;
 
namespace ConsoleApp1.cs
{
    class Program
    {
        
 
        static void Main(string[] args)
        {
            Harcos pte = new Harcos("PTE", 1000, 120, 40);
            Harcos me = new Harcos("MásEgyetem", 1000, 120, 40);
 
            Csata.StartFight(pte, me);
 
            Console.ReadLine();
 
        }
        
    }
 
}