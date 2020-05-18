using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticTurnirAsisten
{
    public class NagradaModel
    {
        /// <summary>
        /// Indetifikaciska oznaka za nagradu
        /// </summary>

        public int Id { get; set; }
        /// <summary>
        /// Osvojeno mjesto neke ekiupe
        /// </summary>

        public int OsvojenoMjesto { get; set; }
        /// <summary>
        /// Naziv Mjesta koje je neka ekipa osvojila
        /// </summary>

        public string NazivMjesta { get; set; }
        /// <summary>
        /// Iznos nagrade koju je neka ekipa oscojila 
        /// </summary>

        public decimal IznosNagrade { get; set; }
        /// <summary> 
        /// Postotak nagrade koju turnir zaradio od kotizacije
        /// </summary>

        public double PostotakNagrade { get; set; }

        public NagradaModel()
        {

        }
        public NagradaModel(string osvojenoMjesto, string nazivMjesta, string iznosNagrade, string postotakNagrade)
        {
            NazivMjesta = nazivMjesta;

            int potvrdiOsvojenoMjesto = 0;
            int.TryParse(osvojenoMjesto, out potvrdiOsvojenoMjesto);
            OsvojenoMjesto = potvrdiOsvojenoMjesto;

            decimal potvrdiIznosNagrade = 0;
            decimal.TryParse(iznosNagrade, out potvrdiIznosNagrade);
            IznosNagrade = potvrdiIznosNagrade;

            double potvrdiPostotakNagrade = 0;
            double.TryParse(postotakNagrade, out potvrdiPostotakNagrade);
            PostotakNagrade = potvrdiPostotakNagrade;


        }
    }
}

                
