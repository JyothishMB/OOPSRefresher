using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ControlPanel
    {
        ICommand turnOn;
        ICommand turnOff;
        ICommand turnLeft;
        ICommand turnRight;
        ICommand turnUp;
        ICommand turnDown;
        CommandInvoker commandInvoker;
        public ControlPanel(Camera camera)
        {
            turnOn = new TurnOnCommand(camera);
            turnOff = new TurnOffCommand(camera);
            turnLeft = new TurnLeftCommand(camera);
            turnRight = new TurnRightCommand(camera);
            turnUp = new TurnUpCommand(camera);
            turnDown = new TurnDownCommand(camera);
            commandInvoker = new CommandInvoker();
        }

        public void RotateCamera(bool left, bool right, bool up, bool down)
        {
            if(left)
            {
                TurnLeft();
            }
            if(right)
            {
                TurnRight();
            }
            if(up)
            {
                TurnUp();
            }
            if(down)
            {
                TurnDown();
            }
        }
        public void Activate()
        {
            commandInvoker.SetCommand(turnOn);
            commandInvoker.ExecuteCommand();
        }
        public void DeActivate()
        {
            commandInvoker.SetCommand(turnOff);
            commandInvoker.ExecuteCommand();
        }
        private void TurnLeft()
        {
            commandInvoker.SetCommand(turnLeft);
            commandInvoker.ExecuteCommand();
        }
        private void TurnRight()
        {
            commandInvoker.SetCommand(turnRight);
            commandInvoker.ExecuteCommand();
        }
        private void TurnUp()
        {
            commandInvoker.SetCommand(turnUp);
            commandInvoker.ExecuteCommand();
        }
        private void TurnDown()
        {
            commandInvoker.SetCommand(turnDown);
            commandInvoker.ExecuteCommand();
        }
    }
}
