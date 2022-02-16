using System;

namespace TheChocolateFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var choc = ChocolateBoiler.GetInstance();
            var choc2 = ChocolateBoiler.GetInstance();
            var eager = EagerSingleton.GetInstance();

            var lazyChoc = LazyChocolateBoiler.GetInstance();
            var lazy2 = LazyChocolateBoiler.GetInstance();
            Console.WriteLine("Hello World!");
        }
    }

    public class BasicSingleton // unique instance is stored as a static field.
    {
        // ** DOn't use this as a code snippet, it has problems with multithreading.
        
        private static BasicSingleton _uniqueInstance;
        private BasicSingleton(){}// private constructor.

        public static BasicSingleton GetInstance()
        {
            if (_uniqueInstance is null)
            {
                _uniqueInstance = new BasicSingleton();
            }
            return _uniqueInstance;
        }

        // normal other class methods.. singleton is still a class afterall.
        // logging..caching etc

    }

    public class ChocolateBoiler
    {
        private Boolean _empty;
        private Boolean _boiled;
        private static ChocolateBoiler _uniqueInstance;
        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (_uniqueInstance is null)
            {
                _uniqueInstance = new ChocolateBoiler();
            }
            return _uniqueInstance;
        }

        public void Fill()
        {
            if (IsEmpty()) // To fill the boiler it must be empty.
            {
                _empty = false;
                _boiled = false;
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                _empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                _boiled = true;
            }
        }

        public bool IsEmpty()
        {
            return _empty;
        }

        public bool IsBoiled()
        {
            return _boiled;
        }
    }

    public class LazyChocolateBoiler
    {
        private static Lazy<LazyChocolateBoiler> _uniqueInstance = new(() => new LazyChocolateBoiler());

        private Boolean _empty;
        private Boolean _boiled;
        private LazyChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public static LazyChocolateBoiler GetInstance()
        {                   
            return _uniqueInstance.Value;
        }

        public void Fill()
        {
            if (IsEmpty()) // To fill the boiler it must be empty.
            {
                _empty = false;
                _boiled = false;
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                _empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                _boiled = true;
            }
        }

        public bool IsEmpty()
        {
            return _empty;
        }

        public bool IsBoiled()
        {
            return _boiled;
        }
    }

    //If your application always creates and uses an instance of the Singleton,
    //or the overhead of creation and runtime aspects of the Singleton isn’t onerous,
    //you may want to create your Singleton eagerly, like this:
    public class EagerSingleton
    {
        // Eagerly load the singleton 
        private static EagerSingleton _uniqueInstance = new();
        private EagerSingleton() { }// private constructor.

        public static EagerSingleton GetInstance()
        {
            return _uniqueInstance;
        }
    }

}
