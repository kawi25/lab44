using System;

namespace lab44
{
    class Program
    {
        static void Main(string[] args)
        {
          Hashtable lista = new Hashtable(),
          Console.Writeline(lista.count);

            for (int i = 0; i < 10; i++)
            {
                lista.Add(i, "Dato" + i);
            }
            foreach (int key in lista.keys)
            {
                Console.Writeline("clave: {0} === valor: {1}", key, lista[key]);
            }
        }
    }
}
