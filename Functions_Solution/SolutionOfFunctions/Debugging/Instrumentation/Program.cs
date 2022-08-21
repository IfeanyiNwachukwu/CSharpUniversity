
using Microsoft.Extensions.Configuration;
using System.Diagnostics;

//// Write to output window
////Debug.WriteLine("Debug says, I am watching!");
////Trace.WriteLine("Trace says, I am watching");

//// Write to a text file in the project folder
//Trace.Listeners.Add(new TextWriterTraceListener(
// File.CreateText(Path.Combine(Environment.GetFolderPath(
// Environment.SpecialFolder.DesktopDirectory), "log.txt"))));

//// text writer is buffered, so this option calls
//// Flush() on all listeners after writing
//Trace.AutoFlush = true;

//Debug.WriteLine("Debug says, I am watching!");
//Trace.WriteLine("Trace says, I am watching");

ConfigurationBuilder builder = new();

builder.SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

TraceSwitch ts = new(
        displayName: "PactSwitch",
        description: "This switch is set via a JSON config."
    );

configuration.GetSection("PacktSwitch").Bind(ts);

Trace.WriteLine(ts.TraceError, "Trace Error");
Trace.WriteLine(ts.TraceWarning, "Trace warning");
Trace.WriteLine(ts.TraceInfo, "Trace Information");
Trace.WriteLine(ts.TraceVerbose, "Trace Verbose");
