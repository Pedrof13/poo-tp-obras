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
    public class Servico : IComparable
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

        #region Overrides

        
        public override bool Equals(object obj)
        {
            if(obj is Servico) // Verifica se o objeto é um Servico
            {
                Servico aux;
                aux = obj as Servico; //Converte o objeto
                return (aux.Id == this.Id);

            }
            else return false;
        }
        
        
        /// <summary>
        /// Operador para comprar se os serviços são iguais pelos ids
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator==(Servico s1, Servico s2)
        {
            if(s1.Id == s2.Id) return true;
            return false;
        }

        /// <summary>
        /// Operador para comprar se os serviços são diferentes pelos ids
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator!=(Servico s1, Servico s2)
        {
            if(s1.Id != s2.Id) return true;
            return false;
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