using Desharp;
using System;

class Program {
	static void Main(string[] args) {

		var dlTest = new Tests.DumpingAndLoging();
		dlTest.TestAll();
		
		var eTest = new Tests.ExceptionsRendering();
		eTest.TestAll();
		
        Console.ReadLine();
    }
}
