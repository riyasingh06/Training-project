﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Event
    {
        public int EventId;
        public void CreateEvent()
        {
            Console.WriteLine("Event created!");
        }
        public void SelectEvents()
        {
            Console.WriteLine("Event Selected");
        }
    }

}
