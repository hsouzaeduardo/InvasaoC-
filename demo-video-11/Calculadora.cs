namespace demo_video_11
{
    public class Calculadora
    {
        public static int CalcularSoma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static int CalcularSoma(int numero1, int numero2, int numero3)
        {
            return  CalcularSoma(numero1, numero2) + numero3;
        }   
       
        public static int CalcularSubtracao(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public static int CalcularMultiplicacao(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public static int CalcularDivisao(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

    }
}