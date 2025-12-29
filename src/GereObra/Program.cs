/*
* <file>Program.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>17-12-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

using BO;
using Dados;
using Regras;

namespace GereObra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //resposta
            bool res = false;

            //Cria uma morada
            Morada m = new Morada();

            DateTime hoje = new DateTime(2025, 12, 18);
            DateTime amanha = new DateTime(2025,12, 19);

            //Cria uma obra
            Obra o = new Obra(1,"Construção da ponte 123", m, hoje, amanha);

            //Cria um trabalhador
            Trabalhador t1 = new Trabalhador(1, "Pedro", "Operador de máquinas", 1.5);

            //Cria um servico
            Servico s1 = new Servico(1, "Fazer ponte", 30, "Planeamento", t1);
            
            //Cria uma obra completa
            Servicos obraCompleta = new Servicos();

            res = ControlaServicos.TentaInserirServico(s1, obraCompleta);

            if(res == true)
            {
                //inseriu
            }
            else
            {
                //erro
            }

            res = ControlaServicos.TentaInserirServico(s1, obraCompleta);//Já foi inserido!!

            res = ControlaServicos.TentaVerificarServico(1, obraCompleta);

            res = ControlaServicos.TentaRemoverServico(s1, obraCompleta);

            if(res == true)
            {
                //Foi removido
            }
            else
            {
                //Não está na lista ou já tinha removido
            }


            Trabalhador t2 = new Trabalhador(2, "José", "Pintor", 2.0);

            res = ControlaTrabalhadores.TentaInserirTrabalhador(t1);

            //res = ControlaTrabalhadores.TentaGravarBin("dados.bin");

            res = ControlaTrabalhadores.TentaLerBin("dados.bin");

            //Console.WriteLine(res);

            int n = ControlaTrabalhadores.TentaContarTrabalhadores();

            //Console.WriteLine(n);

           
        }
    }
}