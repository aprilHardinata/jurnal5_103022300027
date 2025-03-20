// See https://aka.ms/new-console-template for more information

class SimpleDatabase<T>
{
    private List<T> storedData;
    private List<DateTime> inputsaDate;

    public SimpleDatabase()
    {
        storedData = new List<T>();
        inputsaDate = new List<DateTime>();
    }

    public void addNewData(T data)
    {
        storedData.Add(data);
        inputsaDate.Add(DateTime.Now);
    }

    public List<T> printAllData()
    {

        int i = 1;

        foreach (T data in storedData)
        {
            Console.WriteLine($"Data {i} berisi: {data}, yang disimpan pada waktu UTC:{DateTime.Now}");
            i++;
        }

        return storedData;
    }
}

class PemprosesanData
{
    public void DapatkanNilaiTerbesar <T>(T nilai1, T nilai2, T nilai3)
    {
        dynamic value_nilai1 = nilai1;
        dynamic value_nilai2 = nilai2;
        dynamic value_nilai3 = nilai3;
        T temp;

        if (value_nilai1 > value_nilai2 && value_nilai1 > value_nilai3)
        {
            temp = value_nilai1;
        }
        else if (value_nilai2 > nilai1 && value_nilai2 > value_nilai3)
        {
            temp = value_nilai2;
        }
        else
        {
            temp = value_nilai3;
        }

        System.Console.WriteLine(temp);
    }
}

class program
{
    static void Main()
    {

        PemprosesanData nilaiTerbesar = new PemprosesanData();

        nilaiTerbesar.DapatkanNilaiTerbesar<int>(12,34,56);
        SimpleDatabase<int> databaseSedehana = new SimpleDatabase<int>();

        databaseSedehana.addNewData(12);
        databaseSedehana.addNewData(34);
        databaseSedehana.addNewData(56);

        databaseSedehana.printAllData();
    }
}
