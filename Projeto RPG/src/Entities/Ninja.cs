namespace Projeto_RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HitPoint, int MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType; 
            this.HitPoint = HitPoint;
            this.MagicPoint = MagicPoint;
        }
        public override string Attack()
        {
            return this.Name + " Lançou kunai";
        }
        
    }
}