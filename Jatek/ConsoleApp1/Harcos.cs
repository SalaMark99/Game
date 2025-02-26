﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.cs
{
    class Harcos
    {
        
        public string Name { get; set; } = "Harcos";
        public double Health { get; set; } = 0;
        public double AttkMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;
 
        
        Random rnd = new Random();
 
        
        public Harcos(string name = "Harcos", 
            double health = 0, 
            double attkMax = 0,
            double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }
 
        
        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }
 
        
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }
 
    }
}
