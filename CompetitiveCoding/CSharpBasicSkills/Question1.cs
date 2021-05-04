﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitiveCoding.CSharpBasicSkills
{
    public class Question1
    {
        public class Team
        {
            public string teamName;
            public int noOfPlayers;
        }

        public class Subteam : Team
        {

            public Subteam(string initialName, int count)
            {
                teamName = initialName;
                noOfPlayers = count;
            }

            public void AddPlayer(int count)
            {
                noOfPlayers += count;
            }

            public bool RemovePlayer(int count)
            {
                if (count > noOfPlayers)
                {
                    return false;
                }
                else
                {
                    noOfPlayers -= count;
                    return true;
                }
            }

            public void ChangeTeamName(string newName)
            {
                teamName = newName;
            }
        }

        public static void Start()
        {
            if (!typeof(Subteam).IsSubclassOf(typeof(Team)))
            {
                throw new Exception("Subteam class should inherit from Team class");
            }

            String str = Console.ReadLine();
            String[] strArr = str.Split();
            string initialName = strArr[0];
            int count = Convert.ToInt32(strArr[1]);
            Subteam teamObj = new Subteam(initialName, count);
            Console.WriteLine("Team " + teamObj.teamName + " created");

            str = Console.ReadLine();
            count = Convert.ToInt32(str);
            Console.WriteLine("Current number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
            teamObj.AddPlayer(count);
            Console.WriteLine("New number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);


            str = Console.ReadLine();
            count = Convert.ToInt32(str);
            Console.WriteLine("Current number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
            var res = teamObj.RemovePlayer(count);
            if (res)
            {
                Console.WriteLine("New number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
            }
            else
            {
                Console.WriteLine("Number of players in team " + teamObj.teamName + " remains same");
            }

            str = Console.ReadLine();
            teamObj.ChangeTeamName(str);
            Console.WriteLine("Team name of team " + initialName + " changed to " + teamObj.teamName);

        }
    }
}
