namespace ArmyOfCreatures.Extended
{
    using System;
    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Logic.Battles;
    using System.Text;
    using System.Globalization;
    public class DoubleDamage : Specialty
    {
        private int rounds;
        public DoubleDamage(int rounds)
        {
            if (rounds <= 0)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0");
            }

            if (rounds > 10)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be less or equal to 10");
            }

            this.rounds = rounds;
        }
        public override decimal ChangeDamageWhenAttacking(decimal currentDamage)
        {          
            if (this.rounds <= 0)
            {
                // Effect expires after fixed number of rounds
                return currentDamage;
            }

            this.rounds--;
            
            return currentDamage * 2;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.rounds);
        }
    }
}
