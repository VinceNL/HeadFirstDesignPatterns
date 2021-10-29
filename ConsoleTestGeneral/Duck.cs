namespace ConsoleTestGeneral
{
    public abstract class Duck
    {
        public FlyBehavior FlyBehavior { get; set; }
        public QuackBehavior QuackBehavior { get; set; }

        protected Duck(FlyBehavior flyBehavior, QuackBehavior quackBehavior)
        {
            FlyBehavior = flyBehavior;
            QuackBehavior = quackBehavior;
        }
        public abstract void Display();
        public void PerformFly() => FlyBehavior.Fly();
        public void PerformQuack() => QuackBehavior.Quack();
        public void Swim() => System.Console.WriteLine("all ducks float down here");
    }
}
