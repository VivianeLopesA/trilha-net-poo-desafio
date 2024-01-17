using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia celNokia = new Nokia("598614", "Modelo 7", "1111999", 67);

celNokia.Ligar();
celNokia.ReceberLigacao();
celNokia.InstalarAplicativo("Banco Itau");

Console.WriteLine("\n");

Iphone celIphone = new Iphone("6935874", "Modelo 14", "2222522", 74);

celIphone.Ligar();
celIphone.ReceberLigacao();
celIphone.InstalarAplicativo("Sudoku");