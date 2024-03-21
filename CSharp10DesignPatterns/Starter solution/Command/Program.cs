using Command;

Console.Title = "Command";

CommandManager commandManager = new();
IEmployeeManagerRepository repository = new EmployeeManagerRepository();

commandManager.Invoke(
new AddEmployeeToManagerList(repository, 1, new Employee(111, "Alice"))
);
repository.WriteDataStore();


commandManager.Invoke(
new AddEmployeeToManagerList(repository, 2, new Employee(112, "Bob"))
);
repository.WriteDataStore();


commandManager.Undo();
repository.WriteDataStore();


commandManager.Invoke(
new AddEmployeeToManagerList(repository, 1, new Employee(113, "Charlie"))
);
repository.WriteDataStore();


// try adding the same employee again
commandManager.Invoke(
new AddEmployeeToManagerList(repository, 1, new Employee(113, "Charlie"))
);
repository.WriteDataStore();


commandManager.UndoAll();
repository.WriteDataStore();


Console.WriteLine(Environment.NewLine + "Press any key to terminate program.");
Console.ReadKey();