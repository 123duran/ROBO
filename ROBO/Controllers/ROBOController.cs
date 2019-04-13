using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ROBO.Models;
using System.Reflection;
using System.Net;

namespace ROBO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ROBOController : ControllerBase
    {
        static readonly RoboRepository repositorio = new RoboRepository();



        // GET api/robo
        [HttpGet]
        public Robo Get()
        {
            Robo robo = new Robo
            {
                BracoDireito = new Braco
                {
                    Lado = "Direita",

                },
                BracoEsquerdo = new Braco
                {
                    Lado = "Esquerda",
                },

                Cabeca = new Cabeca
                {
                    Inclinacao = "Em Repouso",
                }
            };


            return robo;

        }



        // POST /RotacionarCabeca
        [HttpPost("/RotacionarCabeca")]
        public Cabeca Rotacionar(string vetor, Cabeca cabeca)
        {
            if (repositorio.ValidaRotacionar(cabeca, vetor))
            {
                cabeca.Rotacao = repositorio.Rotacionar(cabeca, vetor);
                return cabeca;
            }
            else
            {
                return cabeca;
            }
        }


        // POST /RotacionarBraco
        [HttpPost("/RotacionarBraco")]
        public Braco Rotacionar(string vetor, Braco braco)
        {
            if (repositorio.ValidaRotacionar(braco, vetor))
            {
                braco.Rotacao = repositorio.Rotacionar(braco, vetor);
                return braco;
            }
            else
            {
                return braco;
            }

        }


        // POST /TensionarBraco
        [HttpPost("/TensionarBraco")]
        public Braco Tensionar(string vetor, Braco braco)
        {
            if (repositorio.ValidaTensionar(braco, vetor))
            {
                braco = repositorio.Tensionar(braco, vetor);
                return braco;
            }
            else
            {
                return braco;
            }

        }


        // POST /InclinarCabeca
        [HttpPost("/InclinarCabeca")]
        public Cabeca Post(string vetor, Cabeca cabeca)
        {
            if (repositorio.ValidaInclinar(cabeca, vetor))
            {
                cabeca = repositorio.Inclinar(cabeca, vetor);
                return cabeca;
            }
            else
            {
                return cabeca;
            }

        }
    }



}