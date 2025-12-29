/*
* <file>ControlaServicos.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>18-12-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

using Dados;
using BO;

namespace Regras
{
    /// <summary>
    /// Classe para controlar Serviços
    /// </summary>
    public class ControlaServicos
    {

        /// <summary>
        /// Método que tenta inserir um serviço na lista
        /// </summary>
        /// <param name="s">Serviço</param>
        /// <param name="obraCompleta">Serviços</param>
        /// <returns>True = Inseriu na lista. False = Já está na lista</returns>
        public static bool TentaInserirServico(Servico s, Servicos obraCompleta)
        {
            bool resposta = obraCompleta.InsereServico(s);
            return resposta;
        }

        /// <summary>
        /// Método que tenta verificar se o serviço está na lista
        /// </summary>
        /// <param name="id">Id do serviço</param>
        /// <param name="obraCompleta">Obra com a lista de serviços</param>
        /// <returns>True = Existe. False = Não existe</returns>
        public static bool TentaVerificarServico(int id, Servicos obraCompleta)
        {
            bool resposta = obraCompleta.ExisteServico(id);
            return resposta;

        }

        /// <summary>
        /// Método que tenta remover um serviço na lista
        /// </summary>
        /// <param name="s">Serviço</param>
        /// <param name="obraCompleta">Serviços</param>
        /// <returns>True = Foi removido. False = Não está na lista</returns>
        public static bool TentaRemoverServico(Servico s, Servicos obraCompleta)
        {
            bool resposta = obraCompleta.RemoveServico(s);
            return resposta;
        }

        /// <summary>
        /// Método que tenta calcular mão de obra de um trabalhador
        /// </summary>
        /// <param name="t">Trabalhador</param>
        /// <param name="obraCompleta">Serviços</param>
        /// <returns>Custo da mão de obra</returns>
        public static double TentaCalcularMaoDeObra(Trabalhador t, Servicos obraCompleta)
        {
            double custo = obraCompleta.CalculaMaoDeObraTrabalhador(t);
            return custo;
        }

    }
}