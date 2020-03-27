using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ03
{
    class Program
    {
        static void Main(string[] args)
        {
            Carimbo C = new Carimbo("Aprovado");
            C.carregar("", 2);
            C.usar();

            C.trocarCor("Azul");
            C.usar();


            C.carregar("Vermelho", 1);
            C.trocarTexto("Recuperação");
            C.usar();
            C.usar();

            C.carregar("Preto", 2);
            C.trocarTexto("Aprovado");
            C.usar();

            C.trocarCor("Roxo");
            C.trocarTexto("");
            C.usar();
            System.Console.ReadKey();
        }
    }
}
