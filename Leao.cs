using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Leao : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O Leão faz: ROAR!!");
        }
    }
}
