﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG
{
     public class Location
    {
        public int ID;
        public string Name;
        public string Description;
        public Item ItemRequiredToEnter;
        public Quest QuestAvailableHere;
        public Monster MonsterLivingHere;
        public Location LocationToNorth;
        public Location LocationToEast;
        public Location LocationToSouth;
        public Location LocationToWest;

        //Constructor
        public Location(int iD, string name, string description,
            Item itemRequiredToEnter = null, Quest questAvailableHere = null,
            Monster monsterLivingHere = null)
        {
            ID = iD;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
        }

        

    }
}
