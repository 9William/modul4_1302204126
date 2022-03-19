namespace modul4_1302204126
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hasil : " + Penjumlahan<int>.JumlahTigaAngka(13, 02, 20));


            SimpleDataBase<int> sdb = new SimpleDataBase<int>();

            sdb.AddNewData(13); sdb.AddNewData(02); sdb.AddNewData(20);
            sdb.PrintAllData();

        }
    }
}
