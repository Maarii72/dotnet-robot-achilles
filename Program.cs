using System;
using dotnet_robot_achilles.src.Entities;

namespace dotnet_robot_achilles{
  class Program{
    static void Main (string[] args)
    {
      Hero arus = new Hero("Arus", 23, "knight");
      //Arus oponnet = new Arus("Maleficus", 99, "Devil");
      Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
      //caixinha azul propriedade roxa: método
      

      Console.WriteLine(arus.Attack());
      Console.WriteLine(wizard.Attack());
    }
  }
}
