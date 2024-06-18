namespace LibMath
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("1- Área do triângulo");
            int resp = Convert.ToInt16(Console.ReadLine());

            LibMath lib = new LibMath();

            switch (resp){
                case 1:

                    Console.WriteLine("Digite o valor do raio:");
                    float raio = (float) Console.ReadLine();

                    lib.AreaCirculo();


                    break;
                case 2:

                    break;
            }
        }
    }
}
