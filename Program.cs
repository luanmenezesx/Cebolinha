Console.Clear();

string fala;
string falaTrocada;

Console.Write("Digite uma frase: ");
fala = Console.ReadLine()!.ToLower();

falaTrocada = fala.Replace("r", "l");

Console. WriteLine($"Frase original: {fala}");
Console. WriteLine($"Frase do Cebolinha: {falaTrocada}");