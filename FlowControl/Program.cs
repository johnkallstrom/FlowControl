using FlowControl.Constants;

namespace FlowControl
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string title = "Flow control";
			string description = "Here is the main menu, use numbers to select an option";
			string[] options = ["1. Youth or senior", "2. Calculate total price", "3. Repeat ten times", "4. The third word", "0. Exit"];

			while (true)
			{
				UI.CreateMenu(title, description, options);
				int selection = InputReader.GetInteger(min: 0, max: 4, "Enter: ");
				switch (selection)
				{
					case 0:
						Environment.Exit(0);
						break;
					case 1:
						while (true)
						{
							UI.Clear();
							UI.Text("Youth or senior");
							UI.Space();

							int age = InputReader.GetInteger("Age: ");
							UI.Space();

							if (age < 20)
							{
								UI.Text($"The price for youths is {Price.Youth} kr");
							}
							else if (age > 64)
							{
								UI.Text($"The price for seniors is {Price.Senior} kr");
							}
							else
							{
								UI.Text($"The standard price is {Price.Standard} kr");
							}

							UI.CreateMenu(["1. Try again", "0. Back to main menu"]);
							selection = InputReader.GetInteger(min: 0, max: 1, "Enter: ");

							if (selection is 1) continue;
							if (selection is 0) break;
						}
						break;
					case 2:
						while (true)
						{
							UI.Clear();
							UI.Text("Calculate total price");
							UI.Space();

                            int total = InputReader.GetInteger("Amount of people: ");
							UI.Space();

                            int sum = 0;
							for (int i = 1; i <= total; i++)
							{
								int age = InputReader.GetInteger("Age: ");

								if (age < 20)
								{
									sum += Price.Youth;
									continue;
								}
								else if (age > 64)
								{
									sum += Price.Senior;
									continue;
								}
								else
								{
									sum += Price.Standard;
								}
							}

							UI.Space();
							UI.Text($"People: {total}");
							UI.Text($"Price: {sum} kr");

							UI.CreateMenu(["1. Try again", "0. Back to main menu"]);
							selection = InputReader.GetInteger(min: 0, max: 1, "Enter: ");

							if (selection is 1) continue;
							if (selection is 0) break;
						}
						break;
					case 3:
						while (true)
						{
							UI.Clear();
							UI.Text("Repeat ten times");
							UI.Space();

							string text = InputReader.GetString("Enter text: ");
							UI.Space();
							for (int i = 1; i <= 10; i++)
							{
                                Console.Write($"{i}. {text} ");
                            }

							UI.Space();
							UI.CreateMenu(["1. Try again", "0. Back to main menu"]);
							selection = InputReader.GetInteger(min: 0, max: 1, "Enter: ");

							if (selection is 1) continue;
							if (selection is 0) break;
						}
						break;
					case 4:
						while (true)
						{
							UI.Clear();
							UI.Text("The third word");
							UI.Text("Write a sentence with atleast three words");
							UI.Space();

							string text = InputReader.GetString("Enter text: ");
							var words = text.Split(" ");

							if (words.Count() >= 3)
							{
								UI.Text(words[2]);
							}
							else
							{
								UI.Text("Not enough words");
							}

							UI.CreateMenu(["1. Try again", "0. Back to main menu"]);
							selection = InputReader.GetInteger(min: 0, max: 1, "Enter: ");

							if (selection is 1) continue;
							if (selection is 0) break;
						}
						break;
					default:
						UI.Text("Incorrect input");
						break;
				}
			}
        }
	}
}