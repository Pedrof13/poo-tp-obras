/*
* <file>Servicos.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>18-12-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

using System;
using BO;

namespace Dados
{
    /// <summary>
    /// Classe que representa uma obra com muitos serviços
    /// </summary>
    public class Servicos : Obra
    {
        #region Atributos
        List<Servico> servicos;
        #endregion

        #region Metodos

        #region Construtores

        /// <summary>
        /// Construtor sem parâmetros
        /// </summary>
        public Servicos()
        {
            servicos = new List<Servico>();
        }
        #endregion

        #region Propriedades
        #endregion

        #region OutrosMetodos

        /// <summary>
        /// Função para inserir um serviço à lista
        /// </summary>
        /// <param name="s">serviço</param>
        /// <returns></returns>
        public bool InsereServico(Servico s)
        {
            if(servicos.Contains(s) || s.Id <= 0) return false; //Verifica se existe na lista ou se o id é válido
            servicos.Add(s); //Adiciona à lista
            return true;
        }

        /// <summary>
        /// Encontra o serviço numa lista pelo id
        /// </summary>
        /// <param name="id">id do serviço</param>
        /// <returns>Serviço</returns>
        public Servico? QuemServico(int id)
        {
            foreach (Servico s in servicos) //Percorre a lista
            {
                if( s.Id == id)
                {
                    return s;
                }
            }
            return null;
        }

        /// <summary>
        /// Remove um serviço na lista
        /// </summary>
        /// <param name="s">serviço</param>
        /// <returns>True = Foi removido. False = Não está na lista</returns>
        public bool RemoveServico(Servico s)
        {
            if(!servicos.Contains(s) || s.Id <= 0) return false;
            servicos.Remove(s);
            return true;
        }

        #endregion

        #endregion
    }

}