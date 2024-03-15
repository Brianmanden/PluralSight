Console.Title = "Composite";


Composite.Directory root = new Composite.Directory("root", 0);
Composite.File topLevelFile = new Composite.File("toplevel.txt", 100);
Composite.Directory topLevelDirectory1 = new Composite.Directory("topleveldirectory1", 4);
Composite.Directory topLevelDirectory2 = new Composite.Directory("topleveldirectory2", 4);

root.Add(topLevelFile);
root.Add(topLevelDirectory1);
root.Add(topLevelDirectory2);

Composite.File subLevelFile1 = new Composite.File("sublevel1.txt", 200);
Composite.File subLevelFile2 = new Composite.File("sublevel2.txt", 150);

topLevelDirectory2.Add(subLevelFile1);
topLevelDirectory2.Add(subLevelFile2);

Console.WriteLine($"Size for {nameof(root)}: {root.GetSize()}");
Console.WriteLine($"Size for directory {nameof(topLevelDirectory1)}: {topLevelDirectory1.GetSize()}");
Console.WriteLine($"Size for directory {nameof(topLevelDirectory2)}: {topLevelDirectory2.GetSize()}");

Console.WriteLine(Environment.NewLine + "Press any key to terminate program.");
Console.ReadKey();