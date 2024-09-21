using System;

namespace MovieScript
{
  class Program
  {
    static void Main(string[] args)
    {
      string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

      int charPosition = script.IndexOf("Close");
      int length = "Close on".Length;
      string cameraDirections = script.Substring(charPosition,length);

      charPosition = script.IndexOf("a portrait");
      string sceneDescription = script.Substring(charPosition);

      cameraDirections = cameraDirections.ToUpper();

      sceneDescription = sceneDescription.ToLower();

      Console.WriteLine($"{cameraDirections}{sceneDescription}");
    }
  }
}
