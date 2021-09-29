using System;

namespace Scratch
{
    public static class Extensions
    {
        public static void Save(this ExampleBase example)
        {
            Console.WriteLine($"{example.Name} saved");
        }
    }
}