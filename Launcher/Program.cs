﻿using Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();                                     

            Console.WriteLine(person.GetObjectName());
            Console.ReadLine();
        }
    }
}
