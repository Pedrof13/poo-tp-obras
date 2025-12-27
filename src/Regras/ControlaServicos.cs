/*
* <file>ControlaServicos.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>18-12-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

using System;
using Dados;
using BO;

namespace Regras
{
    public class ControlaServicos
    {
        #region Atributos
        #endregion

        #region Metodos

        #region Construtores
        #endregion

        #region Propriedades
        #endregion

        #region OutrosMetodos

        /// <summary>
        /// Função que tenta inserir um serviço à lista
        /// </summary>
        /// <param name="s">serviço</param>
        /// <returns>True = Inseriu na lista. False = Já está na lista</returns>
        public static bool TentaInserirServico(Servico s)
        {
            bool resposta = Servicos.InsereServico(s);
            return resposta;
        }

        /// <summary>
        /// Função que tenta encontrar o serviço na lista pelo id
        /// </summary>
        /// <param name="id">id do serviço</param>
        /// <returns></returns>
        public static Servico? TentaEncontrarServico(int id)
        {
            Servico? s = Servicos.QuemServico(id);
            return s;

        }

        /// <summary>
        /// Função que tenta remover um serviço à lista
        /// </summary>
        /// <param name="s">serviço</param>
        /// <returns>True = Foi removido. False = Não está na lista</returns>
        public static bool TentaRemoverServico(Servico s)
        {
            bool resposta = Servicos.RemoveServico(s);
            return resposta;
        }

        #endregion

        #endregion
    }

}