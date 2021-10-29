using System;

namespace ConsoleTestGeneral
{
    public class FlyRocketPowered : FlyBehavior
    {
        public override void Fly() => Console.WriteLine("Im flying with a rocket!");
    }
}
