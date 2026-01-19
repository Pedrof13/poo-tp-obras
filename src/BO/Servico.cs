/*
* <file>Servico.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>14-11-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

namespace BO
{
    /// <summary>
    /// Class que representa um servico de uma obra
    /// </summary>
    public class Servico : IComparable
    {
        #region Atributos
        
        int id;
        string descricao;
        int horas;
        string estado;
        Trabalhador responsavel;

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
            horas = 0;
            estado = String.Empty;
            responsavel = new Trabalhador();    
        }

        /// <summary>
        /// Cria um serviço de uma obra com valores
        /// </summary>
        /// <param name="i">Id do serviço</param>
        /// <param name="d">Descrição do serviço</param>
        /// <param name="h">Tempo em horas para o serviço</param>
        /// <param name="e">Estado do serviço</param>
        /// <param name="r">Trabalhador responsável</param>
        public Servico(int i, string d, int h ,string e, Trabalhador r)
        {
            id = i;
            descricao = d;
            horas = h;
            estado = e;
            responsavel = r;
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

        public int Horas
        {
            get { return horas; }
            set { if(value > 0) horas = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Trabalhador Responsavel
        {
            get { return responsavel; }
            set { responsavel = value; }
        }

        #endregion

        #region OutrosMetodos

        /// <summary>
        /// Função para ordenar Servicos por id
        /// Para usar apenas Sort()
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(object obj)
        {
            if(!(obj is Servico))
            {
                throw new ArgumentException("Impossível comparar com Servico, objeto do tipo inválido!");
            }
            Servico aux;
            aux = obj as Servico;
            return (this.Id.CompareTo(aux.Id));
        }

        #endregion

        #endregion
    }

}