using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Camera
    {
        public void TurnOn()
        {
            Console.WriteLine("Camera Activated");
        }
        public void TurnOff() 
        { 
            Console.WriteLine("Camera Deactivated"); 
        }
        public void TurnLeft()
        {
            Console.WriteLine("Turning left");
        }
        public void TurnRight()
        {
            Console.WriteLine("Turning right");
        }
        public void TurnUp()
        {
            Console.WriteLine("Turning up");
        }
        public void TurnDown()
        {
            Console.WriteLine("Turning down");
        }
    }
}
