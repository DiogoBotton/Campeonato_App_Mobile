using Campeonato_App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato_App.ViewModels
{
    class PrincipalViewModel
    {
        public List<Jogo> jogos { get; set; }

        public PrincipalViewModel()
        {
            jogos = new List<Jogo>
            {
                new Jogo
                {
                    selecaoCasa = "Holanda",
                    selecaoVisitante = "Costa Rica",
                    placarCasa = 1,
                    placarVisitante = 7,
                    data = Convert.ToDateTime("08/07/2014"),
                    estadio = "Arena Fonte Nova"
                },
                new Jogo
                {
                     selecaoCasa = "Brasil",
                     selecaoVisitante = "Alemanha",
                     placarCasa = 2,
                     placarVisitante = 0,
                     data = Convert.ToDateTime("08/07/2014"),
                     estadio = "Mineirão"
                }
            };
        }
    }
}
