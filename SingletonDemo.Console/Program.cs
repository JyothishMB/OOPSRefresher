// See https://aka.ms/new-console-template for more information
using Singleton.Lib;

Console.WriteLine("Singleton Demo");






Parallel.Invoke(
    () => {
        Singleton.Lib.Singleton object1 = Singleton.Lib.Singleton.GetInstance();
        object1.PrintDetails("Object1");
    },
    () =>
    {
        Singleton.Lib.Singleton object2 = Singleton.Lib.Singleton.GetInstance();
        object2.PrintDetails("Object2");
    });

Console.ReadKey();