using System;

public class Class1
{
    string name;
	public Class1()
    {
        // For that you will need to add reference to System.Web.Helpers
        dynamic json = System.Web.Helpers.Json.Decode(@"{ ""Name"": ""Jon Smith"", ""Address"": { ""City"": ""New York"", ""State"": ""NY"" }, ""Age"": 42 }");
        Console.WriteLine(json.Name);
        name = json.Name;
        Console.WriteLine(json.Address.State);
    }
}
