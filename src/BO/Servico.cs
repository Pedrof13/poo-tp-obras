/*
* <file>Servico.cs</file>
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
    /// Class que representa um servico de uma obra
    /// </summary>
    public class Servico
    {
        #region Atributos
        
        int id;
        string descricao;
        string estado;

        #endregion

        #region Metodos

        #region Construtores

        /// <summary>
        /// Cria um serviço de uma obra sem valores
        /// </summary>
        public Servico()
        {
            id = -1;
            descricao = String.Empty;
            estado = String.Empty;    
        }

        /// <summary>
        /// Cria um serviço de uma obra com valores
        /// </summary>
        /// <param name="i">id do serviço</param>
        /// <param name="d">descrição do serviço</param>
        /// <param name="e">estado do serviço</param>
        public Servico(int i, string d, string e)
        {
            id = i;
            descricao = d;
            estado = e;
        }

        #endregion

        #region Propriedades

        public int Id
        {
            get { return id; }
            set { if(value > 0) id = value; }    
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }    
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        #endregion

        #region OutrosMetodos
        #endregion

        #endregion
    }

}