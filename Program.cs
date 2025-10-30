using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1231313", modelo: "46444", imei: "1111111", memoria: 12);
nokia.Ligar();
nokia.InstalarAplicativo("WhastApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "9999999", modelo: "14GS", imei: "56565656", memoria: 16);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
