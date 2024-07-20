using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {

             Building building = new Building("Горького 7", 40, 12, 31);
             Console.WriteLine(building.Print());
             MultiBuilding multiBuilding = new MultiBuilding("Столетия 15", 50, 15, 22, 7);
             Console.WriteLine(multiBuilding.Print());
             Console.ReadKey();

        }
    }
}
