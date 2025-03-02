using System;

class LegacyAPI{
	// Marking the method as obsolete with a warning message
	[Obsolete("OldFeature() is depredated, please use NewFeature() instead")]
	public void OldFeature(){
		Console.WriteLine("Executing old feature.");
	}
	
	public void NewFeature(){
		Console.WriteLine("Executing new feature.");
	}
}

class Program{
	static void Main(){
		LegacyAPI api = new LegacyAPI();
		
		// calling the obsolete method (this will generate a compile-time warning)
		api.OldFeature();
		
		// calling the new method
		api.NewFeature();
	}
}