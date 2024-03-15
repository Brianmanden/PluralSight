Console.Title = "Proxy";

//without proxy
Console.WriteLine("Constructing document.");
Proxy.Document myDocument = new("MyDocument.pdf");
Console.WriteLine("Document constructed.");
myDocument.DisplayDocument();


Console.WriteLine(Environment.NewLine);


Console.WriteLine("Constructing document proxy.");
Proxy.DocumentProxy myDocumentProxy = new("MyDocument.pdf");
Console.WriteLine("Document proxy constructed.");
myDocumentProxy.DisplayDocument();


Console.WriteLine(Environment.NewLine);


// with chained proxy
Console.WriteLine("Constructing protected document proxy.");
Proxy.ProtectedDocumentProxy myProtectedDocumentProxy = new("MyDocument.pdf", "Viewer");
Console.WriteLine("Protected document proxy constructed.");
myProtectedDocumentProxy.DisplayDocument();


Console.WriteLine(Environment.NewLine);


// with chained proxy, no access
Console.WriteLine("Constructing protected document proxy.");
myProtectedDocumentProxy = new("MyDocument.pdf", "AnotherRole");
Console.WriteLine("Protected document proxy constructed.");
myProtectedDocumentProxy.DisplayDocument();


Console.WriteLine(Environment.NewLine + "Press any key to terminate program.");
Console.ReadKey();