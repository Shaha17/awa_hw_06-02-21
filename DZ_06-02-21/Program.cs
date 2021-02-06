using System;

namespace DZ_06_02_21
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] arr = new string[] { "ant", "bison", "camel", "duck", "elephant" };
			ArrayHelper<string>.Show(ArrayHelper<string>.Slice(arr, 2));
			ArrayHelper<string>.Show(ArrayHelper<string>.Slice(arr, 2, 4));
			ArrayHelper<string>.Show(ArrayHelper<string>.Slice(arr, 1, 5));
		}
	}
}
