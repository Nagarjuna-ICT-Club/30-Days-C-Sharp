using System;

namespace IndexerApp
{
	public class Students
	{
		public string[] names = new string[3];
		// This indexer returns the 'ith' string element of string array
		public string this[int i]           
		{
			get { return names[i]; }
			set{
				if (!names.Contains(value)) names[i] = value;
				else names[i] = "No Name";
			}
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			Students s1 = new Students();
			s1[0] = "Ram";        // Set object's array member as if object is the array itself
			s1[1] = "Hari";
			s1[2] = "Hari";       // 'Hari' already exists. So, this becomes 'null'
			// Output: Ram, Hari, No Name,
			foreach (string name in s1.names)               // Get object's array members
			{
				Console.Write(name + ", ");
			}
		}
	}
}
