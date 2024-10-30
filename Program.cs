using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class program
{


    static void Main(string[] args)
    {
        Console.WriteLine("Smartphone: Iphone");
        Iphone i = new Iphone(numero:"987654321", modelo:"iPhone 13", imei:"IMEI987654321", memoria: 128);
        i.Ligar();
        i.InstalarAplicativo("Facebook");


        Console.WriteLine("\n");


        Console.WriteLine("Smartphone: Nokia");
        Nokia n = new Nokia(numero:"123456789", modelo:"Nokia 3310", imei:"IMEI123456789", memoria: 32); 
        n.ReceberLigacao();
        n.InstalarAplicativo("Telegram");


    
    }



}