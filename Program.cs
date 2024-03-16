namespace tpmodul5_1302223027
{
    class Program


    {



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







        }




    }
}