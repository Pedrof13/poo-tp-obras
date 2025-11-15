/*
* <file>Morada.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>14-11-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

using System;

namespace BO
{
    /// <summary>
    /// Classe que representa uma localidade de uma obra
    /// </summary>
    public class Morada
    {
        #region Atributos

        string codigoPostal;
        string localidade;

        #endregion

        #region Metodos

        #region Construtores

        /// <summary>
        /// Cria uma morada sem valores definidos
        /// </summary>
        public Morada()
        {
            codigoPostal = String.Empty;
            localidade = "SEM LOCALIDADE";
        }

        /// <summary>
        /// Cria uma morada com os valores definidos pelos parâmetros
        /// </summary>
        /// <param name="codigo">codigo postal</param>
        /// <param name="local">localidade</param>
        public Morada(string codigo, string local)
        {
            codigoPostal = codigo;
            localidade = local;
        }
        #endregion

        #region Propriedades

        public string CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value; }
        }

        public string Localidade
        {
            get { return localidade.ToUpper(); }
            set { localidade = value; }
        }

        #endregion

        #region OutrosMetodos
        #endregion

        #endregion
    }

}