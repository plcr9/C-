using System;

namespace DNA
{
  class Program
  {
    static void Main(string[] args)
    {
      string startStrand = "ATGCGATGAGCTTAC";

      int tgo = startStrand.IndexOf("TGA");

      int startPoint = 0;
      int length = tgo + 3;

      string dna = startStrand.Substring(startPoint, length);
      Console.WriteLine(dna);

      Console.WriteLine(dna[3]);
    }
  }
}
