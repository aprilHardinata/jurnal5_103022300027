// See https://aka.ms/new-console-template for more information
class SimpleDatabase <T>
{
    private List<T> storedData;
    private List<DateTime> inputsaDate;

    public SimpleDatabase()
    {
        storedData = new List<T>();
        inputsaDate = new List<DateTime>();
    }

    public void addNewData(T data) {
        storedData.Add(data);
        inputsaDate.Add(DateTime.Now);
    }

    public List<T> printAllData() {

        int i = 1;

        foreach (T data in storedData ) {
            Console.WriteLine($"Data {i} berisi: {data}, yang disimpan pada waktu UTC:{DateTime.Now}");
            i++;
        }
       
        return storedData; 
    }
}

class program
{
    static void Main()
    {
        SimpleDatabase<int> databaseSedehana = new SimpleDatabase<int>();

        databaseSedehana.addNewData(12);
        databaseSedehana.addNewData(34);
        databaseSedehana.addNewData(56);

        databaseSedehana.printAllData();
    }
}
