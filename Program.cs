using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {

            List<teamMember> myTeam = new List<teamMember>();
            Console.WriteLine("Plan Your Heist!");
            //add loop to break when no more names

            Console.WriteLine("How difficult is the bank?");
            int bankDifficulty = int.Parse(Console.ReadLine());

        
            for (int i = 0; i == i; i++){            
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
                if(name == ""){
                    break;
                }
            Console.WriteLine("What is your skill?");
            int skillLevel = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your courage?");
            int courageFactor = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your name is {name} with a skill of {skillLevel} and a courage of {courageFactor}");

            //this is making an empty string

            var newMember = new teamMember();

            //it can add when nothing is in it so must make empty string to add it
            newMember.createTeamMember(name, skillLevel, courageFactor);

            Console.WriteLine(newMember.name);

            
            //add member input to make a team member on our team list
            
            myTeam.Add(newMember);
            }

            Console.WriteLine($"Congrats you built a team! There are {myTeam.Count} members on your team. How many trail runs would you like to run?");

            int trails = int.Parse(Console.ReadLine());

            int teamSkillLevel = 0;
               //member is a paramter so must match like taco
            foreach (teamMember member in myTeam)
            {
                teamSkillLevel += member.skillLevel;
            };

            int failedTrails = 0;
            int successTrails = 0;

            for(int i = 0; i < trails; i++){
                
            
            int luckFactor = new Random().Next(-10,10);
            int bankTotalDifficulty = bankDifficulty + luckFactor;
            
              

            
         
            //Display the team's skill level and bank's difficult level.
            Console.WriteLine($"The team's skill level is {teamSkillLevel}");
            Console.WriteLine($"The banks's difficulty level is {bankTotalDifficulty}");

            if(teamSkillLevel > bankDifficulty)
            {
                Console.Write("Congrats youll succeed!");
                successTrails += 1;
                //if your successfuly adding one to the number so they can be added up at the end
            } else 
            {
                Console.WriteLine("You better go back to the drawing board." );
                failedTrails += 1;
            }
            Console.WriteLine("--------------------------");
        };
        Console.WriteLine($"The team's sucesses is {successTrails}");
        Console.WriteLine($"you failed {failedTrails}");
        
        }
        
        }

        
    }

