﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HF_DesignPatterns
{
    internal class SwimNoWay : ISwimBehaviour
    {
        public void Swim()
        {
            Console.WriteLine("Sorry, I can't swim!");
        }
    }
}
