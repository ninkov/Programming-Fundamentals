using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
			
public class Program
{
	public static void Main()
	{
		string word = Console.ReadLine();
		
		char[] alphabet = new char[26];
		
		var index = 0;
		
		for(char letter = 'a';letter <= 'z'; letter++)
		{
			
			alphabet[index]=letter;
			index++;
		}
		for(int i = 0; i < word.Length; i++)	
		{
			char currentLetter = word[i];
			
			for(int j = 0; j < alphabet.Length; j++)
			{
				if(currentLetter==alphabet[j])
				{
					Console.WriteLine("{0} -> {1}",currentLetter,j);
				}
			}
		}
		
	}
}
