// See https://aka.ms/new-console-template for more information

class pemprosesanData
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
        pemprosesanData nilaiTerbesar = new pemprosesanData();

        nilaiTerbesar.DapatkanNilaiTerbesar<int>(12,34,56);
    }
}