namespace FlowControl
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string title = "Flow control";
			string description = "Here is the main menu, use numbers to select an option";
			string[] options = ["1. Youth or senior", "0. Exit"];

			while (true)
			{
				UserInterface.ShowMenu(title, description, options);

				string input = UserInterface.GetStringInput("Enter: ");
				switch (input)
				{
					case "0":
						Environment.Exit(0);
						break;
					case "1":
						Console.Clear();
                        Console.WriteLine("Youth or senior");
                        Console.WriteLine();

						int age = UserInterface.GetIntInput("Age: ");

                        Console.ReadKey();
                        break;
					default:
						UserInterface.Text($"Incorrect input", withDots: true);
						break;
				}
			}
        }
	}
}