using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTypes
{
    public abstract class Mamifero<T> where T : Mamifero<T>
    {
        public T Pai { get; set; }
        public T Mae { get; set; }
        public decimal Peso { get; set; }

    }
}
