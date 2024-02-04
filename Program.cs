namespace DFSExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           class Graf
        {
            private int dugumSayisi;
            private List<int>[] komsulukListesi;

            public Graf(int dugumSayisi)
            {
                this.dugumSayisi = dugumSayisi;
                komsulukListesi = new List<int>[dugumSayisi];
                for (int i = 0; i < dugumSayisi; i++)
                {
                    komsulukListesi[i] = new List<int>();
                }
            }

            public void KomsuEkle(int dugum, int komsu)
            {
                komsulukListesi[dugum].Add(komsu);
            }

            public void DFS(int baslangicDugumu)
            {
                bool[] ziyaretEdildi = new bool[dugumSayisi];
                DFSUtil(baslangicDugumu, ziyaretEdildi);
            }

            private void DFSUtil(int dugum, bool[] ziyaretEdildi)
            {
                ziyaretEdildi[dugum] = true;
                Console.Write(dugum + " ");

                foreach (int komsu in komsulukListesi[dugum])
                {
                    if (!ziyaretEdildi[komsu])
                    {
                        DFSUtil(komsu, ziyaretEdildi);
                    }
                }
            }
        }

        class Program
        {
            static void Main()
            {
                Graf graf = new Graf(7);
                graf.KomsuEkle(0, 1);
                graf.KomsuEkle(0, 2);
                graf.KomsuEkle(1, 3);
                graf.KomsuEkle(1, 4);
                graf.KomsuEkle(2, 5);
                graf.KomsuEkle(2, 6);

                Console.WriteLine("Derinlik Öncelikli Arama (DFS) Sonucu:");
                graf.DFS(0);
            }
        }
    }
    }
}