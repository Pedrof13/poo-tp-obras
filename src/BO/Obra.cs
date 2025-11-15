/*
* <file>Obra.cs</file>
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
    /// Classe que representa uma obra de uma construção civil
    /// </summary>
    public class Obra
    {
        #region Atributos

        int id;
        string nome;
        DateTime dataInicio;
        DateTime dataFim;
        Morada morada;

        #endregion

        #region Metodos

        #region Construtores

        /// <summary>
        /// Cria uma obra sem valores definidos
        /// </summary>
        public Obra()
        {
            id = -1;
            nome = String.Empty;
            dataInicio = DateTime.MinValue; //01/01/0001 00:00:00
            dataFim = DateTime.MaxValue; //31/12/9999 23:59:59.9999999
            morada = new Morada();
        }

        /// <summary>
        /// Cria uma obra com valores definidos pelos parâmetros
        /// </summary>
        /// <param name="i">identificador único</param>
        /// <param name="n">nome da obra</param>
        /// <param name="inicio">data de início</param>
        /// <param name="fim">data de fim prevista</param>
        /// <param name="m">morada da obra</param>
        public Obra(int i, string n, DateTime inicio, DateTime fim, Morada m)
        {
            id = i;
            nome = n;
            dataInicio = inicio;
            dataFim = fim;
            morada = m;
        }

        #endregion

        #region Propriedades

        public int Id
        {
            get { return id; }
            set { if (value > 0) id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DateTime DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        public DateTime DataFim
        {
            get { return dataFim; }
            set { dataFim = value; }
        }

        public Morada Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        #endregion

        #region OutrosMetodos
        #endregion

        #endregion
    }

}