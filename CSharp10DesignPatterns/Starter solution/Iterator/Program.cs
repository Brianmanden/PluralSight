using Iterator;

Console.Title = "Iterator";

// create the collection
PeopleCollection people = new();
people.Add(new Person("Joe", "The Wild West"));
people.Add(new Person("Jack", "The Wild West"));
people.Add(new Person("William", "The Wild West"));
people.Add(new Person("Averell", "The Wild West"));

// create the iterator
IPeopleIterator peopleIterator = people.CreateIterator();

// use the iterator to parse through the people
// in the collection, they should be shown in alphabetical order
for (Person person = peopleIterator.First(); !peopleIterator.IsDone; person = peopleIterator.Next())
{
	Console.WriteLine(person?.Name);
}

Console.WriteLine(Environment.NewLine + "Press any key to terminate program.");
Console.ReadKey();