using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
        public class GradePoint
        {
            public char Grade { get; set; }
            public int GradeUnit { get; set; }
            public string Remarks { get; set; }

            public GradePoint(char grade, int unit)
            {
                switch (grade)
                {
                    case 'A':
                        Grade = 'A';
                        GradeUnit = 5;
                        Remarks = "Excellent";
                        break;
                    case 'B':
                        Grade = 'B';
                        GradeUnit = 4;
                        Remarks = "Very Good";
                        break;
                    case 'C':
                        Grade = 'C';
                        GradeUnit = 3;
                        Remarks = "Good";
                        break;
                    case 'D':
                        Grade = 'D';
                        GradeUnit = 2;
                        Remarks = "Fair";
                        break;
                    case 'E':
                        Grade = 'E';
                        GradeUnit = 1;
                        Remarks = "Pass";
                        break;
                    case 'F':
                        Grade = 'F';
                        GradeUnit = 0;
                        Remarks = "Fail";
                        break;
                    default:
                        Grade = ' ';
                        GradeUnit = 0;
                        Remarks = "Invalid Grade";
                        break;
                }
            }
        }
    

}
