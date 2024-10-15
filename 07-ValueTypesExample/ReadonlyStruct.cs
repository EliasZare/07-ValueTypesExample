using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ValueTypesExample
{
    public readonly struct ReadonlyStruct
    {
        public readonly int Value/*=null*/;

        public readonly int Id { get;  }

        public readonly string Name { get;  }
        public ReadonlyStruct(int id, string name, int value)
        {
            Id = id;
            Name = name;
            Value = value;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
