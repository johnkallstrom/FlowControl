namespace FlowControl.Utilities
{
	public static class UserInterface
	{
		public static void ShowMenu(string title, string description, string[] options)
		{
			Console.Clear();
			Console.WriteLine(title);
			Console.WriteLine(description);
			Console.WriteLine();

			foreach (var option in options)
			{
                Console.WriteLine(option);
            }

			Console.WriteLine();
		}

		public static void Text(string content, bool withDots = false)
		{
			Console.Write(content);
			if (withDots)
			{
				for (int i = 1; i <= 3; i++)
				{
					Console.Write($".");
					Thread.Sleep(1000);
				}
			}
		}

		public static string GetStringInput(string msg = "")
		{
			Console.Write(msg);
			string? input = Console.ReadLine();

			if (!string.IsNullOrWhiteSpace(input))
			{
				return input;
			}

			return string.Empty;
		}

		public static int GetIntInput(string msg = "")
		{
			Console.Write(msg);
			string? input = Console.ReadLine();

			if (int.TryParse(input, out int result))
			{
				if (result > 0)
				{
					return result;
				}
			}

			return 0;
		}
	}
}
