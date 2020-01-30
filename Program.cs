using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
		Console.WriteLine("Write something to be reversed...");
            	string input = Console.ReadLine();
		Console.WriteLine(Reverse(input));
        }
		
	static string Reverse (string word){
		string drow = null;
		for(int i = word.Length - 1; i >= 0; i--){
		drow += word[i];
		}
			
		return drow;
	}
    }
}
