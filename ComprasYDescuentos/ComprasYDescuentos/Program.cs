using System;

namespace CalcularDescuento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("BIENVENIDOS AL PROGRAMA DE CALCULAR DESCUENTO PARA CLIENTES");
            Console.WriteLine("---------------------------------------------------------------");

            double[,] comprasDeClientes = {
            {50, 120, 100, 40, 150}, //cliente 1
            {300, 80, 90, 700, 400}, //cliente 2
            {10, 12, 21, 8, 10},  //cliente 3
            {50, 60, 70, 80, 90}, // cliente 4
            {100, 150, 200, 250, 300} // cliente 5
        };

            AplicarDescuentos(comprasDeClientes);
            Console.ReadLine();
        }

        static void AplicarDescuentos(double[,] compras)
        {
            for (int cliente = 0; cliente < compras.GetLength(0); cliente++)
            {
                double totalCompra = 0;

                for (int compra = 0; compra < compras.GetLength(1); compra++)
                {
                    totalCompra += compras[cliente, compra];
                }

                double descuento = 0;
                if (totalCompra >= 100 && totalCompra <= 1000)
                {
                    descuento = totalCompra * 0.1;
                }
                else if (totalCompra > 1000)
                {
                    descuento = totalCompra * 0.2;
                }

                double totalFinal = totalCompra - descuento;

                string mensajeFinal = string.Format($"El Cliente No: {cliente + 1} \n" +
                    $"Ha comprado un total de: {totalCompra}Q \n" +
                    $"Ha obtenido un descuento de: {descuento}Q \n" +
                    $"Y su Total a pagar es de: {totalFinal}Q \n" +
                    $"--------------------------------------------------------------\n");

                Console.WriteLine(mensajeFinal);
            }
        }
    }
}
