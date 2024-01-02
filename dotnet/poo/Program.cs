using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("------ Nokia ------");
Nokia nokia = new Nokia(numero: "123456789", modelo: "ABCD", imei: "147258369", memoria: "32");
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("");

Console.WriteLine("------ Iphone ------");
Iphone iphone = new Iphone(numero: "987654321",  modelo: "EFGH", imei: "963258741", memoria: "64");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");