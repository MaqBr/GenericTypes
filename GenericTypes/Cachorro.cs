using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTypes
{
    public class Cachorro : Mamifero<Cachorro>
    {
        public string Raca { get; set; }

        public T Cruzar<T>(T macho, T femea) where T : Mamifero<T>
        {
            var filhote = Activator.CreateInstance<T>();
            filhote.Mae = femea;
            filhote.Pai = macho;
            return filhote;
        }
    }
}
