namespace FlowControl
{
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

		public static void Text(string content) => Console.WriteLine(content);

		public static void Space() => Console.WriteLine();

		public static void Clear() => Console.Clear();
	}
}
