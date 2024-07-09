using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Recursive - Özyinemeli
            // 4*3 = 3*3*3*3

            int result =1;
            for (int i = 0; i < 5; i++)
            {
                result = result * 3;
                Console.WriteLine(result);
            }

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            // Extension Metotlar
            String ifade = "Halil Özcan";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int [] dizi = {5,8,15,16,1,20};
            dizi.DiziSort();
            dizi.EkranaYazdir();

            Console.WriteLine(ifade.GetFirstCharachter());


            }
    }
    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if(us<2){
                return sayi;
            }
            return Expo(sayi, us-1)* sayi;
        }
        //Expo(3,4);
        //Expo(3,3) * 3;
        //Expo(3,2) * 3 * 3;
        //Expo(3,1) * 3 * 3 * 3;
        // 3*3*3*3* = 3^4;

    }

    public static class Extension
    {
        public static bool CheckSpaces( this string param) // this = extension Metot;
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string [] dizi = param.Split(" ");
            return string.Join("*", dizi);
        }
        public static String MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static String MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] DiziSort(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }
        public static string GetFirstCharachter(this string param)
        {
            return param.Substring(0,1);
        }
    }

    
}