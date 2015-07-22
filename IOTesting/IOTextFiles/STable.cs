using System;

namespace IOTextFiles
{
	public class STable
	{
		public string[] stable = new string[4];

		public STable ()
		{
			fillSTable ();
		}

		private void fillSTable ()
		{
			stable [0] = "1,0,5,0.4582";
			stable [1] = "2,5,10,0.4582";
			stable [2] = "3,10,15,0.4582";
			stable [3] = "4,15,20,0.4582";
		}
	}
}

