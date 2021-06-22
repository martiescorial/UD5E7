using System;

namespace UD5E7
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "Escribe una cantidad de euros";
            double cantidad = Convert.ToDouble(texto);
            String moneda = "Escribe la moneda a la que quieres convertir";
            conversor(cantidad, moneda);
        }
        public static void conversor(double cantidad, String moneda)
        {
            double res = 0;

            
            bool correcto = true;

            //Segun la moneda, calculamos la cantidad
            switch (moneda)
            {
                case "libras":
                    res = cantidad * 0.86;
                    break;
                case "dolares":
                    res = cantidad * 1.29;
                    break;
                case "yenes":
                    res = cantidad * 129.852;
                    break;
                default:
                    Console.WriteLine("La moneda no es correcta");
                    correcto = false;
                    break;
            }

          
            if (correcto)
            {
                Console.WriteLine(cantidad + " euros en " + moneda + " son " + res);
            }
     
        }
    }
}
