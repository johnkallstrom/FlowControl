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

				string input = InputReader.GetString("Enter: ");
				switch (input)
				{
					case "0":
						Environment.Exit(0);
						break;
					case "1":
						while (true)
						{
							UserInterface.Clear();
							UserInterface.Text("Youth or senior");
							UserInterface.Space();

							int age = InputReader.GetInteger("Age: ");
							UserInterface.Space();

							if (age < 20)
							{
								UserInterface.Text("Price for youths is 80 kr");
							}
							else if (age > 64)
							{
								UserInterface.Text("Price for seniors is 90 kr");
							}
							else
							{
								UserInterface.Text("Standard price is 120 kr");
							}

							UserInterface.CreateMenu(["1. Try again", "0. Back to main menu"]);
							input = InputReader.GetString("Enter: ");

							if (input.Equals("1")) continue;
							if (input.Equals("0")) break;
						}
						break;
					case "2":
						while (true)
						{
							UserInterface.Clear();
							UserInterface.Text("Calculate total price");
							UserInterface.Space();

                            int total = InputReader.GetInteger("Amount of people: ");
							UserInterface.Space();

                            int sum = 0;
							for (int i = 1; i <= total; i++)
							{
								int age = InputReader.GetInteger("Age: ");

								if (age < 20)
								{
									sum += 80;
									continue;
								}
								else if (age > 64)
								{
									sum += 90;
									continue;
								}
								else
								{
									sum += 120;
								}
							}

							UserInterface.Space();
							UserInterface.Text($"People: {total}");
							UserInterface.Text($"Price: {sum} kr");

                            UserInterface.CreateMenu(["0. Back to main menu"]);
							input = InputReader.GetString("Enter: ");

							if (input.Equals("1")) continue;
							if (input.Equals("0")) break;
						}
						break;
					default:
						UserInterface.TextWithTrailingDots("Incorrect input");
						break;
				}
			}
        }
	}
}