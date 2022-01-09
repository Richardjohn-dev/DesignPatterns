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
            // first implementations
            Duck mallard = new Mallard();
            mallard.PerformQuack();
            mallard.PerformFly();

            // second implementations
            Duck modelDuck = new ModelDuck();
            modelDuck.PerformFly();
            modelDuck.PerformQuack();
            modelDuck.SetFlyBehaviour(new FlyRocketPowered());
            modelDuck.PerformFly();

            Console.ReadLine();
        }
           
        public abstract class Duck
        {
            public IFlyBehaviour FlyBehaviour { get; set; }
            public IQuackBehaviour QuackBehaviour { get; set; }

            public abstract void Display();
            public void PerformQuack() => QuackBehaviour.Quack();      // delegated
            public void PerformFly() => FlyBehaviour.Fly();       // delegated
                                                                  // Flex..
                                                                  // Swim..

            public void SetFlyBehaviour(IFlyBehaviour fb)
            {
                FlyBehaviour = fb;
            }
            public void SetQuackBehaviour(IQuackBehaviour qb)
            {
                QuackBehaviour = qb;
            }
        }

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

        public class FlyRocketPowered : IFlyBehaviour
        {
            public void Fly()
            {
                Console.WriteLine("I'm flying with a rocket...To infinity and beyond!!");
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
                throw new NotImplementedException();
            }
        }

        public class FlyWithWings : IFlyBehaviour
        {
            public void Fly()
            {
                Console.WriteLine("is flying");
            }
        }

        public class CantFly : IFlyBehaviour
        {
            public void Fly()
            {
                Console.WriteLine("WTF nothing happening, I'm not designed for this. Lazy.");
            }
        }

        public interface IFlyBehaviour
        {
            void Fly();
        }

        public interface IQuackBehaviour
        {
            void Quack();
        }

        public class StandardQuack : IQuackBehaviour
        {
            public void Quack()
            {
                Console.WriteLine("Gives out a recognisably standard duck quack");
            }

        }
        public class LoudQuack : IQuackBehaviour
        {
            public void Quack()
            {
                Console.WriteLine("Bellows a huge deafening quack");
            }
        }

        public class SqueakyQuack : IQuackBehaviour
        {
            public void Quack()
            {
                Console.WriteLine("Squeaks out a pathetic quack");
            }
        }
        public class NoQuack : IQuackBehaviour
        {
            public void Quack()
            {
                Console.WriteLine("Cant quack..pathetic");
            }
        }
    }
}
