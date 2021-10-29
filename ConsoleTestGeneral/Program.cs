using System;

namespace ConsoleTestGeneral
{
    class Program
    {
        static decimal UltimateRoundingFunction(decimal amountToRound, decimal nearstOf, decimal fairness)
        {
            //amountToRound => input amount
            //nearestOf => .25 if round to quarter, 0.01 for rounding to 1 cent, 1 for rounding to $1
            //fairness => btween 0 to 0.9999999___. 
            //            0 means floor and 0.99999... means ceiling. But for ceiling, I would recommend, Math.Ceiling
            //            0.5 = Standard Rounding function. It will round up the border case. i.e. 1.5 to 2 and not 1.
            //            0.4999999... Non-standard rounding function. Where border case is rounded down. i.e. 1.5 to 1 and not 2.
            //            0.75 means first 75% values will be rounded down, rest 25% value will be rounded up.
            return Math.Floor(amountToRound / nearstOf + fairness) * nearstOf;
        }

    static void Main(string[] args)
        {
            Duck model = new ModelDuck();
            model.PerformQuack();
            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();
            Console.Read();
        }
    }
}
