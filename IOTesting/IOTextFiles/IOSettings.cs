using System;

namespace IOTextFiles
{
	public class IOSettings
	{
		private STable _stable;

		public IOSettings (STable stable)
		{
			_stable = stable;
		}

		public string getPath ()
		{
			string _path = System.IO.Path.Combine ( AppDomain.CurrentDomain.BaseDirectory, "test.txt" );

			//Други видове директории
			string _user = Environment.GetFolderPath( Environment.SpecialFolder.LocalApplicationData);
			Console.WriteLine ( _user );

			string _desktop = Environment.GetFolderPath( Environment.SpecialFolder.Desktop);
			Console.WriteLine (_desktop);

			return _path;
		}

		public bool save ()
		{
			try
			{
				string _temp = "";

				_temp = String.Join ( "\r\n", _stable.stable );

				//Запис на текстов файл
				System.IO.File.WriteAllText ( getPath (), _temp );

				return true;
			}catch{
			}

			return false;
		}

		public bool open ()
		{
			try
			{
				string _temp = System.IO.File.ReadAllText ( getPath () );

				string[] _table = _temp.Replace("\r", "").Split ('\n');

				for ( int i = 0; i < _table.Length; i++)
				{
					_stable.stable[i] = _table[i];
				}

				return true;
			}catch{
			}

			return false;
		}
	}
}

