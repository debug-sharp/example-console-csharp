using Desharp;
using System;
using System.Collections.Generic;

class Program {
	static void Main(string[] args) {

        Program._demoDumpAndLog();
        Program._demoException();
        //Program._runTests();
		
        Console.ReadLine();
    }
    private static void _demoDumpAndLog() {
        Console.Write("Press enter key to dump demo data and write it to HDD.");
        Console.ReadLine();
        Console.WriteLine();

        var demoObject = new Dictionary<string, object>() {
            { "clark", new {
                name = "Clark",
                surname = "Kent",
                tshirtIdol = "chuck"
            } },
            { "chuck", new {
                name = "Chuck",
                surname = "Noris",
                tshirtIdol = "bud"
            } },
            { "bud", new {
                name = "Bud",
                surname = "Spencer",
                tshirtIdol = ""
            } }
        };

        Debug.Dump(demoObject);
        Debug.Log(demoObject);

        Console.WriteLine();
        Console.WriteLine();
    }
    private static void _demoException () {
        Console.Write("Press enter key to dump catched demo exception and write it to HDD.");
        Console.ReadLine();
        Console.WriteLine();

        try {
            throw new Exception("Demo exception:-)");
        } catch (Exception ex) {
            Debug.Dump(ex);
            Debug.Log(ex);
        }
        
        Console.WriteLine();
        Console.WriteLine();
    }
    private static void _runTests () {
        Console.Write("Pres enter key to start duping test objects.");
        Console.ReadLine();
        Console.WriteLine();

		var dlTest = new Desharp.Tests.DumpingAndLoging();
		dlTest.TestAll();

		var eTest = new Desharp.Tests.ExceptionsRendering();
		eTest.TestAll();
    }
}
