using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential1._4
{
    class Point
    {
        int latitude;
        int longtitude;
        string name;

        public int Latitude
        {
            get
            {
                return latitude;
            }
        }
        public int Longtitude
        {
            get
            {
                return longtitude;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Point(int latitude, int longtitude, string name)
        {
            this.latitude = latitude;
            this.longtitude = longtitude;
            this.name = name;
        }


    }

}
