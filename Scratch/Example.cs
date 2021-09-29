using System;
using System.Reflection;

namespace Scratch
{
    public class Example : ExampleBase
    {
        private bool _imPrivate = true; // not accessible in sub type
        bool _NoScopeDefined = false; // defaults to prtivate
        protected bool ImProtected = false; // accessible in sub type
        private Example()
        {
            Console.WriteLine("private ctor");
        }
        protected Example(string name) // forces implementation in sub type. Not visible publicly
        {
            Name = name;
            Console.WriteLine("protected ctor");
        }
        
        protected internal string ProtectedName { get; init; }

        internal static Example Create(string name) // factory method calls private cnstructor
        {
            return new Example(name); // either works
            // return new Example { Name = name, ProtectedName = name};
        }

        internal override string ProtectedVirtual()
        {
            Console.WriteLine("I'm an override");
            return base.ProtectedVirtual();
        }

        protected override void MustImplementMe()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod()?.Name);
        }

        protected override void MustImplementMe(string arg1)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod()?.Name);
        }

        protected override void MustImplementMe(string arg1, string arg2)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod()?.Name);
        }
    }
}