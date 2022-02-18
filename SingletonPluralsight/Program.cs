using System;

namespace SingletonPluralsight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public sealed class BadSingleton
    {
        private static BadSingleton _instance;
        private static BadSingleton Instance
        {
            get
            {
                //Logger.Log("Instance called.")
                if (_instance == null)
                {
                    _instance = new BadSingleton();
                }
                return _instance;
            }
        }
        private BadSingleton()
        {
            // cannot be created except within this class.
            //Logger.Log("Constructor Invoked.")

        }
    }


    //https://www.youtube.com/watch?v=sbML3xFHRbI&t=16s
    public sealed class SingletonLock : IDisposable
    {
        private bool _dispose;
        private static volatile SingletonLock _instance;
        //ensures that the instantiation is complete before it can be accessed further. - Helping with thread safety.
        private static readonly object _synclock = new();

        private SingletonLock()
        { }

        public static SingletonLock Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_synclock) // this is single threaded
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonLock(); // double lock pattern not needed since c# 6 volatile fix
                    }

                }
                return _instance;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if (_dispose)
            {
                return;
            }
            if (disposing)
            {
                _instance = null;
            }
        }
    }


#nullable enable
    public sealed class NullableSingleton
    {
        private static NullableSingleton? _instance;
        private static NullableSingleton Instance
        {
            get
            {
                //Logger.Log("Instance called.")

                return _instance ??= new NullableSingleton();
                // only evaluates the right side of the expression, if the left side is null.

            }
        }
        private NullableSingleton()
        {
            // cannot be created except within this class.
            //Logger.Log("Constructor Invoked.")

        }
    }
}
