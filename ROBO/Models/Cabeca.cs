using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROBO.Models
{
    public class Cabeca : Membro
    {
        private readonly int _maxRotacao = 90;
        private readonly int _minRotacao = -90;

        public String Inclinacao { get; set; }

        public  int MinRotacao
        {
            get
            {
                return _minRotacao;
            }

        }

        public  int MaxRotacao
        {
            get
            {
                return _maxRotacao;
            }

        }

        /// <summary>
        /// Realiza as mudanças de inclinação da cabeça do robô
        /// </summary>
        /// <param name="vetor"></param>
        public void Inclinar(string vetor)
        {
            #region.:Vetor Positivo:.
            if (vetor == "Positivo")
            {
                if(Inclinacao == "Em Repouso")
                {
                    Inclinacao = "Para Cima";
                }
                else
                {
                    Inclinacao = "Em Repouso";
                }
            }
            #endregion
            #region.:Vetor Negativo:.
            else if (vetor =="Negativo")
            {
                if(Inclinacao == "Em Repouso")
                {
                    Inclinacao = "Para Baixo";
                }
                else
                {
                    Inclinacao = "Em Repouso";
                }
            }
            #endregion
        }

    }
}
 