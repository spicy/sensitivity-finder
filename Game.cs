using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensitivityFinder
{
    public class Game
    {
        public string name;
        public double fov;

        public Game(string newName, double newFov)
        {
            name = newName;
            fov = newFov;
        }

        public string Name
        {
            get { return name; }
        }
        public double Fov
        {
            get { return fov; }
        }
    }
}
