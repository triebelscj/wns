using System;
using HumanProject.Models;

namespace HumanProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Zoe = new Human("Zoe");
            Human Brent = new Human("Brent");
            Human Shirley = new Human("Shirley");

            Wizard Cj = new Wizard("Cj");
            Ninja Sam = new Ninja("Sam");
            Samurai Lisa = new Samurai("Lisa");

            Cj.Attack(Zoe);
            Sam.Attack(Shirley);
            for (int i = 0; i < 6; i++)
            {
                Lisa.Attack(Brent);
            }

            Cj.FirstAid(Zoe);
            Sam.Attack(Shirley);


        }

    }
}