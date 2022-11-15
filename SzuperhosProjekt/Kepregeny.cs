using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public static class Kepregeny
    {
        private static List<ISzuperhos> szuperhosLista = new List<ISzuperhos>();
        public static void Main(string[] args)
        {
            try
            {
                Szereplok("szuperhos.txt");
                Szuperhosok();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("A forrásfájl nem található");
            }
        }

        private static void Szuperhosok()
        {
            foreach (ISzuperhos szuperhos in szuperhosLista)
            {
                Console.WriteLine(szuperhos);
            }
        }

        private static void Szereplok(string fajlNev)
        {
            using (var reader = new StreamReader(fajlNev))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(' ');
                    string szuperhosTipus = line[0];
                    int hanyszorKeszitKutyut = int.Parse(line[1]);
                    if (szuperhosTipus == "Vasember")
                    {
                        var vasember = new Vasember();
                        for (int i = 0; i < hanyszorKeszitKutyut; i++)
                        {
                            vasember.KutyutKeszit();
                        }
                        szuperhosLista.Add(vasember);
                    }
                    else if (szuperhosTipus == "Batman")
                    {
                        var batman = new Batman();
                        for (int i = 0; i < hanyszorKeszitKutyut; i++)
                        {
                            batman.KutyutKeszit();
                        }
                        szuperhosLista.Add(batman);
                    }
                }
            }
        }
    }
}
