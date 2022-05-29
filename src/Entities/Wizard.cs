namespace dotnet_robot_achilles.src.Entities
{
    public class Wizard : Hero
    {
    
    //Construtor
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level= Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Lançou Magia";
        }

        //polimorfismo
        public string Attack(int Bonus){
            if (Bonus > 6)
            {
                return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
            }else
            {
                return this.Name + " Lançou Magia pouca força com Bonus de " + Bonus;
            }
        }
    
    }
}