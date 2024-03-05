using System;
using System.Collections;			// 'Hashtable' is located in this namespace

namespace HashtableApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Hashtable family = new Hashtable();
			// We can add key-value pairs of any data type
			family.Add("father", "Ram");
			family.Add("mother", "Sita");
			family.Add("son", 1);
			// Accessing 'value' with the help of 'key'
			Console.WriteLine(family["father"]);				// Output: Ram
			family.Remove("son");				// Delete item by specifying key
			Console.WriteLine(family.Count);					// Output: 2
			Console.WriteLine(family.ContainsKey("father"));	// Output: True
			Console.WriteLine(family.ContainsValue("Gopal"));	// Output: False

			// Each item of Hashtable is specified by 'DictionaryEntry' struct
			foreach (DictionaryEntry item in family)			
			{
				Console.Write(item.Key + " ");
				Console.WriteLine(item.Value); 
			}
		}

	}
}