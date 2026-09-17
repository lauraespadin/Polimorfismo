using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Macaco : Animal
    {
        public override  void EmitirSom()
        {
            Console.WriteLine("O macaco faz: UGH UGH AAH AAH");
        }
    }
}
