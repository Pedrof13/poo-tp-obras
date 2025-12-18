/*
* <file>ControlaServicos.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>18-12-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

using System;
using Dados;
using BO;

namespace Regras
{
    public class ControlaServicos
    {
        #region Atributos
        #endregion

        #region Metodos

        #region Construtores
        #endregion

        #region Propriedades
        #endregion

        #region OutrosMetodos

        public static bool TentaInserirServico(Servico s)
        {
            bool resposta = Servicos.InsereServico(s);
            return resposta;
        }

        #endregion

        #endregion
    }

}