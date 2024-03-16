namespace tpmodul5_1302223027
{
    class Program


    {


        public class DataGeneric<T>
        {
            private T data;
            public DataGeneric(T data) { 
                this.data = data;   
            }

            public void PrintData()
            {
                Console.WriteLine("Data yang tersimpan adalah: "+this.data);
            }
        }



        public class HaloGeneric
        {
            public void SapaUser<T>(T user)
            {
                Console.WriteLine("Halo user " + user);

            }
        }
        static void Main(string[] args)
        {


            HaloGeneric test1 = new HaloGeneric();
            test1.SapaUser("kevin");
            Console.WriteLine();
            HaloGeneric test2 = new HaloGeneric();
            test2.SapaUser(1);
            Console.WriteLine();

            DataGeneric<string> test3 = new DataGeneric<string>("1302223027");
            test3.PrintData();
            Console.WriteLine();
            DataGeneric<int> test4 = new DataGeneric<int>(1302223027);
            test4.PrintData();  





        }




    }
}