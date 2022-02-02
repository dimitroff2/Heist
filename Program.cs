using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your skill?");
            int skillLevel = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your courage?");
            int courageFactor = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your name is {name} with a skill of {skillLevel} and a courage of {courageFactor}");

            //this is making an empty string

            var newMember = new teamMember();

            //it can add when nothing is in it so must make empty string to add it
            var newMember.createTeamMember(name, skillLevel, courageFactor);

            Console.WriteLine(newMember.name);

            
            //make a new variable called myteam so we will use 
            // var myTeam = new teamList();
            List <teamList> myTeam = new List <teamList>();
            myTeam.Add(newMember);

            foreach (teamMember teaMember in myTeam)
            {
                Console.WriteLine(teamMember.name);
                Console.WriteLine(teamMember.skillLevel);
                Console.WriteLine(teamMember.courageFactor);
            }
            
        }

        
    }
}
