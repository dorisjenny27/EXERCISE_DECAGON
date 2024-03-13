using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
        public class GradeManager
        {
            public GradePoint GetGradePoint(int score)
            {
                if (score >= 70 && score <= 100)
                {
                    return new GradePoint('A', 5);
                }
                else if (score >= 60 && score <= 69)
                {
                    return new GradePoint('B', 4);
                }
                else if (score >= 50 && score <= 59)
                {
                    return new GradePoint('C', 3);
                }
                else if (score >= 45 && score <= 49)
                {
                    return new GradePoint('D', 2);
                }
                else if (score >= 40 && score <= 44)
                {
                    return new GradePoint('E', 1);
                }
                else
                {
                    return new GradePoint('F', 0);
                }
            }
        }
    
}
