using System;
using dotnet_robot_achilles.src.Entities;

namespace dotnet_robot_achilles{
  class Program{
    static void Main (string[] args)
    {
      Arus hero = new Arus("Arus", 23, "knight");
      //Arus oponnet = new Arus("Maleficus", 99, "Devil");
      Arus wizard = new Arus("Jennica", 23, "White Wizard");
      //caixinha azul propriedade roxa: método
      

      Console.Write(wizard.Attack());
    }
  }
}
