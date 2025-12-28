/*
* <file>Trabalhadores.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>28-12-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

using System;
using BO;

namespace Dados
{
    /// <summary>
    /// Classe que representa um conjunto de trabalhadores
    /// </summary>
    public class Trabalhadores
    {
        #region Atributos

        static List<Trabalhador> trabalhadores;

        #endregion

        #region Metodos

        #region Construtores

        static Trabalhadores()
        {
            trabalhadores = new List<Trabalhador>();
        }
        #endregion

        #region Propriedades
        #endregion

        #region OutrosMetodos

        /// <summary>
        /// Método para inserir um trabalhador
        /// </summary>
        /// <param name="t">Trabalhador</param>
        /// <returns>True = Inserido ; False = Está na lista ou é inválido</returns>
        public static bool InsereTrabalhador(Trabalhador t)
        {
            if(trabalhadores.Contains(t) || t.Numero <= 0) return false;
            trabalhadores.Add(t);
            return true;
        }

        /// <summary>
        /// Método para remover um trabalhador
        /// </summary>
        /// <param name="t">Trabalhador</param>
        /// <returns>True = Removido ; False = Não está na lista ou é inválido</returns>
        public static bool RemoveTrabalhador(Trabalhador t)
        {
            if(!trabalhadores.Contains(t) || t.Numero <= 0) return false;
            trabalhadores.Remove(t);
            return true;
        }



        #endregion

        #endregion
    }

}