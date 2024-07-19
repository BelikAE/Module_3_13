using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    sealed class MultiBuilding:Building
    {
        int level;

        public MultiBuilding(string address, double length, double width, double height, int level)
            :base(address, length, width, height)
        {
            this.Level = level;
        }

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }

        public string Print()
        {
            string result  = base.Print();
            result += $", Этажей:{level}";
            return result;
        }
    }
}
