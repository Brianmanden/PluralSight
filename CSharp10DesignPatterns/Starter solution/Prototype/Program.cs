using Prototype;

Console.Title = "Prototype";

Manager manager = new("Ltd. Dan");
Manager managerClone = (Manager)manager.Clone();

Console.WriteLine($"Manager was cloned: {managerClone.Name}");


//Employee employee = new("Forrest G", manager);
Employee employee = new("Forrest G", managerClone);
//Employee employeeClone = (Employee)employee.Clone(true);
Employee employeeClone = (Employee)employee.Clone(true);

Console.WriteLine($"Employee was cloned: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");


// change the manager name
managerClone.Name = "MegaSpaceKaren";
Console.WriteLine($"Employee was cloned: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");


Console.WriteLine(Environment.NewLine + "Press any key to terminate program.");
Console.ReadKey();