// See https://aka.ms/new-console-template for more information
// #error version
// WriteLine($"Computer Named {Env.MachineName} says \"No.\"");
using System.Reflection;

System.Data.DataSet ds = new();
HttpClient client = new();

// Get the assembly that is the entry point of the application.
Assembly? myApp = Assembly.GetEntryAssembly();

// If null, close program.
if (myApp is null) return;

// Loop through the assemblies the my app references.
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    // Load the assembly so we can read its details.
    Assembly a = Assembly.Load(name);

    // Declare a variable to count the number of methods.
    int methodCount = 0;

    // Loop through the types in the assembly.
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // Add upp the counts of all the methods.
        methodCount += t.GetMethods().Length;
    }

    // Output the count of types and their different methods.
    WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name);
}