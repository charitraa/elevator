using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    internal class Log
    {
        public string action;

        // Constructor to initialize the Action property
        public Log(string action)
        {
            Action = action;
        }

        // Property with getter and setter for Action
        public string Action
        {
            get { return action; }
            set { action = value; }
        }
    }
}
