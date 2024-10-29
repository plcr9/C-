using System;

namespace StaticFields
{
  public class Forest
  {
    public string Name
    { get; set; }

    public int Trees
    { get; set; }

    private int age;
    public int Age
    {
      get { return age; }
      private set {
        if (value < 0)
        {
          age = 0;
        }
        else 
        {
          age = value;
        }
      }
    }

    private string biome;
    public string Biome
    {
      get { return biome; }
      set
      {
        string[] validBiomes = {"Tropical", "Temperate", "Boreal"};
        if (Array.IndexOf(validBiomes, value) >= 0)
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }

    public static int ForestsCreated {
      get; private set;
    }

    public Forest (string name, string biome)
    {
      Name = name;
      Biome = biome;
      Age = 0;
      ForestsCreated++;
    }

    public Forest(string name) : this(name, "Unknown")
    { }

    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }

    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }

  }
}





          
