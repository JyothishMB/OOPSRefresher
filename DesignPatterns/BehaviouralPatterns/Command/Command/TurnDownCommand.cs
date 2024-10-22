using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TurnDownCommand : ICommand
    {
        private Camera camera;
        public TurnDownCommand(Camera camera)
        {
            this.camera = camera;
        }

        public void Execute()
        {
            camera.TurnDown();
        }
    }
}
