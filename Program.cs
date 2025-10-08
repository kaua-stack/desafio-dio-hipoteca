using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia:");
            Smartphone nokia = new Nokia(numero: "11998887777", modelo: "Nokia 3310", imei: "111111111111111", memoria: 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n------------------------\n");

            Console.WriteLine("Smartphone iPhone:");
            Smartphone iphone = new Iphone(numero: "11997776666", modelo: "iPhone 15 Pro", imei: "222222222222222", memoria: 256);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.WriteLine("\nPrograma finalizado.");
        }
    }
}
