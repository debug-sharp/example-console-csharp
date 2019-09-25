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
    }
    private static void _demoException () {
        Console.Write("Press enter key to dump catched demo exception and write it to HDD.");
        Console.ReadLine();

        try {
            throw new Exception("Demo exception:-)");
        } catch (Exception ex) {
            Debug.Dump(ex);
            Debug.Log(ex);
        }
    }
    private static void _runTests () {
        Console.Write("Pres enter key to start duping test objects.");
        Console.ReadLine();

		var dlTest = new Tests.DumpingAndLoging();
		dlTest.TestAll();

		var eTest = new Tests.ExceptionsRendering();
		eTest.TestAll();
    }
}
