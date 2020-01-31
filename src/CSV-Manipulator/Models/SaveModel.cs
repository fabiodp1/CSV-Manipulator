using System;
using System.IO;

namespace CSV_Manipulator.Models
{
	public class SaveModel
	{
		public string JsonString { get; set; }

		public void OnSet()
		{
			// defining a file to write to
			string jsonFile = Path.Combine (Environment.CurrentDirectory, "new-csv.json");

			// create a json file and return a helper writer
			StreamWriter json = File.CreateText(jsonFile);
			json.WriteLine(JsonString);

			// release resources
			json.Close();
		}


	}
}
