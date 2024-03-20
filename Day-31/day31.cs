using System;
using System.Threading;             // 'Thread' class located here

// One thread locks the lock when entering this region and unlocks when leaving
// If other thread see the status as locked, then it waits until it unlocks
// Lock allows resources(Method, File, etc.) to be accessed by one thread at a time
namespace LockApp
{
	// In a Bank, one transaction should occur at a time
	public class Bank{
		public static double Balance = 10;
		public static object lockObj = new object();            // Lock's Identifier
		public static void Withdraw(){
			// Locking allows only one thread to do the transaction at a time
			lock (lockObj)
			{
				Thread.Sleep(500);							// Wait for 500 Milliseconds
				if (Balance > 0){
					Balance -= 1;                  // Withdraw amount 1 for transaction
					Console.WriteLine($"Withdrawn: 1\nNew Balance: {Balance}");
				}
				else Console.WriteLine("Insufficient Balance!");
			}
		}
	}
	public class Program{
		public static void Main(string[] args){
			Thread[] threads = new Thread[15];              // Stores multiple threads

			for (int i = 0; i < 15; i++){
				// Each thread is supposed to withdraw amount 1 from the bank
				threads[i] = new Thread(Bank.Withdraw);
				threads[i].Start();                         // Run threads
			}
		}
	}
}
