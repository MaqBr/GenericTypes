using System;

namespace GenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var macho = new Cachorro();
            var femea = new Cachorro();
            var obj = new Cachorro();

            var filhote = obj.Cruzar(macho, femea);

        }

    }
}
