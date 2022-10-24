using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage(new Sword(), new Axe(), new Bow());
            storage.ShowTree();
        }
    }
}