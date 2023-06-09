using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ubrania
{
    class Ubrania
    {
         public string id { get; set; }
         public string kod { get; set; }
         public string producent { get; set; }
         public double cena { get; set; }
         public string kategoria { get; set; }
         public string podkategoria { get; set; }

        public Ubrania(string id, string kod, string producent, double cena, string kategoria, string podkategoria)
        {
            this.id = id;
            this.kod = kod;
            this.producent = producent;
            this.cena = cena;
            this.kategoria = kategoria;
            this.podkategoria = podkategoria;
        }

        public Ubrania()
        {
        }

        public override string ToString()
        {
            return $"ID: {id} producent: {producent}  cena: {cena} kategoria: {kategoria} podkategoria: {podkategoria} ";
        }
    }
}
