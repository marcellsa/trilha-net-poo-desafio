using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("\nSmartphone Nokia");
Smartphone nokia = new Nokia(numero: "987654321", modelo: "Modelo de teste 1", imei: "123123123", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Jogo da Serpente");

Console.WriteLine("\nSmartphone Iphone");
Smartphone iphone = new Iphone(numero: "123456789", modelo: "Modelo de teste 2", imei: "456456456", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("FaceTime");
Console.WriteLine("\n");