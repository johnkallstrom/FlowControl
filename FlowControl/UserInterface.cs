namespace FlowControl
{
	internal static class UserInterface
	{
		public static void CreateMenu(string[] options)
		{
			Console.WriteLine();

			foreach (var option in options)
			{
				Console.WriteLine(option);
			}

			Console.WriteLine();
		}

		public static void CreateMenu(string title, string description, string[] options)
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

		public static void Text(string content) => Console.WriteLine(content);

		public static void TextWithTrailingDots(string content)
		{
			Console.Write(content);
			for (int i = 1; i <= 3; i++)
			{
				Console.Write($".");
				Thread.Sleep(1000);
			}
		}

		public static void Space() => Console.WriteLine();

		public static void Clear() => Console.Clear();
	}
}
