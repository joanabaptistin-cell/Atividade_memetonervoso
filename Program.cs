string fraseMemeTonervoso,fraseDigitada;

Console.Write("Usuário, o que você pensa sobre mim?");
fraseDigitada = Console.ReadLine()!;

fraseMemeTonervoso 
= $"{fraseDigitada.Remove(10)}...NÃO,PERA. \nTô Nervoso";
 
Console.Write(fraseMemeTonervoso);
