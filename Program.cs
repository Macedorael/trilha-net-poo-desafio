using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"123456789", modelo:"Nokia 3310", imei:"123456789",memoria:16);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"123456789", modelo:"Iphone 14", imei:"123456789",memoria:16);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");