using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Composite : IComponent
    {
        private string Name {  get; set; }

        List<IComponent> components = new List<IComponent>();
        public Composite(string name)
        {
            this.Name = name;
        }

        public void AddComponent(IComponent component)
        {
            this.components.Add(component);
        }
        public void DisplayPrice()
        {
            Console.WriteLine("\nComposite -> \n\t");
            foreach (var component in this.components)
            {
                component.DisplayPrice();
            }
        }
    }
}
