using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("\n--- Testando iPhone ---");
Smartphone iphone = new Iphone("(11) 2222-3333", "iPhone 15", "1234567890", 12);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Netflix");

Console.WriteLine("\n--- Testando  Nokia ---");
Smartphone nokia = new Nokia("(11) 4444-5555", "Nokia Flip", "0987654321", 12);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Disney");

Console.WriteLine();