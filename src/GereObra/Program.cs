/*
* <file>Program.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>05-11-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

using System;
using BO;

namespace Program
{
    internal class Program
    {
        /// <summary>
        /// Main do prjeto
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Cria uma morada
            Morada m = new Morada("1234-212", "BARCELOS");

            //Cria uma obra
            Obra ponte = new Obra();

            DateTime inicio = new DateTime(2025, 11, 10);
            DateTime fim = new DateTime(2026, 5, 12);

            ponte.Id = 1;
            ponte.Nome = "Construção de uma ponte";
            ponte.DataInicio = inicio;
            ponte.DataFim = fim;
            ponte.Morada = m;

            Obra estrada = new Obra(2, "Reparação da estrada x", inicio, fim, m);

        }
    }
}