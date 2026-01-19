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

            //Cria um trabalhador
            Trabalhador t1 = new Trabalhador(1, "Pedro", "Operador de máquinas", 1.5);

            //Cria um servico
            Servico s1 = new Servico(1, "Fazer ponte", 30, "Planeamento", t1);
            
            //Cria serviços
            Servicos servicos = new Servicos();

            //Cria uma obra
            ObraToda o = new ObraToda(1, "Construção da ponte 123", m, hoje, amanha, servicos);

            res = ControlaObras.TentaInserirObra(o);

            res = ControlaObras.TentaInserirServicoObra(s1, o.Id);

            if(res == true)
            {
                //inseriu
            }
            else
            {
                //erro
            }

            res = ControlaObras.TentaInserirServicoObra(s1, o.Id);//Já foi inserido!!

            res = ControlaObras.TentaRemoverServicoObra(s1, o.Id);

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

            res = ControlaTrabalhadores.TentaGravarBin("dados.bin");
            
            //bool res = ControlaTrabalhadores.TentaLerBin("dados.bin");

            Console.WriteLine(res);

            int n = ControlaTrabalhadores.TentaContarTrabalhadores();

            Console.WriteLine(n);

           
        }
    }
}