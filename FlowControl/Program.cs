namespace FlowControl
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string title = "Flow control";
			string description = "Here is the main menu, use numbers to select an option";
			string[] options = ["1. Youth or senior", "2. Calculate total price", "0. Exit"];

			while (true)
			{
				UserInterface.CreateMenu(title, description, options);

				string input = UserInterface.GetStringInput("Enter: ");
				switch (input)
				{
					case "0":
						Environment.Exit(0);
						break;
					case "1":
						while (true)
						{
							Console.Clear();
							Console.WriteLine("Youth or senior");
							Console.WriteLine();

							int age = UserInterface.GetIntInput("Age: ");
							Console.WriteLine();

							if (age < 20)
							{
								Console.WriteLine("Price for youths is 80 kr");
							}
							else if (age > 64)
							{
								Console.WriteLine("Price for seniors is 90 kr");
							}
							else
							{
								Console.WriteLine("Standard price is 120 kr");
							}

							UserInterface.CreateMenu(["1. Try again", "0. Back to main menu"]);
							input = UserInterface.GetStringInput("Enter: ");

							if (input.Equals("1")) continue;
							if (input.Equals("0")) break;
						}
						break;
					case "2":
						while (true)
						{
							Console.Clear();
							Console.WriteLine("Calculate total price");

							int total = UserInterface.GetIntInput("Enter: ");

							int sum = 0;
							for (int i = 0; i <= total; i++)
							{
								int age = UserInterface.GetIntInput("Age: ");
							}

							UserInterface.CreateMenu(["0. Back to main menu"]);
							input = UserInterface.GetStringInput("Enter: ");

							if (input.Equals("1")) continue;
							if (input.Equals("0")) break;
						}
						break;
					default:
						UserInterface.Text($"Incorrect input", withDots: true);
						break;
				}
			}
        }
	}
}