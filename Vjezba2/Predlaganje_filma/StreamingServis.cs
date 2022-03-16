using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predlaganje_filma
{
    internal class StreamingServis
    {
        private List<Film> listaFilmova;

        public StreamingServis()
        {
            listaFilmova = new List<Film>()
            {
                new Film("Film 1", Zanr.Komedija, 88, false),
                new Film("Film 2", Zanr.Akcija, 95, false),
                new Film("Film 3", Zanr.Horor, 120, true),
                new Film("Film 4", Zanr.Komedija, 120, false),
                new Film("Film 5", Zanr.Akcija, 110, true),
                new Film("Film 6", Zanr.Horor, 99, false),
                new Film("Film 7", Zanr.Komedija, 75, false),
                new Film("Film 8", Zanr.Akcija, 80, false),
                new Film("Film 9", Zanr.Horor, 81, false),
                new Film("Film 10", Zanr.Komedija, 99, true)
            };

        }

        private List<Film> DohvatiFilmoveKojeNisamGledao()
        {
            List<Film> nepogledaniFilmovi = new List<Film>();
            foreach(Film film in listaFilmova)
            {
                if (!film.VecGledan)
                {
                    nepogledaniFilmovi.Add(film);
                }
            }
            return nepogledaniFilmovi;
        }

        public Film PredloziFilm()
        {
            List<Film> filmoviKojeNisamGledao = DohvatiFilmoveKojeNisamGledao();
            return filmoviKojeNisamGledao[new Random().Next(0, filmoviKojeNisamGledao.Count)];
        }
    }
}
