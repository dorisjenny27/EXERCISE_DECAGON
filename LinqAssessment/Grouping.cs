using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssessment
{
    internal class Grouping
    {
        public static void GroupingExample(List<States> states)
        {
            var states1 = states.GroupBy(x => x.stateId);
            Console.WriteLine("Group of states in set of 6: ");
            foreach (var state in states1)
            {
                Console.WriteLine("___________________________________________________");
                
                foreach(var item in state)
                {
                    Console.Write(item.state + ", ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
