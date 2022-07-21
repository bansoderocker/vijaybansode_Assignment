using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxValue
{
    internal class MaxMinValue
    {
        public int Max { get; set; }
        public int Min { get; set; }


        public MaxMinValue() { }
        public MaxMinValue(int[] myArray)
        {

            GetMax(myArray);
            GetMin(myArray);
        }

        public void GetMax(int[] myArray)
        {
            Max = myArray[0];
            foreach (int i in myArray)
            {
                if (i > Max) { Max = i; }
            }


        }
        public void GetMin(int[] myArray)
        {
            Min = myArray[0];
            foreach (int i in myArray)
            {
                if (i < Min) { Min = i; }
            }


        }
    }
}
