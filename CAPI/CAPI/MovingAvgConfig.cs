using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPI
{
    public class MovingAvgConfig
    {
        [Category("Moving Average Setup")]
        public int[] InputArray { get; set; }
        [Category("Moving Average Setup")]
        public int[] WindowArray { get; set; }

        [Browsable(false)]
        public double[] OutputResult { get; set; }

        public MovingAvgConfig()
        {
            InputArray = new int[] { };
            WindowArray = new int[] { };
            OutputResult = new double[] { };
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var input in InputArray)
            {
                sb.Append(input + " ");
            }

            return sb.ToString();
        }

    }
}
