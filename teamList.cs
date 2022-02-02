using System;
using System.Collections.Generic;

namespace Heist
{
    public class teamList
    {
        List<teamMember> myTeam {get; set;} = new List<teamMember> <teamMember>();

        public void addMember(teamMember person)
        {
            //first is the key then the value, 
            myTeam.Add(person);
        }
    }
}