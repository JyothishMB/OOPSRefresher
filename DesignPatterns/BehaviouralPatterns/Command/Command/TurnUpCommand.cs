using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TurnUpCommand : ICommand
    {
        private Camera camera;
        public TurnUpCommand(Camera camera)
        {
            this.camera = camera;
        }

        public void Execute()
        {
            camera.TurnUp();
        }
    }
}
