using Flyweight;

Console.Title = "Flyweight";

string aBunchOfCharacters = "abba";

CharacterFactory characterFactory = new();

// Get the flyweight(s)
ICharacter characterObject = characterFactory.GetCharacter(aBunchOfCharacters[0]);
// Pass through intrinsic state
characterObject?.Draw("Arial", 12);
Console.WriteLine(Environment.NewLine);


characterObject = characterFactory.GetCharacter(aBunchOfCharacters[1]);
characterObject?.Draw("Trebuchet", 14);
Console.WriteLine(Environment.NewLine);


characterObject = characterFactory.GetCharacter(aBunchOfCharacters[2]);
characterObject?.Draw("Times New Roman", 16);
Console.WriteLine(Environment.NewLine);


characterObject = characterFactory.GetCharacter(aBunchOfCharacters[3]);
characterObject?.Draw("Comic Sans", 18);
Console.WriteLine(Environment.NewLine);

// create unshared concrete flyweight (paragraph)
ICharacter paragraph = characterFactory.CreateParagraph(new List<ICharacter>() { characterObject }, 1);

// draw the paragraph
paragraph.Draw("Lucinda", 12);


Console.WriteLine(Environment.NewLine);
Console.WriteLine(Environment.NewLine + "Press any key to terminate program.");
Console.ReadKey();