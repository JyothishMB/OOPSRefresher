using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TurnLeftCommand : ICommand
    {
        private Camera camera;
        public TurnLeftCommand(Camera camera)
        {
            this.camera = camera;
        }

        public void Execute()
        {
            camera.TurnLeft();
        }
    }
}
