using System;

namespace ConsoleTestGeneral
{
    public class FlyWithWings : FlyBehavior
    {
        public override void Fly() => Console.WriteLine("Im flying");
    }
}
