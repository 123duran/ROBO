using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROBO.Models
{
    public class Membro
    {
        public int Rotacao { get; set; } = 0;
       

        /// <summary>
        /// Rotaciona o membro em 45 graus no sentido do vetor
        /// </summary>
        /// <param name="vetor"></param>
        public void RotacionarMembro(string vetor)
        {
            if (vetor == "Positivo")
            {
                Rotacao = Rotacao + 45;
            }
            else
            {
                Rotacao = Rotacao - 45;
            }
        }

        public bool ValidaLimiteRotacao(string vetor , int MaxRotacao, int MinRotacao)
        {
            bool retorno;
            if (vetor == "Positivo")
            {
                retorno = Rotacao == MaxRotacao ? false : true;
            } else 
            {
                retorno = Rotacao == MinRotacao ? false : true;
            }
            return retorno;
        }

    }
}
