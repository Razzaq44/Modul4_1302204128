class program
{
    public static void Main(string[] args)
    {
        SimpleDataBase<int, DateTime> obj = new SimpleDataBase<int, DateTime>();
        obj.AddNewData(13, DateTime.Now);
        obj.AddNewData(02, DateTime.Now);
        obj.AddNewData(20, DateTime.Now);
        obj.PrintAllData();
    }
}


class SimpleDataBase<T, Date>
{
    private List<T> storedData;
    private List<Date> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<Date>();
    }

    public void AddNewData(T data, Date waktu)
    {
        storedData.Add(data);
        inputDates.Add(waktu);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu " + inputDates[i]);
        }
    }

}
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
    