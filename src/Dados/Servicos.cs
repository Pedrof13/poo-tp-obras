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
    public class Servicos
    {
        #region Atributos
        static List<Servico> servicos;
        #endregion

        #region Metodos

        #region Construtores

        /// <summary>
        /// Construtor sem parâmetros
        /// </summary>
        static Servicos()
        {
            servicos = new List<Servico>();
        }
        #endregion

        #region Propriedades
        #endregion

        #region OutrosMetodos

        public static bool InsereServico(Servico s)
        {
            if(servicos.Contains(s)) return false;
            servicos.Add(s);
            return true;
        }

        #endregion

        #endregion
    }

}