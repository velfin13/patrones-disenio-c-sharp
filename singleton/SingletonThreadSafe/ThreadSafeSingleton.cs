

namespace SingletonThreadSafe
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance;
        private static readonly object _lock = new object();

        private ThreadSafeSingleton()
        {
            
        }

        public static ThreadSafeSingleton GetInstance() 
        {
            if (_instance == null)
            {
                // con esto nos aseguramos de que solo  un hilo verifique si esta creado la instancia
                // con esta implemetacion garantizamos que sea una sola instancia la que se cree asi existan multiples hilos
                lock (_lock) 
                {
                    if (_instance == null)
                    {
                        _instance = new ThreadSafeSingleton();
                    }
                }
            }
            return _instance;
        }
    }
}
