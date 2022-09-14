using System;
using System.Linq;
using System.Text;

namespace CountAndSay
{
	class Program
	{
		public static void Main(string[] args)
		{
			 var t = sequence(5);
			Console.WriteLine(t);
		}

		public static string sequence(int n)
		{
			if (n < 0)
			{
				return "";
			}
			string result = "1";
			while (n > 1)
			{
				StringBuilder temp = new StringBuilder();
				for (int i = 0; i < result.Length; ++i)
				{
					int count = 1;
					while (i + 1 < result.Length && result.ElementAt(i) == result.ElementAt(i + 1))
					{
						++count;
						++i;
					}
					temp.Append(count).Append(result.ElementAt(i));
				}
				result = temp.ToString();
				--n;
			}
			return result;
		}
	}
}
