using ObjectOrientedProblems.Code.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FightClub.Code
{
    public class Implements_IPowerUp : IPowerUp
    {
        public int DamageBuff { get; set; }

        public Implements_IPowerUp() => DamageBuff = 1;
    }
}
