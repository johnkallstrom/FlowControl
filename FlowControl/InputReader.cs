namespace FlowControl
{
	internal static class InputReader
	{
		public static string GetString(string msg = "")
		{
			while (true)
			{
				Console.Write(msg);
				string? input = Console.ReadLine();

				if (!string.IsNullOrWhiteSpace(input))
				{
					return input;
				}
			}
		}

		public static int GetInteger(string msg = "")
		{
			while (true)
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
			}
		}

		public static int GetInteger(int min, int max, string msg = "")
		{
			while (true)
			{
				Console.Write(msg);
				string? input = Console.ReadLine();

				if (int.TryParse(input, out int result))
				{
					if (result >= min && result <= max)
					{
						return result;
					}
				}
			}
		}
	}
}
