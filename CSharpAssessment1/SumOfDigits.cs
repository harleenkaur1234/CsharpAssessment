using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment1
{
    public class SumOfDigits
    {
        public int AddNumber(int number)
        {

            int m, sum = 0;
            while (number > 0)
            {
                m = number % 10;
                sum = sum + m;
                number /= 10;
            }
            return sum;
            
        }

    }
}
