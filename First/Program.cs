using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteAttManager concreteAttManager = new ConcreteAttManager();
            concreteAttManager.Show(15, "name", DateTime.Now);
        }
    }
}