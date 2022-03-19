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