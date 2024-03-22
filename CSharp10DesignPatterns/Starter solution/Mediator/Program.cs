using Mediator;
Console.Title = "Mediator";


TeamChatRoom teamChatRoom = new();


TeamMember huey = new Lawyer("Huey");
TeamMember dewey = new Lawyer("Dewey");
TeamMember louie = new AccountManager("Louie");
TeamMember donald = new AccountManager("Donald");
TeamMember daisy = new AccountManager("Daisy");


teamChatRoom.Register(huey);
teamChatRoom.Register(dewey);
teamChatRoom.Register(louie);
teamChatRoom.Register(donald);
teamChatRoom.Register(daisy);


louie.Send("Hi all, can someone check file ABC123? I need a compliance check.");
huey.Send("On it!");
huey.Send("Louie", "Let´s talk in a Teams call?");
huey.Send("Louie", "All good :)");
louie.SendTo<AccountManager>("The file has been approved!");

Console.WriteLine(Environment.NewLine + "Press any key to terminate program.");
Console.ReadKey();