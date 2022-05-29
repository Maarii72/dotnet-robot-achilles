namespace dotnet_robot_achilles.src.Entities
{
    public class Hero
    {
        //construtor
        public Hero(string Name, int Level, string HeroType){
            //this = esse //ta olhando para ele mesmo, para não se confundir com outro name de outra classe
            this.Name = Name;
            this.Level= Level;
            this.HeroType = HeroType;
        }
        public string Name;
        public int Level;
        public string HeroType;

        //método 
        /*
        String não retorna nada
        Override = sobreescrita de método
        */
        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        //método para atacar
        //virtual:permite que qualquer um alterar o comportamento
        public virtual string Attack(){
            return this.Name + " Atacou com a sua espada";
        }

    }
}