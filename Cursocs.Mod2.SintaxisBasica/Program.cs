using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursocs.Mod2.SintaxisBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables inicializadas
            int edad = 23, nota = 7;
            //Declaracion de variables sin inicializar
            int intentos, veces;
            //Declaracion de variables autotipadas
            var saldo = 23.8;
            //Declaracion de un array
            int[] notas = { 6, 8, 9 };
            //declaracion de un array y asignacion de valores
            int[] notasfinales = new int[3];
            notasfinales[0] = 6;
            notasfinales[1] = 8;
            notasfinales[2] = 9;

            //incrementar una variable en 10 unidades
            edad += 23;

            //o

            edad = edad + 23;



        }
    }
}
