namespace FlowControl
{
	// En wrapper runt System.Console för att lättare skriva ut text, menyer, mellanrum och rensa konsollen
	internal static class UI
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

		public static void Text(string content, bool newline = true)
		{
			if (newline) Console.WriteLine(content);
			else Console.Write(content);
        }

		public static void Space() => Console.WriteLine();

		public static void Clear() => Console.Clear();
	}
}
