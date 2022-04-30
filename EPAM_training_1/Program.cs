using System;

namespace EPAM_training_1
{
    class Program
    {
		static void Main(string[] args)
		{

			int a = 1;
			int max = 0;

			string b = Console.ReadLine();

		//	string s = new string("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsuffm has been the industry's standard");

			for (int i = 0; i < b.Length - 1; i++)
			{

				if (b[i] == b[i + 1])
				{
					a++;

					if (a > max)
					{
						max = a;
					}
				}
				else
                {
					a = 1;
                }
			}
			Console.WriteLine(max);


		}
	}
}
