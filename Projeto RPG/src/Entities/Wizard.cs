namespace Projeto_RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HitPoint, int MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType; 
            this.HitPoint = HitPoint;
            this.MagicPoint = MagicPoint;

        }
        public override string Attack()
        {
            return this.Name + " lançou magia";

        }
        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou magia super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou magia com força fraca com bonus de " + Bonus;
            }
            

        }
        
    }
}