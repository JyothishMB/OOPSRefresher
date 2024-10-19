namespace Singleton.Lib
{
    public sealed class Singleton
    {
        private static int Counter = 0;

        private static Singleton Instance = null;
        private static readonly object InstanceLock = new object();

        private Singleton()
        {
            Counter++;
            Console.WriteLine($"Counter value is : {Counter}");
        }

        public static Singleton GetInstance()
        {
            if(Instance == null)
            {
                lock (InstanceLock)
                {
                    if (Instance == null)//Not thread safe
                    {
                        Instance = new Singleton();
                    }
                }
            }
            return Instance;
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}
