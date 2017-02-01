using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure1 = new Figure(new Point(1, 1, "точка1"), new Point(3, 3, "точка2"), new Point(3, 1, "точка3"));
            Figure figure2 = new Figure(new Point(1, 1, "точка1"), new Point(1, 3, "точка2"), new Point(3, 3, "точка3"), new Point(3, 1, "точка4"));

            figure1.Show();
            figure2.Show();
            Console.ReadKey();
        }
    }
}
