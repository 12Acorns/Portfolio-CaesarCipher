namespace CaesarCipherApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string _result = CaesarCipher.BasicEncryption("hello world", 3);
			Console.WriteLine(_result);
			Console.ReadLine();
		}
	}
}
