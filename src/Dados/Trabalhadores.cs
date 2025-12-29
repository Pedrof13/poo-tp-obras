/*
* <file>Trabalhadores.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>28-12-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

using System.Runtime.Serialization.Formatters.Binary;
using BO;
using TrataProblemas;

namespace Dados
{
    /// <summary>
    /// Classe que representa um conjunto de trabalhadores
    /// </summary>
    [Serializable]
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
        /// Inserie um trabalhador na lista
        /// </summary>
        /// <param name="t">Trabalhador</param>
        /// <returns>True = Inserido. False = Está na lista ou é inválido</returns>
        public static bool InsereTrabalhador(Trabalhador t)
        {
            if(trabalhadores.Contains(t) || t.Numero <= 0) return false;
            trabalhadores.Add(t);
            return true;
        }

        /// <summary>
        /// Remove um trabalhador na lista
        /// </summary>
        /// <param name="t">Trabalhador</param>
        /// <returns>True = Removido. False = Não está na lista ou é inválido</returns>
        public static bool RemoveTrabalhador(Trabalhador t)
        {
            if(!trabalhadores.Contains(t) || t.Numero <= 0) return false;
            trabalhadores.Remove(t);
            return true;
        }

        /// <summary>
        /// Conta o número de trabalhadores na lista
        /// </summary>
        /// <returns>Quantidade de trabalhadores</returns>
        public static int QuantosTrabalhadores()
        {
            return trabalhadores.Count;
        }

        /*
        public static bool GravaTrabalhadoresBin(string nomeFicheiro)
        {
            if(File.Exists(nomeFicheiro))
            {
                try
                {
                    Stream stream = File.Open(nomeFicheiro, FileMode.Create);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, trabalhadores);
                    stream.Close();
                    return true;
                }
                catch(IOException ex)
                {
                    throw new FicheiroBinarioException(ex + "Erro na gravação do ficheiro");
                }
                catch(Exception ex)
                {
                    throw new FicheiroBinarioException(ex + "Erro inesperado do ficheiro");
                }
            }
            return false;
        }
        */

        /*
        public static bool LeTrabalhadoresBin(string nomeFicheiro)
        {
            if(File.Exists(nomeFicheiro))
            {
                try
                {
                    Stream stream = File.Open(nomeFicheiro, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bin = new BinaryFormatter();
                    trabalhadores = (List<Trabalhador>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch(IOException ex)
                {
                    throw new FicheiroBinarioException(ex + "Erro na leitura do ficheiro");
                }
                catch(Exception ex)
                {
                    throw new FicheiroBinarioException(ex + "Erro inesperado do ficheiro");
                }
            }
            return false;
        }
        */
        
        /// <summary>
        /// Grava a lista de trabalhadores em um ficheiro binário
        /// </summary>
        /// <param name="nomeFicheiro">Nome do ficheiro</param>
        /// <returns>True = Gravou. False = Erro</returns>
        /// <exception cref="FicheiroBinarioException"></exception>
        public static bool GravarTrabalhadoresBin(string nomeFicheiro)
        {
            if(File.Exists(nomeFicheiro))
            {
                try
                {
                    FileStream fs = new FileStream(nomeFicheiro, FileMode.OpenOrCreate);
                    BinaryWriter bw = new BinaryWriter(fs);

                    bw.Write(trabalhadores.Count);

                    foreach (Trabalhador t in trabalhadores)
                    {
                        bw.Write(t.Numero);
                        bw.Write(t.Nome);
                        bw.Write(t.Funcao);
                        bw.Write(t.CustoPorHora);
                    }
                    bw.Close();
                    fs.Close();
                    return true;
                }
                catch(IOException ex) // Erro no sistema (externo)
                {
                    throw new FicheiroBinarioException("Erro na gravação do ficheiro", ex);
                }
                catch(Exception ex) //Erros no código
                {
                    throw new FicheiroBinarioException("Erro inesperado do ficheiro", ex);
                }
            }

            return false;
        }
        
        /// <summary>
        /// Lê a lista trabhadores num ficheiro binário
        /// </summary>
        /// <param name="nomeFicheiro">Nome do ficheiro</param>
        /// <returns>True = Gravou. False = Erro</returns>
        /// <exception cref="FicheiroBinarioException"></exception>
        public static bool LerTrabalhadoresBin(string nomeFicheiro)
        {
            if(File.Exists(nomeFicheiro) && (new FileInfo(nomeFicheiro).Length > 0))
            {
                try
                {
                    FileStream fs = new FileStream(nomeFicheiro, FileMode.Open);
                    BinaryReader br = new BinaryReader(fs);

                    trabalhadores.Clear();

                    int total = br.ReadInt32();

                    for(int i = 0; i < total; i++)
                    {
                        Trabalhador t = new Trabalhador(
                            br.ReadInt32(),
                            br.ReadString(),
                            br.ReadString(),
                            br.ReadDouble()
                        );
                        trabalhadores.Add(t);
                    }
                    br.Close();
                    fs.Close();
                    return true;
                }
                catch(IOException ex)
                {
                    throw new FicheiroBinarioException("Erro na leitura do ficheiro", ex);
                }
                catch(Exception ex)
                {
                    throw new FicheiroBinarioException("Erro inesperado do ficheiro", ex);
                }
            }
            return false;
        }

        #endregion

        #endregion
    }
}