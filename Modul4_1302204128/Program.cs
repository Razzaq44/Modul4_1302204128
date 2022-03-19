using System;

namespace mod4
{
    class program
    {
        public static void Main(string[] args)
        {
            Penjumlahan.JumlahTigaAngka<int>(13, 02, 20);
        }
    }


    class Penjumlahan
    {
        public static void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            dynamic tempA = angka1;
            dynamic tempB = angka2;
            dynamic tempC = angka3;

            Console.WriteLine(tempA + tempB + tempC);
        }
    }
}
    