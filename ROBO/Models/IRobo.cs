using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROBO.Models
{
    public interface IRobo
    {
        int Rotacionar(Membro membro, string vetor);
        Braco Tensionar(Braco braco, string vetor);
        Cabeca Inclinar(Cabeca cabeca, string vetor);

        bool ValidaRotacionar(Cabeca cabeca, string vetor);
        bool ValidaRotacionar(Braco braco, string vetor);
        bool ValidaTensionar(Braco braco, string vetor);
        bool ValidaInclinar(Cabeca cabeca, string vetor);
        bool ValidaVetor(string vetor);

    }
}
