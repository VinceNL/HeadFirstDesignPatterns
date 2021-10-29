using System;

namespace ConsoleTestGeneral
{
    public class Squeek : QuackBehavior
    {
        public override void Quack() => Console.WriteLine("Squeek");
    }
}
