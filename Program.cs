namespace LibMath
{
    internal class Program
    {


        static void Main(string[] args)
        {
            LibMath libmath = new LibMath();
            int opt = 1;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 calcular área do retângulo: ");
                Console.WriteLine("2 calcular àrea do losango: ");
                Console.WriteLine("3 calcular área do quadrado: ");
                Console.WriteLine("0 SAIR");

                opt = Convert.ToInt16(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
                Console.ReadKey();

            } while (opt != 0);

        }
    }
}