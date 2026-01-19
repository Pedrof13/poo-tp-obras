/*
* <file>Trabalhador.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>18-12-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

using System.Runtime.Serialization;

namespace BO
{
    /// <summary>
    /// Classe que representa um trabalhador de um serviço
    /// </summary>
    [DataContract]
    public class Trabalhador
    {
        #region Atributos

        int numero;
        string nome;
        string funcao;
        double custoPorHora;

        #endregion

        #region Metodos

        #region Construtores

        /// <summary>
        /// Cria um trabalhador sem parâmetros
        /// </summary>
        public Trabalhador()
        {
            numero = -1;
            nome = String.Empty;
            funcao = String.Empty;
            custoPorHora = 0.0;
        }

        /// <summary>
        /// Cria um trabalhador com parâmetros
        /// </summary>
        /// <param name="num">número do trabalhador</param>
        /// <param name="no">nome do trabalhador</param>
        /// <param name="f">funcção do trabalhador</param>
        /// <param name="c">custo por hora</param>
        public Trabalhador(int num, string no, string f, double c)
        {
            numero = num;
            nome = no;
            funcao = f;
            custoPorHora = c;
        }

        #endregion

        #region Propriedades

        [DataMember]
        public int Numero
        {
            get { return numero; }
            set { if(value > 0) numero = value; }    
        }

        [DataMember]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }    
        }

        [DataMember]
        public string Funcao
        {
            get { return funcao; }
            set { funcao = value; }
        }

        [DataMember]
        public double CustoPorHora
        {
            get { return custoPorHora; }
            set { custoPorHora = value; }
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Compara se os dois trabalhadores são iguais
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if(obj is Trabalhador)//Verifica se o objeto é um Trabalhador
            {
                Trabalhador aux;
                aux = obj as Trabalhador;//Converte o objeto
                return (aux.Numero == this.Numero);
            }
            return false;
        }

        /// <summary>
        /// Operador que compara dois trablhadores pelo número.
        /// Verifica se são iguais
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator==(Trabalhador t1, Trabalhador t2)
        {
            if(t1.Numero == t2.Numero) return true;
            return false;
        }

        /// <summary>
        /// Operador que compara dois trabalhadores pelo número.
        /// Verifica se são diferentes
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator!=(Trabalhador t1, Trabalhador t2)
        {
            if(t1.Numero != t2.Numero) return true;
            return false;
        }

        public override int GetHashCode()
        {
            return Numero.GetHashCode();
        }

        #endregion

        #endregion
    }

}