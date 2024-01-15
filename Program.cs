using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "1198756231", modelo: "Nokia positivo P28", imei: "212854844961", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("Linkedin");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone iphone = new Iphone(numero: "119546328", modelo: "Iphone 15 Pro MAX", imei: "6541965411", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");