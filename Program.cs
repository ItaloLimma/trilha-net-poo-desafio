using DesafioPOO.Models;

// IMPLEMENTADO!
Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "12345678", modelo: "Modelo 1", imei: "10101101", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "98765432", modelo: "Modelo 2", imei: "01010010", memoria: 256);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");
