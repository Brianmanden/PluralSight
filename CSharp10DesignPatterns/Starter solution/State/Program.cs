using State;

Console.Title = "State";

BankAccount bankAccount = new();
Console.WriteLine($"Current balance is: {bankAccount.Balance}{Environment.NewLine}");

bankAccount.Deposit(100);
Console.WriteLine($"Current balance is: {bankAccount.Balance}{Environment.NewLine}");

bankAccount.Withdraw(500);
Console.WriteLine($"Current balance is: {bankAccount.Balance}{Environment.NewLine}");

bankAccount.Withdraw(100);
Console.WriteLine($"Current balance is: {bankAccount.Balance}{Environment.NewLine}");

// deposit enough to go to gold state of account
bankAccount.Deposit(2000);
Console.WriteLine($"Current balance is: {bankAccount.Balance}{Environment.NewLine}");

// should be in gold state now
bankAccount.Deposit(100);
Console.WriteLine($"Current balance is: {bankAccount.Balance}{Environment.NewLine}");

// back to overdraw
bankAccount.Withdraw(3000);
Console.WriteLine($"Current balance is: {bankAccount.Balance}{Environment.NewLine}");

// should transition to regular
bankAccount.Deposit(3000);
Console.WriteLine($"Current balance is: {bankAccount.Balance}{Environment.NewLine}");

// should still be in regular
bankAccount.Deposit(100);
Console.WriteLine($"Current balance is: {bankAccount.Balance}{Environment.NewLine}");


Console.WriteLine(Environment.NewLine + "Press any key to terminate program.");
Console.ReadKey();