using DesafioPOO.Models;
using System.Net.NetworkInformation;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero : "123456", modelo : "Modelo 1 ", imei:"11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2 ", imei: "22222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

// Lendo os dados de entrada
string modelo = Console.ReadLine();
int anoFabricacao = int.Parse(Console.ReadLine());
int anoAtual = int.Parse(Console.ReadLine());



//  TODO: Implemente a chamada do método para verificar se o carro está apto
string resultado = "";

// Exibindo o resultado
Console.WriteLine(resultado);

class CarroMonitoramento
{
    // TODO: Crie o método estático que verifica se o carro está apto
    public static string VerificaAptidao() 
    {
        return anoAtual - anoFabricacao <= 10 ? modelo + ":" "Apto" : modelo+":" +"Nao Apto";
    }
    // TODO: Calcule a idade do carro


    // TODO: Verifique se o carro tem até 10 anos

   
}