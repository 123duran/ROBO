using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROBO.Models
{
    public class RoboRepository : IRobo
    {
        /// <summary>
        /// Inclina a cabeça do robô
        /// </summary>
        /// <param name="cabeca"></param>
        /// <param name="vetor"></param>
        /// <returns></returns>
        public Cabeca Inclinar(Cabeca cabeca, string vetor)
        {
            cabeca.Inclinar(vetor);
            return cabeca;
        }


        /// <summary>
        /// Rotaciona o membro do robô
        /// </summary>
        /// <param name="membro"></param>
        /// <param name="vetor"></param>
        /// <returns></returns>
        public int Rotacionar(Membro membro, string vetor)
        {
            membro.RotacionarMembro(vetor);
            return membro.Rotacao;
        }

        /// <summary>
        /// Tensiona o braço do robô
        /// </summary>
        /// <param name="braco"></param>
        /// <param name="vetor"></param>
        /// <returns></returns>
        public Braco Tensionar(Braco braco, string vetor)
        {
            #region.:Vetor Positivo
            if (vetor=="Positivo")
            {
                if (braco.Cotovelo == "Em Repouso")
                {
                    braco.Cotovelo = "Levemente Contraído";
                }
                else if (braco.Cotovelo == "Levemente Contraído")
                {
                    braco.Cotovelo = "Contraído";
                }
                else if (braco.Cotovelo == "Contraído")
                {
                    braco.Cotovelo = "Fortemente Contraído";
                }
            }
            #endregion
            #region.:Vetor Negativo
            else
            {
                if (braco.Cotovelo == "Fortemente Contraído")
                {
                    braco.Cotovelo = "Contraído";
                }
                else if (braco.Cotovelo =="Contraído")
                {
                    braco.Cotovelo = "Levemente Contraído";
                }
                else if (braco.Cotovelo == "Levemente Contraído")
                {
                    braco.Cotovelo = "Em Repouso";
                }
            }
            #endregion
            return braco;
        }
        /// <summary>
        /// Valida a inclinação da cabeça do robô
        /// </summary>
        /// <param name="cabeca"></param>
        /// <param name="vetor"></param>
        /// <returns></returns>
        public bool ValidaInclinar(Cabeca cabeca, string vetor)
        {
            if (!ValidaVetor(vetor))
            {
                return false;
            }

            if (cabeca.Inclinacao == "Em Repouso")
            {
                return true;
            }


            if (cabeca.Inclinacao == "Para Baixo")
            {
                return (!vetor.Equals("Negativo"));
            }

            if (cabeca.Inclinacao =="Para Cima")
            {
                return (!vetor.Equals("Positivo"));
            }

            return false;
        }
        /// <summary>
        /// Valida se o vetor está no padrão correto
        /// </summary>
        /// <param name="vetor"></param>
        /// <returns></returns>
        public bool ValidaVetor(string vetor)
        {
            if ((vetor == "Positivo") || (vetor =="Negativo"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Valida se podemos rotacionar a cabeça.
        /// A cabeça não pode ser rotacionada caso esteja "Para Baixo".
        /// </summary>
        /// <param name="cabeca"></param>
        /// <param name="vetor"></param>
        /// <returns></returns>
        public bool ValidaRotacionar(Cabeca cabeca, string vetor)
        {
            bool retorno;
            #region.:Validando Inclinação
            if (cabeca.Inclinacao == "Para Baixo")
            {
                retorno = false;
                return retorno;

            
            }
            #endregion

            #region.:Validando o Vetor
            if (!ValidaVetor(vetor))
            {
                retorno = false;
            }
            #endregion

            #region .:Validando Limite de Rotacao
            retorno = cabeca.ValidaLimiteRotacao(vetor, cabeca.MaxRotacao,cabeca.MinRotacao);
            #endregion
            return retorno;
        }

        /// <summary>
        /// Valida se podemos rotacionar o pulso.
        /// O pulso só pode ser rotacionado caso o cotovelo esteja "Fortemente Contraído"
        /// </summary>
        /// <param name="braco"></param>
        /// <param name="vetor"></param>
        /// <returns></returns>
        public bool ValidaRotacionar(Braco braco, string vetor)
        {
            bool retorno = false;
            if (ValidaVetor(vetor))
            {
                if ((braco.ValidaLimiteRotacao(vetor, braco.MaxRotacao, braco.MinRotacao)) && (braco.Cotovelo== "Fortemente Contraído"))
                {
                    retorno = true;
                }
            }
            else
            {
                retorno = false;
            }
            return retorno;

        }
        /// <summary>
        /// Valida se podemos tensionar o cotovelo
        /// </summary>
        /// <param name="braco"></param>
        /// <param name="vetor"></param>
        /// <returns></returns>
        public bool ValidaTensionar(Braco braco, string vetor)
        {
            if (!ValidaVetor(vetor))
            {
                return false;
            }


            if ((braco.Cotovelo.Equals("Em Repouso")) && (vetor.Equals("Negativo")))
            {
                return false;
            }
            else if ((braco.Cotovelo.Equals("Fortemente Contraído")) && (vetor.Equals("Positivo")))
            {
                return false;

            }
            else
            {
                return true;
            }
        }


    }
}
