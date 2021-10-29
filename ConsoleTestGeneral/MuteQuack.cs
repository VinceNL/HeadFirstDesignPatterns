using System;

namespace ConsoleTestGeneral
{
    public class MuteQuack : QuackBehavior
    {
        public override void Quack() => Console.WriteLine("<<silence>>");
    }
}
