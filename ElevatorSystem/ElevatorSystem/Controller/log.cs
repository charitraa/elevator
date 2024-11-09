namespace ElevatorSystem
{
    // Internal class representing a Log entry in the elevator system
    internal class Log
    {
        // Field to store the action description for the log entry
        public string action;

        // Constructor to initialize the Action property with the specified action description
        public Log(string action)
        {
            Action = action;
        }

        // Property for getting and setting the action description
        public string Action
        {
            get { return action; } // Getter for retrieving the action description
            set { action = value; } // Setter for updating the action description
        }
    }
}
