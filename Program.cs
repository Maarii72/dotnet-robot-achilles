using System;
using dotnet_robot_achilles.src.Entities;

namespace dotnet_robot_achilles{
  class Program{
    static void Main (string[] args)
    {
      Knight arus = new Knight("Arus", 23, "knight");
      //Arus oponnet = new Arus("Maleficus", 99, "Devil");
      Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
      //caixinha azul propriedade roxa: método
      

      Console.WriteLine(wizard.Attack(4));
      Console.WriteLine(wizard.Attack(8));
    }
  }
}
