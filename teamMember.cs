using System;
using System.Collections.Generic;

namespace Heist
{

public class teamMember
        {
            public string name {get; set;}
            public int skillLvl {get; set;}
            public double courageFactor {get; set;}

            public void createTeamMember(string nameInput, int skillInput, double courageInput)
        {
            name = nameInput,
            skillLvl = skillInput;
            courageFactor = courageInput;
        }

        }
        
}