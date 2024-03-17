// See https://aka.ms/new-console-template for more information
class program
{
    public static void Main(string[] args)
    {
        HaloGeneric.SapaUser_1302223123<string>("Faris");

        DataGeneric<String> ObjekData = new DataGeneric<string>("1302223123");
        ObjekData.PrintData();
    }

    class HaloGeneric
    {
        public static void SapaUser_1302223123<x>(x inputan)
        {
            Console.WriteLine($"Halo user {inputan}");
        }
    }

    class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang Tersimpan adalah {data}");
        }
    }
}