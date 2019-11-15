using ObjectOrientedProblems.Code.Enums;
using ObjectOrientedProblems.Code.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FightClub.Code
{
    class Implements_IPotion : IPotion
    {
        public int Healing { get; set; }
        public PotionType Type { get; set; }
        public Implements_IPotion()
        {
            Healing = 2;
            Type = PotionType.Basic;
        }

        public void SetType(PotionType potionType)
        {
            Type = potionType;
            if (Type == PotionType.Basic)
                Healing = 2;
            else if (Type == PotionType.Greater)
                Healing = 5;
        }
    }
}
