public class Program;

public static void Main()
{
    Random rnd = new Random();
    int num = rnd.Next(0, 10);
    string[] Words = {"program", "house", "chuckingly", "hamburger", "bedroom", "calculator", "newspaper", "sunlight", "market", "escape"};        
    Console.WriteLine(Words[num]);   
}