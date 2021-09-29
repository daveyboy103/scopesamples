namespace Scratch
{
    public abstract class ExampleBase
    {
        public event FiredMethod ImFired;
        protected abstract void MustImplementMe();
        protected abstract void MustImplementMe(string arg1);
        protected abstract void MustImplementMe(string arg1, string arg2);

        internal void FireEvent()
        {
            if (ImFired != null) ImFired(this, new FiredMethodArgs());
        }
        internal virtual string ProtectedVirtual()
        {
            return "protected virtual";
        }
        
        internal string Name { get; init; }

        /// <summary>
        /// Operator overloading example
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static ExampleBase operator +(ExampleBase a, ExampleBase b)
        {
            return Example.Create($"{a.Name}, {b.Name}");
        }
    }
}