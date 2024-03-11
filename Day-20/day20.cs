using System;
using System.Collections.Generic;					// Provides access to Dictionary class

namespace DictionaryApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Here, '<string, string>' is <key_data_type, value_data_type>
			Dictionary<string, string> family = new Dictionary<string, string>();

			family.Add("father", "Ram KC");         // Add key value pair
			family.Add("mother", "Sita KC");
			family.Add("son", "Gopal KC");

			Console.WriteLine(family["father"]);	// Output: Ram KC	 
			family.Remove("son");					// Removing Dictionary items using the 'key'
			Console.WriteLine(family.Count);		// Output: 2
			// Check is there exists particular 'key' in the dictionary
			Console.WriteLine(family.ContainsKey("father"));					// Output: True
			// Check is there exists particular 'value' in the dictionary
			Console.WriteLine(family.ContainsValue("Gopal KC"));				// Output: True

			// During iteration, each dictionary item is represented by 'KeyValue' struct 
			foreach (KeyValuePair<string, string> member in family)
			{
				Console.Write(member.Key + ": " + member.Value + "\n");
			}
		}
	}
}