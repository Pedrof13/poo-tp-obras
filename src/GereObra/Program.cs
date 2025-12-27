/*
* <file>Program.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>17-12-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

//Camada de apresentação (PL - Presentation Layer)

using System;
using BO;
using Dados;
using Regras;

namespace GereObra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ola");
            //Cria uma morada
            Morada m = new Morada();

            DateTime hoje = new DateTime(2025, 12, 18);
            DateTime amanha = new DateTime(2025,12, 19);

            //Cria uma obra
            Obra o = new Obra(1,"Construção da ponte 123", m, hoje, amanha);

             //Cria um servico
            Servico s1 = new Servico();
            
            //Cria uma obra completa
            Servicos obraCompleta = new Servicos();

            bool res = ControlaServicos.TentaInserirServico(s1, obraCompleta);

            if(res == true)
            {
                //inseriu
            }
            else
            {
                //erro
            }

            Servico? s2 = ControlaServicos.TentaEncontrarServico(1, obraCompleta);

            if(s2 == null)
            {
                //Não encontrou
            }
            else
            {
                //Encontrou
            }

            res = ControlaServicos.TentaRemoverServico(s1, obraCompleta);

            if(res == true)
            {
                //Foi removido
            }
            else
            {
                //Não está na lista ou já tinha removido
            }


        }
    }
}