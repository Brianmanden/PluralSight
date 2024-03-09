using Prototype;

Console.Title = "Prototype";

Manager manager = new("Ltd. Dan");
Manager managerClone = (Manager)manager.Clone();

Console.WriteLine($"Manager was cloned: {managerClone.Name}");

//Employee employee = new("Forrest G", manager);
Employee employee = new("Forrest G", managerClone);
Employee employeeClone = (Employee)employee.Clone();
Console.WriteLine($"Employee was cloned: {employee.Name}, with manager {employee.Manager.Name}");

// change the manager name
managerClone.Name = "MegaSpaceKaren";
Console.WriteLine($"Employee was cloned: {employee.Name}, with manager {employee.Manager.Name}");

Console.WriteLine(Environment.NewLine + "Press any key to terminate program.");
Console.ReadKey();