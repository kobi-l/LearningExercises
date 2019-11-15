using ObjectOrientedProblems.Code.Enums;
using ObjectOrientedProblems.Code.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FightClub.Code
{
    class Implements_IFighter : IFighter
    {
        public int Health { get; set; }

        public int Damage { get; set; }

        public FighterState State { get; set; }
        public Implements_IFighter()
        {
            Health = 10;
            Damage = 1;
            State = FighterState.Healthy;
        }

        public void DrinkPotion(IPotion potion)
        {
            if (Health == 0)
            {
                Health = 0;
                State = FighterState.Dead;
            }

            if (Health > 0 && Health < 10)
            {
                Health += potion.Healing;
                State = FighterState.Hurt;
            }
                
            if (Health > 10)
            {
                Health = 10;
                State = FighterState.Healthy;
            }
        }

        public void PowerUp(IPowerUp powerUp)
        {
            Damage += powerUp.DamageBuff;
            if (Damage <= 1)
                Damage = 1;
        }

        public void TakeDamage(IFighter fighter)
        {
            Health--;
            if (Health < 0)
                Health = 0;
            if (Health >= 2 && Health <= 10)
                State = FighterState.Hurt;
            if (Health == 1)
                State = FighterState.KnockedOut;
            if (Health == 0)
                State = FighterState.Dead;
        }
    }
}
