using System;
using System.Collections.Generic;
using System.Text;

namespace In_class_Inheritance
{
    class Car1
    { 

        public Car1()
        {
        model = "It is a car!";
        }
    
        public string color = "red";
        public int maxSpeed = 200;
        public string model;
        public int year;
        public void fullThrottle()    // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

    }
}
