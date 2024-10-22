using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TurnOnCommand : ICommand
    {
        private Camera camera;
        public TurnOnCommand(Camera camera)
        {
            this.camera = camera;
        }

        public void Execute()
        {
            camera.TurnOn();
        }
    }
}
