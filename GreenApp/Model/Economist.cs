using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenApp.Model
{
    internal class Economist: User
    {

        public Economist() { }

        public List<string> Autorization()
        {
            List<string> economists = new List<string>();
            return economists; 
        }
    }
}
