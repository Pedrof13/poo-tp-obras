/*
* <file>Obras.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>06-01-2026</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

using BO;

namespace Dados
{
    public class Obras
    {
        #region Atributos

        static List<ObraToda> obras;

        #endregion

        #region Metodos

        #region Construtores

        /// <summary>
        /// Construtor sem parâmetros
        /// </summary>
        static Obras()
        {
            obras = new List<ObraToda>();
        }

        #endregion

        #region Propriedades
        #endregion

        #region OutrosMetodos

        /// <summary>
        /// Método para inserir uma obra na lista
        /// </summary>
        /// <param name="o">Obra com serviços</param>
        /// <returns>True = Inserido. False = Está na lista ou é inválido</returns>
        public static bool InsereObra(ObraToda o)
        {
            if(obras.Contains(o) || o.Id <= 0) return false;
            obras.Add(o);
            return true;
        }

        /// <summary>
        /// Método para remover uma obra na lista
        /// </summary>
        /// <param name="o"></param>
        /// <returns>True = Foi removido. False = Não está na lista ou é inválido</returns>
        public static bool RemoveObra(ObraToda o)
        {
            if(!obras.Contains(o) || o.Id <= 0) return false;
            obras.Remove(o);
            return true;
        }

        /// <summary>
        /// Método que insere um serviço à obra
        /// </summary>
        /// <param name="s">Serviço da obra</param>
        /// <param name="idObra">Id da obra</param>
        /// <returns></returns>
        public static bool InsereServicoObra(Servico s, int idObra)
        {
            if(idObra <= 0) return false;

            foreach(ObraToda o in obras)
            {
                if (o.Id == idObra)
                {
                    bool resposta = o.Servicos.InsereServico(s);
                    return resposta;
                }
            }
            return false;
        }

        /// <summary>
        /// Método que remove um serviço à obra
        /// </summary>
        /// <param name="s">Serviço da obra</param>
        /// <param name="idObra">Id da obra</param>
        /// <returns></returns>
        public static bool RemoveServicoObra(Servico s, int idObra)
        {
            if(idObra <= 0) return false;

            foreach (ObraToda o in obras)
            {
                if(o.Id == idObra)
                {
                    bool resposta = o.Servicos.RemoveServico(s);
                    return resposta;
                }
            }
            return false;
        }

        /// <summary>
        /// Método que calcula a mão de obra de um trabalhador de uma certa obra
        /// </summary>
        /// <param name="t">Trabalhador</param>
        /// <param name="idObra">Id da obra</param>
        /// <returns></returns>
        public static double CalculaMaoDeObraTrabalhador(Trabalhador t, int idObra)
        {
            if(idObra <= 0) return 0.0;

            foreach (ObraToda o in obras)
            {
                if(o.Id == idObra)
                {
                    double custo = o.Servicos.CalculaMaoDeObraTrabalhador(t);
                    return custo;
                    
                }
            }

            return 0.0;
        }

        #endregion

        #endregion
    }

}


/*
class Obras
{
    static List<ObraToda> obras;

    public bool InsereServicoObra(Servico s, int idObra)
    {
        //tedstes
        foreach(ObraToda o in obras)
        {
            if (o.Id == idObra)
            {
                o. nsereServico(s);
                
            }
        }
        obras.add
    }

}
*/