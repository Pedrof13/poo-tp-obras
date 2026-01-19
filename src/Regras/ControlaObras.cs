/*
* <file>ControlaObras.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>06-01-2026</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

using BO;
using Dados;

namespace Regras
{
    /// <summary>
    /// Classe para controlar Obras
    /// </summary>
    public class ControlaObras
    {

        /// <summary>
        /// Método que tenta inserir uma obra na lista
        /// </summary>
        /// <param name="o">Obra com servicos</param>
        /// <returns>True = Inseriu na lista. False = Já está na lista</returns>
        public static bool TentaInserirObra(ObraToda o)
        {
            bool resposta = Obras.InsereObra(o);
            return resposta;
        }

        /// <summary>
        /// Método que tenta remover uma obra na lista
        /// </summary>
        /// <param name="o">Obra com serviços</param>
        /// <returns>True = Inseriu na lista. False = Já está na lista</returns>
        public static bool TentaRemoverObra(ObraToda o)
        {
            bool resposta = Obras.RemoveObra(o);
            return resposta;
        }
        
        /// <summary>
        /// Método que tenta inserir um serviço na obra numa lista de obras
        /// </summary>
        /// <param name="s">Serviço de uma obra</param>
        /// <param name="idObra">Id da obra</param>
        /// <returns>True = Inseriu na lista. False = Já está na lista</returns>
        public static bool TentaInserirServicoObra(Servico s, int idObra)
        {
            bool resposta = Obras.InsereServicoObra(s,idObra);
            return resposta;  
        }

        /// <summary>
        /// Método que tenta remover um serviço na obra numa lista de obras
        /// </summary>
        /// <param name="s">Serviço de uma obra</param>
        /// <param name="idObra">Id da obra</param>
        /// <returns></returns>
        public static bool TentaRemoverServicoObra(Servico s, int idObra)
        {
            bool resposta = Obras.RemoveServicoObra(s,idObra);
            return resposta;
        }

        /// <summary>
        /// Método que tenta calcular mão de obra do trabalhador de uma obra
        /// </summary>
        /// <param name="t">Trabalhador</param>
        /// <param name="idObra">Id da obra</param>
        /// <returns></returns>
        public static double TentaCalcularMaoDeObraTrabalhador(Trabalhador t, int idObra)
        {
            double custo = Obras.CalculaMaoDeObraTrabalhador(t,idObra);
            return custo;
        }
 
    }

}