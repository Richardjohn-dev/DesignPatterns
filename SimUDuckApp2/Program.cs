using System;

namespace SimUDuckApp2
{
    class Program
    {
        // Strategy pattern implemented...apparently

        //// Starts from 
        // 'What a shame to have all this dynamic talent built into our ducks and not be using it! Imagine you want to set the duck’s behavior type through a setter method on the Duck class, rather than by instantiating it in the duck’s constructor.

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the annual who gives a flying Duck show..");
            Console.WriteLine("The First Duck comes along..");
            Console.WriteLine();

            // first duck
            Duck mallard = new Mallard();
            mallard.Display();
            mallard.PerformQuack();
            mallard.PerformFly();

            Console.WriteLine();
            Console.WriteLine("Second Duck");
            Console.WriteLine("..............");

            // second duck
            Duck modelDuck = new ModelDuck();
            modelDuck.Display();
            modelDuck.PerformFly();
            modelDuck.PerformQuack();

            // inject new behaviours at runtime through the setter
            modelDuck.SetQuackBehaviour(new MegaphoneQuack());
            modelDuck.PerformQuack();
            modelDuck.SetFlyBehaviour(new FlyRocketPowered());
            modelDuck.PerformFly();

            Console.ReadLine();
        }

        // Context
        public abstract class Duck
        {
            public IFlyBehaviour FlyBehaviour { get; set; }
            public IQuackBehaviour QuackBehaviour { get; set; }

            public abstract void Display();
            public void PerformQuack() => QuackBehaviour.Quack();
            public void PerformFly() => FlyBehaviour.Fly();


            public void SetFlyBehaviour(IFlyBehaviour fb)
            {
                FlyBehaviour = fb;
            }
            public void SetQuackBehaviour(IQuackBehaviour qb)
            {
                QuackBehaviour = qb;
            }
        }

        #region Strategies
        // Strategies
        public interface IFlyBehaviour
        {
            void Fly();
        }

        public interface IQuackBehaviour
        {
            void Quack();
        }
        #endregion

        #region ConcreteQuackStrategies
        public class StandardQuack : IQuackBehaviour
        {
            public void Quack() => Console.WriteLine("Does a bog standard duck quack");
        }
        public class LoudQuack : IQuackBehaviour
        {
            public void Quack() => Console.WriteLine("Bellows a huge deafening quack");
        }
        public class SqueakyQuack : IQuackBehaviour
        {
            public void Quack() => Console.WriteLine("Squeaks out a pathetic quack");
        }
        public class NoQuack : IQuackBehaviour
        {
            public void Quack() => Console.WriteLine("Cant quack..pathetic");
        }
        public class MegaphoneQuack : IQuackBehaviour
        {
            public MegaphoneQuack() => Console.WriteLine("Whats this.. he's got a Megaphone..");
            public void Quack()
            {
                Console.WriteLine("****HOOOOOOOOONK***");
                Console.WriteLine("****HOOOOOOOOOOOOOOONK***");
                Console.WriteLine("****HOOOOOOOOOOOOOOOOOOOONK***");
            }
        }

        #endregion

        #region ConcreteFlyStrategies
        public class FlyWithWings : IFlyBehaviour
        {
            public void Fly()
            {
                Console.WriteLine("Shows off some impressive flying..");
            }
        }
        public class CantFly : IFlyBehaviour
        {
            public void Fly()
            {
                Console.WriteLine("He just cant fly... Lazy.");
            }
        }
        public class FlyRocketPowered : IFlyBehaviour
        {
            public FlyRocketPowered()
            {
                Console.WriteLine("Straps on a rocket pack..");
            }
            public void Fly()
            {
                Console.WriteLine("He's off like a rocket to the moon!!");
            }
        }

        #endregion

        // new
        public class ModelDuck : Duck
        {
            public ModelDuck()
            {
                FlyBehaviour = new CantFly();
                QuackBehaviour = new NoQuack();
            }
            public override void Display()
            {
                Console.WriteLine("I'm a model duck.");
            }
        }
        public class Mallard : Duck
        {
            public Mallard()
            {
                FlyBehaviour = new FlyWithWings();
                QuackBehaviour = new LoudQuack();
            }

            public override void Display()
            {
                Console.WriteLine("Hey I'm a mallard Duck.");
            }
        }

    }
}
