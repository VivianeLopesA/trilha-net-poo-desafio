using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia cel = new Nokia("598614", "Modelo 7", "1111999", 67);

cel.Ligar();
cel.ReceberLigacao();
cel.InstalarAplicativo("Banco Itau");

Console.WriteLine("\n");

Iphone cel2 = new Iphone("6935874", "Modelo 14", "2222522", 74);

cel2.Ligar();
cel2.ReceberLigacao();
cel2.InstalarAplicativo("Sudoku");