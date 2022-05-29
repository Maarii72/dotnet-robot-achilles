namespace dotnet_robot_achilles.src.Entities
{
    public class Arus
    {
        //construtor
        public Arus(string Name, int Level, string HeroType){
            //this = esse //ta olhando para ele mesmo, para não se confundir com outro name de outra classe
            this.Name = Name;
            this.Level= Level;
            this.HeroType = HeroType;
        }
        public string Name;
        public int Level;
        public string HeroType;
    }
}