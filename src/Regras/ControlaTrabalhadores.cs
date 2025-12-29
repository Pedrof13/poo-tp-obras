/*
* <file>ControlaTrabalhadores.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>28-12-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

using BO;
using Dados;
using TrataProblemas;

namespace Regras
{
    /// <summary>
    /// Classe para controlar trabalhadores
    /// </summary>
    public class ControlaTrabalhadores
    {

        /// <summary>
        /// Método para tentar inserir Trabalhador numa lista
        /// </summary>
        /// <param name="t">Trabalhador</param>
        /// <returns>True = Inseriu na lista. False = Já está na lista</returns>
        public static bool TentaInserirTrabalhador(Trabalhador t)
        {
            bool resposta = Trabalhadores.InsereTrabalhador(t);
            return resposta;
        } 

        /// <summary>
        /// Método para tentar remover Trabalhador numa lista
        /// </summary>
        /// <param name="t">Trabalhador</param>
        /// <returns>True = Foi removido. False = Não está na lista</returns>
        public static bool TentaRemoverTrabalhador(Trabalhador t)
        {
            bool resposta = Trabalhadores.RemoveTrabalhador(t);
            return resposta;
        }

        /// <summary>
        /// Método para contar o número de trablhadores que tem na lista
        /// </summary>
        /// <returns>Número de trabalhadores na lista</returns>
        public static int TentaContarTrabalhadores()
        {
            int resposta = Trabalhadores.QuantosTrabalhadores();
            return resposta;
        }

        /// <summary>
        /// Método que tenta gravar um ficheiro binário
        /// </summary>
        /// <param name="nomeFicheiro">Nome do ficheiro</param>
        /// <returns>True = Gravou. False = Ocorreu um erro</returns>
        public static bool TentaGravarBin(string nomeFicheiro)
        {
            bool resposta = false;
            try
            {
                resposta = Trabalhadores.GravarTrabalhadoresBin(nomeFicheiro);
            }
            catch (FicheiroBinarioException ex)
            {
                throw new FicheiroBinarioException("Não conseguiu gravar", ex);
            }
            return resposta;
        }
        
        /// <summary>
        /// Método que tenta ler um ficheiro binário
        /// </summary>
        /// <param name="nomeFicheiro">Nome do ficheiro</param>
        /// <returns>True = Leu. False = Ocorreu um erro</returns>
        public static bool TentaLerBin(string nomeFicheiro)
        {
            bool resposta = false;
            try
            {
                resposta = Trabalhadores.LerTrabalhadoresBin(nomeFicheiro);
            }
            catch(FicheiroBinarioException ex)
            {
                throw new FicheiroBinarioException("Não conseguiu ler", ex);
            }
            return resposta;
        }
    }
}