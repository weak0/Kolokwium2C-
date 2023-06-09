using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ubrania
{
    class Szafa
    {
        public string path { get; set; }
        public List<Ubrania> ubrania { get; private set; }

        public Szafa(string path)
        {
            this.path = path;
            this.ubrania = new List<Ubrania>();

        }

        public void Load ()
        {
            var loadData = File.ReadAllLines(path);

            foreach (var line in loadData)
            {
                var values = line.Split(';');
                if (values.Length >= 6 && double.TryParse(values[3], out double result))
                    {
                        var ciuszek = new Ubrania(values[0], values[1], values[2], result, values[4], values[5]);
                        ubrania.Add(ciuszek);
                    }
            }
        }

        public void Save(string savePath)
        {
            using (var writer = new StreamWriter(savePath))
            {
               writer.WriteLine("ID; producent; cena; kategoria; podkategoria;");
               foreach (var ubranie in ubrania)
                {
                   writer.WriteLine($"ID: {ubranie.id}; producent: {ubranie.producent};  cena: {ubranie.cena}; kategoria: {ubranie.kategoria}; podkategoria: {ubranie.podkategoria};");
                }
            }

        }
        public void Save(List<Ubrania> obj, string savePath)
        {
            using (var writer = new StreamWriter(savePath))
            {
                writer.WriteLine(" cena; podkategoria;");
                foreach (var ubranie in obj)
                {
                    writer.WriteLine($"Podkategoria: {ubranie.podkategoria}; producent: {ubranie.cena};");
                }
            }

        }

        public void Show<any>(IEnumerable<any> data)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        public  void Show(Ubrania line)
        {
            Console.WriteLine(line);
        }

    }
}
