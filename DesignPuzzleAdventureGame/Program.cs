using System;

namespace DesignPuzzleAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {


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

        public void Fight() => WeaponBehaviour.UseWeapon();
    }



    public class Archer : Character
    {
        public Archer()
        {
            WeaponBehaviour = new BowAndArrowBehaviour();
        }
    }

    public class Warrior : Character
    {
        public Warrior()
        {
            WeaponBehaviour = new SwordBehaviour();
        }
    }

    public interface IWeaponBehaviour
    {
        void UseWeapon();
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
