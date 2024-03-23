using System.ComponentModel.DataAnnotations;

using ChainOfResponsibility;

Console.Title = "Chain of Responsibility";

Document validDocument = new("How to avoid BrainFuck development", DateTimeOffset.UtcNow, true, true);
Document invalidDocument = new("How to avoid BrainFuck development", DateTimeOffset.UtcNow, false, true);

var documentHandlerChain = new Document.DocumentTitleHandler();
documentHandlerChain
	.SetSuccessor(new Document.DocumentLastModifiedHandler())
	.SetSuccessor(new Document.DocumentApprovedByLitigationHandler())
	.SetSuccessor(new Document.DocumentApprovedByManagementHandler());

try
{
	documentHandlerChain.Handle(validDocument);
	Console.WriteLine("Valid document is valid");
	documentHandlerChain.Handle(invalidDocument);
	Console.WriteLine("Invalid document is invalid");
}
catch (ValidationException validationException)
{
	Console.WriteLine(validationException.Message);
}


Console.WriteLine(Environment.NewLine + "Press any key to terminate program.");
Console.ReadKey();