/*
* <file>Trabalhador.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>18-12-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

using System;

namespace BO
{
    public class Trabalhador
    {
        #region Atributos

        int numero;
        string nome;
        string funcao;

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
        }

        /// <summary>
        /// Cria um trabalhador com parâmetros
        /// </summary>
        /// <param name="num">número do trabalhador</param>
        /// <param name="no">nome do trabalhador</param>
        /// <param name="f">função do trabalhador</param>
        public Trabalhador(int num, string no, string f)
        {
            numero = num;
            nome = no;
            funcao = f;
        }

        #endregion

        #region Propriedades

        public int Numero
        {
            get { return numero; }
            set { if(value > 0) numero = value; }    
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }    
        }

        public string Funcao
        {
            get { return funcao; }
            set { funcao = value; }
        }

        #endregion

        #region OutrosMetodos
        #endregion

        #endregion
    }

}