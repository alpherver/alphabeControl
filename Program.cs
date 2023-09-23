using System;
using System.Linq;
namespace WhileEngAlfabe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] uCaseTr = { 'Ç', 'Ğ', 'Ö', 'Ü', 'İ', 'Ş' };
            char[] lCaseTr = { 'ç', 'ğ', 'ö', 'ü', 'ş' };

            int kacAdet = 'Z' - 'A' + 1;

            char[] AZ = Enumerable.Range('A', kacAdet).Select(x => (char)x).ToArray();

            kacAdet = 'z' - 'a' + 1;
            char[] az = Enumerable.Range('a', kacAdet).Select(x => (char)x).ToArray();
            Console.WriteLine($"Karakter('A', 'Z') metodu ile: {Karakter('A', 'Z')}");
            Console.WriteLine($"Karakter('A', 'Z') metodu ile: {Karakter()}");
            Console.Write("Karakter('a', 'z') metodu ile: ");
            Console.WriteLine(Karakter('a', 'z'));


            Console.Write("Karakter (AZ[] dizisi) metodu ile:");
            Console.WriteLine(Karakter(AZ));
            Console.WriteLine($"Karakter(az[] dizisi) metodu ile : {Karakter(az)}");
            Console.Write("Karakter(uCaseTr[] dizisi) metodu ile: ");
            Console.WriteLine(Karakter(uCaseTr));
            Console.WriteLine($"Karakter(lCaseTr[] dizisi) metodu ile : {Karakter(az)}");
            Console.WriteLine(Karakter(lCaseTr));
            Console.Write("Karakter (uCaseTr[] dizisi, AZ[] dizisi) metodu ile:");
            Console.WriteLine(Karakter(uCaseTr, AZ));
            Console.WriteLine("Karakter (lCaseTr[] dizisi, az []dizisi) metodu ile:");
            Console.WriteLine(Karakter(lCaseTr, az));
            Array.Resize(ref AZ, AZ.Length + uCaseTr.Length);

            AZ[AZ.Length - 6] = 'Ç';
            AZ[AZ.Length - 5] = 'Ğ';
            AZ[AZ.Length - 4] = 'Ö';
            AZ[AZ.Length - 3] = 'Ü';
            AZ[AZ.Length - 2] = 'İ';
            AZ[AZ.Length - 1] = 'Ş';


            Console.WriteLine($"{Karakter(AZ)}");
            Console.WriteLine($"{Karakter(az)}");

            char j = 'a';
            char k = '0';

            for (char i = 'A'; i <= 'A'; i++)
            {
                Console.WriteLine($"{(int)i}.Karakter Büyük Harf: {i}");
                Console.WriteLine($"{(int)j}.Karakter Küçük Harf: {j}");
                j++;



                if (k <= '9')
                {
                    Console.WriteLine($"{(int)k}.Karakter Rakam: {k}");
                    k++;
                }
            }

            Console.ReadKey();

        }     

        static string Karakter(char basla = 'A' ,  char bitir = 'Z')
        {
            string[] keys = new string[bitir-basla +1];
            char i = basla;
            while (i<= bitir)
            {
                keys[i - basla] = i.ToString();
                i++;
            }
            return string.Join(string.Empty, keys);
        }



            static string Karakter(char[] dizi, char[] diziDil = default) 
            {
                string[] keys = new string[dizi.Length];
                for (int i = 0; i < dizi.Length; i++)
                {
                    keys[i] = dizi[i].ToString();
                }

                if(diziDil != default)
                {
                    Array.Resize(ref keys, diziDil.Length + dizi.Length);
                    for (int j = 0; j < diziDil.Length; j++)
                    {
                        keys[j + dizi.Length] = diziDil[j].ToString();
                    }
                }
                Array.Sort(keys);
                return string.Join(string.Empty, keys);
            }
        }
    }

