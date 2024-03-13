using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssessment
{
    internal class GroupJoining
    {
        public static void GroupJoiningExample(List<States1> states1, List<States2> states2)
        {
            var groupjoin = states2.GroupJoin(states1, y => y.groupId, z => z.stateId, (y, StateList) => new
            {
                GroupName = y.groupName,
                state = StateList.Select(x => x.state)
            });
            foreach (var group in groupjoin)
            {
                Console.WriteLine($"Group: {group.GroupName} - {group.state.Count()}");
                Console.WriteLine("--------------");
                Console.WriteLine(string.Join(", ", group.state));
                Console.WriteLine();
            }
         


}
    }
}