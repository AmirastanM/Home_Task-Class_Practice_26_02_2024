using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework26_02_2024.Models
{
    public class Car
    {

        private string name;
        public string color;
        public int speed;


    private Car()
        {

        }
    private Car()
        {
            Console.WriteLine("Reshad bey bu da sizin uchun Private constructor");
        }

        public Car (int a) : this()
        {

        }
    
    }
}
