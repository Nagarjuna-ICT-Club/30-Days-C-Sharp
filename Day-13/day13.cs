using System;

namespace IndexerApp
{
	public class Students
	{
		public string[] names = new string[3];
		// 'Indexer' is similar to a 'Property' but, it takes parameter		
		public string this[int i]			// This indexer returns the 'ith' string element of string array
		{
			get {return names[i];}
			set{
				if (!names.Contains(value)) names[i] = value;
				else names[i] = "No Name";
			}
		}
	}
	public class Program
	{
		public static void Main(string[] args){
			Students s1 = new Students();
			s1[0] = "Ram";				// Set object's array member as if object is the array itself
			s1[1] = "Hari";
			s1[2] = "Hari";             // 'Hari' already exists. So, this becomes 'null'

			foreach(string name in s1.names)				// Get object's array members
			{
				Console.WriteLine(name);	
			}
		}
	}
}

// Indexer are basically parameterized Property but they use 'this[]' keyword instead of an indentifier 
// 'Indexer' is also known as 'Smart Array'