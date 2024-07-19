using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Building
    {
        string address;
        double length;
        double width;
        double height;
    
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
            
        }
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value <= 0)
                {
                    length = 0;
                    Console.WriteLine("Длина введена не корректно");
                }
                else 
                {
                    length = value;
                }
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    width = 0;
                    Console.WriteLine("Ширина введена не корректно");
                }
                else
                {
                    width = value;
                }
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                 height = value;
            }
        }

        public Building(string address, double length, double width, double height)
        {
            this.Address = address;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        
        public string Print()
        {
            return $"Адрес:{address}, Длина:{length}, Ширина:{width}, Высота:{height}";
        }

    }
}
