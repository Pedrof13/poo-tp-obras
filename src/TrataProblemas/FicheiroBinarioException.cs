/*
* <file>FicheiroBinarioException.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>28-12-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

namespace TrataProblemas
{
    /// <summary>
    /// Classe que serve para erros relacionados com ficheiros binários
    /// </summary>
    [Serializable]
    public class FicheiroBinarioException : ApplicationException
    {
        public FicheiroBinarioException() : base("Impossível"){}

        public FicheiroBinarioException(string mensagem)
        {
            throw new Exception(mensagem + "Ocorreu um erro inesperado.");
        }

        public FicheiroBinarioException(Exception e)
        {
            throw new FicheiroBinarioException(e.Message + "ERRO");
        }


    }

}
