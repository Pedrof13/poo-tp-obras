/*
* <file>Servicos.cs</file>
* <author>Pedro Sousa (a31514@alunos.ipca.pt)</author>
* <sumary></summary>
* <version>1.0</version>
* <date>18-12-2025</date>
* <copyright>Copyright (c) 2025. All rights reserved.</copyright>
*/

using System;
using BO;

namespace Dados
{
    /// <summary>
    /// Classe que representa uma obra com muitos serviços
    /// </summary>
    public class Servicos : Obra
    {
        #region Atributos

        List<Servico> servicos;
        
        #endregion

        #region Metodos

        #region Construtores

        /// <summary>
        /// Construtor sem parâmetros
        /// </summary>
        public Servicos()
        {
            servicos = new List<Servico>();
        }
        #endregion

        #region OutrosMetodos

        /// <summary>
        /// Insere um serviço na lista
        /// </summary>
        /// <param name="s">Serviço</param>
        /// <returns>True = Inseriu. False = Já está na lista ou é inválido</returns>
        public bool InsereServico(Servico s)
        {
            if(servicos.Contains(s) || s.Id <= 0) return false;//Verifica se existe na lista ou se o id é válido
            servicos.Add(s);//Adiciona à lista
            servicos.Sort();//Ordena por id
            return true;
        }

        /// <summary>
        /// Verifica se o serviço está na lista
        /// </summary>
        /// <param name="id">Id do serviço</param>
        /// <returns>True = Encontrou. False = Não está na lista</returns>
        public bool ExisteServico(int id)
        {
            foreach(Servico s in servicos)//Percorre a lista
            {
                if(s.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Remove um serviço na lista
        /// </summary>
        /// <param name="s">Serviço</param>
        /// <returns>True = Foi removido. False = Não está na lista ou é inválido</returns>
        public bool RemoveServico(Servico s)
        {
            if(!servicos.Contains(s) || s.Id <= 0) return false;
            servicos.Remove(s);
            return true;
        }

        /// <summary>
        /// Calcula a mão de obra do trablhador
        /// </summary>
        /// <param name="t">Trabalhador</param>
        /// <returns>Custo da mão de obra</returns>
        public double CalculaMaoDeObraTrabalhador(Trabalhador t)
        {
            int totalHoras = 0;

            foreach(Servico s in servicos)//Percorre a lista
            {
               if(s.Responsavel == t)//Verifica se são iguais (operator)
                {
                    totalHoras = totalHoras + s.Horas;
                }
            }

            double custo = t.CustoPorHora * totalHoras;

            return custo;
        }

        #endregion

        #endregion
    }
}