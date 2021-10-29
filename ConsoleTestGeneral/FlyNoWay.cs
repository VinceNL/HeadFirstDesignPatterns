using System;

namespace ConsoleTestGeneral
{
    public class FlyNoWay : FlyBehavior
    {
        public override void Fly() => Console.WriteLine("I cant fly");
    }
}
