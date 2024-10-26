using System;

namespace Properties
{
  public class Forest
  {
    private string name;
    public string Name
    {
      get {
        return name;
      }
      set {
        name = value;
      }
    }

    public int trees;
    public int age;

    private string biome;
    public string Biome
    {
      get {
        return biome;
      }
      set {
        string[] validBiomes = {"Tropical", "Temperate", "Boreal"};
        if (Array.IndexOf(validBiomes, value) => 0) {
          biome = value;
        }
        else {
          biome = "Unknown";
        }
      }
    }
  }
