using System;

namespace ConsoleTestGeneral
{
    public class RealQuack : QuackBehavior
    {
        public override void Quack() => Console.WriteLine("Quack");
    }
}
