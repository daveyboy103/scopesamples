using System;

namespace Scratch
{
    public struct MyStruct : ICloneable
    {
        public string Name { get; set; }
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}