/*
* <file>ControlaTrabalhadores.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>28-12-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

using System;
using BO;
using Dados;

namespace Regras
{
    /// <summary>
    /// Classe para controlar trabalhadores
    /// </summary>
    class ControlaTrabalhadores
    {

        #region Metodos

        /// <summary>
        /// Método para tentar inserir Trabalhador numa lista
        /// </summary>
        /// <param name="t">Trabalhador</param>
        /// <returns></returns>
        public static bool TentaInserirTrabalhador(Trabalhador t)
        {
            bool resposta = Trabalhadores.InsereTrabalhador(t);
            return resposta;
        } 

        /// <summary>
        /// Método para tentar remover Trabalhador numa lista
        /// </summary>
        /// <param name="t">Trabalhador</param>
        /// <returns></returns>
        public static bool TentaRemoverTrabalhador(Trabalhador t)
        {
            bool resposta = Trabalhadores.RemoveTrabalhador(t);
            return resposta;
        }
        #endregion
    }

}