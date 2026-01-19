/*
* <file>Obra.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>14-11-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

namespace BO
{
    /// <summary>
    /// Classe que representa uma obra de construção civil
    /// </summary>
    public class Obra
    {
        #region Atributos

        int id;
        string nome;
        Morada morada;
        DateTime dataInicio;
        DateTime dataFim;

        #endregion

        #region Metodos

        #region Construtores

        /// <summary>
        /// Cria uma obra sem valores definidos
        /// </summary>
        public Obra()
        {
            id =-1;
            nome = String.Empty;
            morada = new Morada();
            dataInicio = DateTime.MinValue; //01/01/0001 00:00:00
            dataFim = DateTime.MaxValue; //31/12/9999 23:59:59.9999999
        }

        /// <summary>
        /// Cria uma obra com valores definidos pelos parâmetros
        /// </summary>
        /// <param name="i">Identificador único da obra</param>
        /// <param name="n">Nome da obra</param>
        /// <param name="m">Morada da obra</param>
        /// <param name="inicio">Data de inicio</param>
        /// <param name="fim">Data de fim prevista</param>
        public Obra(int i, string n, Morada m, DateTime inicio, DateTime fim)
        {
            id = i;
            nome = n;
            morada = m;
            dataInicio = inicio;
            dataFim = fim;
        }

        #endregion

        #region Propriedades

        public int Id
        {
            get { return id; }
            set { if(value > 0) id = value; }    
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Morada Morada
        {
            get { return morada; }
            set { morada = value; }
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

        #endregion

        #endregion
    }
}