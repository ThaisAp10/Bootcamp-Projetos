namespace Projeto_RPG.src.Entities
{
    public class Hero
    {
        public Hero()
        {
            
        }
        public Hero(string Name, int Level, string HeroType, int HitPoint, int MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType; 
            this.HitPoint = HitPoint;
            this.MagicPoint = MagicPoint;  
        }

        public string Name;
        public int Level;
        public string HeroType;
        public int HitPoint;
        public int MagicPoint;

        public override string ToString()
        {
            return this.Name + " Level: " + this.Level + " Tipo: " + this.HeroType + " HP: " + this.HitPoint + " MP: " + this.MagicPoint;

        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com uma espada";
        }

        public virtual string Damage()
        {
            return this.Name + " tomou um dano";
        }
    

        public virtual string Cure()
        {
            return this.Name + " se curou com poção";
        }
        
    }
}