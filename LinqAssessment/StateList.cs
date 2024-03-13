using LinqAssessment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssessment
{
    internal class StateList
    {
        public static void StateListExample()
        {
            //List used for GroupJoin
            List<States1> state1 = new List<States1>();
          
                state1.Add(new States1 { stateId = "A1", state = "Abia" });
                state1.Add(new States1 { stateId = "A1", state = "Adamawa" });
                state1.Add(new States1 { stateId = "A1", state = "Akwa-Ibom" });
                state1.Add(new States1 { stateId = "A1", state = "Anambra" });
                state1.Add(new States1 { stateId = "A2", state = "Bauchi" });
                state1.Add(new States1 { stateId = "A2", state = "Bayelsa" });
                state1.Add(new States1 { stateId = "A2", state = "Benue" });
                state1.Add(new States1 { stateId = "A2", state = "Borno" });
                state1.Add(new States1 { stateId = "A3", state = "Cross-River" });
                state1.Add(new States1 { stateId = "A4", state = "Delta" });
                state1.Add(new States1 { stateId = "A5", state = "Ebonyi" });
                state1.Add(new States1 { stateId = "A5", state = "Edo" });
                state1.Add(new States1 { stateId = "A5", state = "Ekiti" });
                state1.Add(new States1 { stateId = "A5", state = "Enugu" });
                state1.Add(new States1 { stateId = "A6", state = "Gombe" });
                state1.Add(new States1 { stateId = "A7", state = "Imo" });
                state1.Add(new States1 { stateId = "A8", state = "Jigawa" });
                state1.Add(new States1 { stateId = "A9", state = "Kaduna" });
                state1.Add(new States1 { stateId = "A9", state = "Kano" });
                state1.Add(new States1 { stateId = "A9", state = "Katsina" });
                state1.Add(new States1 { stateId = "A9", state = "Kebbi" });
                state1.Add(new States1 { stateId = "A9", state = "Kogi" });
                state1.Add(new States1 { stateId = "A9", state = "Kwara" });
                state1.Add(new States1 { stateId = "A10", state = "Lagos" });
                state1.Add(new States1 { stateId = "A11", state = "Nasarawa" });
                state1.Add(new States1 { stateId = "A11", state = "Niger" });
                state1.Add(new States1 { stateId = "A12", state = "Ogun" });
                state1.Add(new States1 { stateId = "A12", state = "Ondo" });
                state1.Add(new States1 { stateId = "A12", state = "Osun" });
                state1.Add(new States1 { stateId = "A12", state = "Oyo" });
                state1.Add(new States1 { stateId = "A13", state = "Plateau" });
                state1.Add(new States1 { stateId = "A14", state = "Rivers" });
                state1.Add(new States1 { stateId = "A15", state = "Sokoto" });
                state1.Add(new States1 { stateId = "A16", state = "Taraba" });
                state1.Add(new States1 { stateId = "A17", state = "Yobe" });
                state1.Add(new States1 { stateId = "A18", state = "Zamfara" });
            

            List<States2> state2 = new List<States2>();
            state2.Add(new States2 { groupId = "A1", groupName = "A" });
            state2.Add(new States2 { groupId = "A2", groupName = "B" });
            state2.Add(new States2 { groupId = "A3", groupName = "C" });
            state2.Add(new States2 { groupId = "A4", groupName = "D" });
            state2.Add(new States2 { groupId = "A5", groupName = "E" });
            state2.Add(new States2 { groupId = "A6", groupName = "G" });
            state2.Add(new States2 { groupId = "A7", groupName = "I" });
            state2.Add(new States2 { groupId = "A8", groupName = "J" });
            state2.Add(new States2 { groupId = "A9", groupName = "K" });
            state2.Add(new States2 { groupId = "A10", groupName = "L" });
            state2.Add(new States2 { groupId = "A11", groupName = "N" });
            state2.Add(new States2 { groupId = "A12", groupName = "O" });
            state2.Add(new States2 { groupId = "A13", groupName = "P" });
            state2.Add(new States2 { groupId = "A14", groupName = "R" });
            state2.Add(new States2 { groupId = "A15", groupName = "S" });
            state2.Add(new States2 { groupId = "A16", groupName = "T" });
            state2.Add(new States2 { groupId = "A17", groupName = "Y" });
            state2.Add(new States2 { groupId = "A18", groupName = "Z" });

            GroupJoining.GroupJoiningExample(state1, state2);
        }
    }
}
