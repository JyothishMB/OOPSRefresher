using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TurnRightCommand : ICommand
    {
        private Camera camera;
        public TurnRightCommand(Camera camera)
        {
            this.camera = camera;
        }

        public void Execute()
        {
            camera.TurnRight();
        }
    }
}
