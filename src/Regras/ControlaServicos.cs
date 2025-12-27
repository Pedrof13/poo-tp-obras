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
        /// Método que tenta inserir um serviço na lista
        /// </summary>
        /// <param name="s">serviço</param>
        /// <param name="obraCompleta">serviços</param>
        /// <returns>True = Inseriu na lista. False = Já está na lista</returns>
        public static bool TentaInserirServico(Servico s, Servicos obraCompleta)
        {
            bool resposta = obraCompleta.InsereServico(s);
            return resposta;
        }

        /// <summary>
        /// Método que tenta encontrar na lista um serviço pelo id
        /// </summary>
        /// <param name="id">id do serviço</param>
        /// <param name="obraCompleta">serviços</param>
        /// <returns></returns>
        public static Servico? TentaEncontrarServico(int id, Servicos obraCompleta)
        {
            Servico? s = obraCompleta.QuemServico(id);
            return s;

        }

        /// <summary>
        /// Método que tenta remover um serviço na lista
        /// </summary>
        /// <param name="s">serviço</param>
        /// <param name="obraCompleta">serviços</param>
        /// <returns>True = Foi removido. False = Não está na lista</returns>
        public static bool TentaRemoverServico(Servico s, Servicos obraCompleta)
        {
            bool resposta = obraCompleta.RemoveServico(s);
            return resposta;
        }

        #endregion

        #endregion
    }

}