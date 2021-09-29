using System;

namespace Scratch
{
    class Program
    {
        static void Main(string[] args)
        {

            var o = Example.Create("David");
            o.ImFired += MyFiredPrivate;
            
            Console.WriteLine(o.Name);
            Console.WriteLine(o.ProtectedVirtual());
            o.FireEvent();
            o.Save();

            var y = ExampleSubType.Create("Davey");
            y.ProtectedVirtual();
            y.ImFired += (o, e) => { Console.WriteLine("From lambda");};
            y.FireEvent();
            y.Save();

            var z = o + y;
            
            Console.WriteLine(z.Name);
            
            z.Save();

            Console.WriteLine("Hello World!");
        }

        private static void MyFiredPrivate(object sender, FiredMethodArgs args)
        {
            Console.WriteLine("From method");
        }
    }

    public delegate void FiredMethod(object sender, FiredMethodArgs args);
}