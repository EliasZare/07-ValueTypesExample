using System;
namespace _07_ValueTypesExample
{
    struct Struct
    {
        public int Value/*=null*/;
        public int Id { get; set; }
        public string Name { get; set; }
        public Struct(int id, string anem)
        {
            Id= id;
            Name= anem;
        }
        public string GetName()
        {
            return Name;
        }
    }

    public class Extension
    {
        public override bool Equals(object? obj)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return 110;
        }
    }
}
