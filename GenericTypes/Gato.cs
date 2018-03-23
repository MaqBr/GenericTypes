using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTypes
{
    public class Gato : Mamifero<Gato>
    {
        public string Raca { get; set; }
        public int Bigode { get; set; }
    }
}
