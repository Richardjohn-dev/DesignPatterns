//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DesignPuzzleAdventureGame
//{
//    public class refactor
//    {
//        public int _playerHealth = 100;

//        static void Main(string[] args)
//        {
//            // random exercise in the book practice

//            Character archer = new Archer();
//            archer.Fight();
//            archer.SetWeaponBehaviour(new KnifeBehaviour());
//            archer.Fight();
//            archer.SetWeaponBehaviour(new SwordBehaviour());
//            archer.Fight();

//            Console.ReadLine();
//        }


//        //public abstract class Character
//        //{
//        //    // Character *Has-A* Weapon Behaviour

//        //    public IDoDamage WeaponBehaviour { get; set; }

//        //    public void SetWeaponBehaviour(IDoDamage wb)
//        //    {
//        //        WeaponBehaviour = wb;
//        //    }

//        //    public abstract void Display();
//        //    public void Fight() => WeaponBehaviour.DoDamage();
//        //}
//        public abstract class Character
//        {
//            // Character *Has-A* Weapon Behaviour

//            public IWeapon Weaponr { get; set; }

//            public void SetWeaponBehaviour(IDoDamage wb)
//            {
//                WeaponBehaviour = wb;
//            }

//            public abstract void Display();
//            public void Fight() => WeaponBehaviour.DoDamage();
//        }


//        // an Archer *IS-A* character
//        public class Archer : Character
//        {
//            public Archer()
//            {
//                WeaponBehaviour = new BowAndArrowBehaviour();
//            }

//            public override void Display()
//            {
//                Console.WriteLine("I'm an archer.");
//            }
//        }

//        // a Warrior *IS-A* character
//        public class Warrior : Character
//        {
//            public Warrior()
//            {
//                WeaponBehaviour = new SwordBehaviour();
//            }
//            public override void Display()
//            {
//                Console.WriteLine("I'm a warrior.");
//            }
//        }
//        public class Rogue : Character
//        {
//            // abstract that implements abstract does not have to implement all methods
//            public override void Display()
//            {
//                throw new NotImplementedException();
//            }
//        }


//        public interface IDoDamage
//        {
//            void DoDamage(int damage);
//        }

      
//        // We create classes that implement IWeaponBehaviour
//        // .. each one ahving their own damage behaviour
//        public class TwoHandedAxe : Weapon_Base
//        {
//            public TwoHandedAxe()
//            {
//                damage = 60;
//                damageType = new MeleeDamage();
//            }
//            public static void DoDamage()
//            {
//                Console.WriteLine("Swings the axe..");
//            }
//        }

//        public class TwoHanded_FireAxe : Weapon_Base
//        {
//            public TwoHanded_FireAxe()
//            {
//                damage = 60;
//                damageType = new FireDamage();
//            }
//            public static void DoDamage()
//            {
//                Console.WriteLine("Swings the big axe..");
//            }

//        }
//        public class MeleeDamage : IDoDamage
//        {
//            public void DoDamage(int damage)
//            {
//                Console.WriteLine($"swings his { base.GetType()} ..");
//            }
//        }

//        public class FireDamage : IDoDamage
//        {
//            public void DoDamage(int damage)
//            {
//                Console.WriteLine("feels the burn ..");
//            }
//        }

//        public class PoisonDamage : IDoDamage
//        {
//            public void DoDamage(int damage)
//            {
//                Console.WriteLine("the poison drains .. ");
//            }
//        }



//        public class BowAndArrowBehaviour : IDoDamage
//        {
//            public void DoDamage()
//            {
//                Console.WriteLine("Fires the arrows..");
//            }
//        }

//        public class KnifeBehaviour : IDoDamage
//        {
//            public void DoDamage()
//            {
//                Console.WriteLine("reveals the knife, a big fuck-off-shiny one.");
//            }
//        }

//        public class SwordBehaviour : IDoDamage
//        {
//            public void DoDamage()
//            {
//                Console.WriteLine("swings the big ass sword..");
//            }
//        }
//    }

//}
