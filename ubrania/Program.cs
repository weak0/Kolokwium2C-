using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ubrania
{
    class Program
    {
        delegate void GroupByDelegate(string path);

        static void Main(string[] args)
        {
            var szafa = new Szafa(@"C:\Users\macie\OneDrive\Desktop\ubrania.csv");

            GroupByDelegate instanceDelegate = (string path) =>
            {
                szafa.Load();
                var groupBy = szafa.ubrania.GroupBy(e => e.podkategoria)
                    .Select(g => new Ubrania { podkategoria = g.Key, cena = g.Max(e => e.cena) }).ToList();
                szafa.Save(groupBy, (@"C:\Users\macie\OneDrive\Desktop\xd.csv"));
            };

            FunkcjaJakas(instanceDelegate);

            //var podkategoria = szafa.ubrania.FirstOrDefault(e => e.id == "18059");
            //szafa.Show(podkategoria);
            //var emamodaCiuchy = szafa.ubrania.Where(e => e.producent == "EMAMODA").ToList();
            //szafa.ubrania = emamodaCiuchy;
            //szafa.Save(@"C:\Users\macie\OneDrive\Desktop\xd.txt");
            //var groupBy = szafa.ubrania.GroupBy(e => e.podkategoria)
            //    .Select(g => new Ubrania {podkategoria = g.Key, cena = g.Max(e => e.cena)}).ToList();
            //szafa.Show(groupBy);

            Console.ReadLine();
         void FunkcjaJakas(GroupByDelegate xd)
        {
            Console.WriteLine("z funkcj;");
            xd(@"C:\Users\macie\OneDrive\Desktop\xd.csv");
            Console.WriteLine("zrobione");

        }
        }
    }
}
