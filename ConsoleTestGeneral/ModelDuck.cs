using System;

namespace ConsoleTestGeneral
{
    public class ModelDuck : Duck
    {
        public ModelDuck() : base(new FlyNoWay(), new RealQuack()) { }
        public override void Display() => Console.WriteLine("Im a ModelDuck");
    }
}
