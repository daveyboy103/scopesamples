namespace Scratch
{
    public class ExampleSubType : Example
    {
        protected ExampleSubType(string name) : base(name)
        {
            ImProtected = true;
            ProtectedName = name;
        }

        internal static ExampleSubType Create(string name)
        {
            return new ExampleSubType(name);
        }
    }
}