using System;

namespace ConsoleTestGeneral
{
    public class MallardDuck : Duck
    {
        public MallardDuck() : base(new FlyWithWings(), new RealQuack()) { }

        public override void Display() => Console.WriteLine("Im a real mallard for you!");
    }
}