using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTypes
{
    public class Elefante : Mamifero<Elefante>
    {
        public int Tromba { get; set; }

    }
}
