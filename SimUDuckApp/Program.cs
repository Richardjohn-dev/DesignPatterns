using System;

namespace SimUDuckApp
{
    class Program
    {
        static void Main(string[] args)
        {            
            Duck mallard = new Mallard();
            mallard.PerformQuack();
            mallard.PerformFly();

            Console.ReadLine();
        }
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
}
