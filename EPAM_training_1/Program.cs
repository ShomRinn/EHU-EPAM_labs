using System;

namespace EPAM_training_1
{
    class Program
    {
		static void Main(string[] args)
		{

			int a = 0;
			int max = 0;

			string b = Console.ReadLine();

		//	string s = new string("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard");

			for (int i = 0; i < b.Length - 1; i++)
			{

				if (b[i] == b[i + 1])
				{
					a++;

					if (a > max)
					{
						max = a + 1;
					}
				}
				else
                {
					a = 0;
                }
			}
			Console.WriteLine(max);


		}
	}
}
