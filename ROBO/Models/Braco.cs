using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROBO.Models
{
    public class Braco : Membro
    {
        private readonly int _maxRotacao = 180;
        private readonly int _minRotacao = -180;

        public String Lado { get; set; }
        public String Cotovelo { get; set; } = "Em Repouso";


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
    }
}


