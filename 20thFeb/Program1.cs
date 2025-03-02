using System;
using System.IO;

class FileHandlingExample{
	static void Main(){
		string sourceFilePath = "source.txt";
		string destinatioFilePath = "destination.txt";
		
		try{
			// check if the source file exists
			if(!File.Exists(sourceFilePath)){
				Console.WriteLine("Error: Source file does not exists");
				return;
			}
			
			// open FileStream for reading
			using (FileStream fsRead = new FileStream(sourceFilePath,FileMode.Open,FileAccess.Read))
			using (StreamReader reader = new StreamReader(fsRead)){
				string content = reader.ReadToEnd();
				
				// open filestream for writing
				using (FileStream fsWrite = new FileStream(destinatioFilePath,FileMode.Create,FileAccess.Write))
				using (StreamWriter writer = new StreamWriter(fsWrite)){
					writer.Write(content);
				}
			}
			Console.WriteLine("File copied successfully");
		}
		catch(IOException ex){
			Console.WriteLine("An I/O error occured: "+ex.Message);
		}
		catch(Exception ex){
			Console.WriteLine("An unexpected error occured: "+ex.Message);
		}
	}
}