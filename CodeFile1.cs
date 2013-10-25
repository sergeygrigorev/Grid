using System;
using System.Collections.Generic;

namespace Hello
{
	class MainClass
	{
		public static List<int[]> a;
		private static bool flag = false;
		public static int start, col1, col2;

		public static void init()
		{
			if (flag) return;
			flag = true;
			start = 0;
			col1 = 0;
			col2 = 0;
			a = new List<int[]>();
			Random r = new Random();
			int i, j;
			int[] b;

			for (i = 0; i < 10000; i++)
			{
				b = new int[5];
				for (j = 0; j < 5; j++)
					b[j] = r.Next(1000);
				a.Add(b);
			}
			a.Sort(new Comparison<int[]>(compareThem));
		}

		public static int compareThem(int[] a, int[] b)
		{
			if (a[col1] > b[col1])
				return 1;
			if (a[col1] < b[col1])
				return -1;
			if (a[col2] > b[col2])
				return 1;
			if (a[col2] < b[col2])
				return -1;
			return 0;
		}
	} 
}