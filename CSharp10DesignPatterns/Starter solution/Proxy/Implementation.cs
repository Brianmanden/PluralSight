namespace Proxy
{
	/// <summary>
	/// Subject
	/// </summary>
	public interface IDocument
	{
		void DisplayDocument();
	}

	/// <summary>
	/// RealSubject
	/// </summary>
	public class Document : IDocument
	{
		public string? Title { get; set; }
		public string? Content { get; set; }
		public int AuthorId { get; set; }
		public DateTimeOffset LastAccessed { get; private set; }
		private string _fileName;

		public Document(string fileName)
		{
			_fileName = fileName;
			LoadDocument(fileName);
		}

		private void LoadDocument(string fileName)
		{
			Console.WriteLine($"Executing expensive action: loading a file (\"{fileName}\") from disk");
			// fake loading...
			Thread.Sleep(1000);

			Title = "An expensive document";
			Content = "Lots and lots of content";
			AuthorId = 1;
			LastAccessed = DateTimeOffset.UtcNow;
		}

		public void DisplayDocument()
		{
			Console.WriteLine($"Title: {Title}, Content: {Content}");
		}
	}

	public class DocumentProxy : IDocument
	{
		private Document? _document;
		private string _fileName;

		public DocumentProxy(string fileName)
		{
			_fileName = fileName;
		}

		public void DisplayDocument()
		{
			if (_document == null)
			{
				_document = new(_fileName);
			}

			_document.DisplayDocument();
		}
	}
}
