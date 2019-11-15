using FightClub.Code;
using ObjectOrientedProblems.Code.Interfaces;
using System;

namespace ObjectOrientedProblems.Code
{
	public static class FightClubGame
	{
		public static IPowerUp PurchasePowerUp() => new Implements_IPowerUp();

		public static IPotion PurchasePotion() => new Implements_IPotion();

		public static IFighter HireFighter() => new Implements_IFighter();
	}
}