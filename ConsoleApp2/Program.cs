namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                CustomList<int> myList = new CustomList<int>();
                myList.Add(1);
                myList.Add(2);
                myList.Add(3);

                Console.WriteLine("Listedeki elemanlar:");
                foreach (var item in myList)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("3'ü içeren elemanı tap:");
                Console.WriteLine(myList.Find(x => x == 3));

                Console.WriteLine("Tüm elemanları tap:");
                foreach (var item in myList.FindAll(x => x > 1))
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("3'ü sil:");
                myList.Remove(3);

                Console.WriteLine("Listedeki elemanlar:");
                foreach (var item in myList)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
