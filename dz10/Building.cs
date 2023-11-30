using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10
{
    internal class Building
    {
        int buildingNumber;
        int high;
        int floor;
        int flat;
        int padic;
        public Building(int buildingNumber, int high, int floor, int flat, int padic)
        {
            this.buildingNumber = buildingNumber;
            this.high = high;
            this.floor = floor;
            this.flat = flat;
            this.padic = padic;
        }
    }

}
