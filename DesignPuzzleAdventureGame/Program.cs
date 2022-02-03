using System;

namespace DesignPuzzleAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // random exercise in the book practice

            Character archer = new Archer();
            archer.Fight();
            archer.SetWeaponBehaviour(new KnifeBehaviour());
            archer.Fight();
            archer.SetWeaponBehaviour(new SwordBehaviour());
            archer.Fight();

            Console.ReadLine();
        }
    }

    public abstract class Character
    {
        public IWeaponBehaviour WeaponBehaviour { get; set; }

        public void SetWeaponBehaviour(IWeaponBehaviour wb)
        {
            WeaponBehaviour = wb;
        }

        public abstract void Display();
        public void Fight() => WeaponBehaviour.UseWeapon();
    }


    public interface IWeaponBehaviour
    {   
        void UseWeapon();
    }


    // a Warrior *IS-A* character
    // concrete implementation of character.
    public class Warrior : Character
    {
        public Warrior()
        {
            WeaponBehaviour = new SwordBehaviour();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a warrior.");
        }
    }
    // a Rogue *IS-A* character
    public class Rogue : Character
    {
        // abstract that implements abstract does not have to implement all methods
        public override void Display()
        {
            throw new NotImplementedException();
        }
    }



    public class Archer : Character
    {
        public Archer()
        {
            WeaponBehaviour = new BowAndArrowBehaviour();
        }

        public override void Display()
        {
            Console.WriteLine("I'm an archer.");
        }
    }
   

    public class AxeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Swings the axe..");
        }
    }

    public class BowAndArrowBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Fires the arrows..");
        }
    }

    public class KnifeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("reveals the knife, a big fuck-off-shiny one.");
        }
    }

    public class SwordBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("swings the big ass sword..");
        }
    }
}
