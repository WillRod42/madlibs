using System;
using System.Collections.Generic;

namespace MadLibs.Models
{
  public class MadLib
  {
    public string[] Words { get; }
    private int _index;
    public MadLib(int numWords) 
    {
      Words = new string[numWords];
      _index = 0;
    }

    public void addWord(string word)
    {
      Words[_index] = word;
      _index++;
    }
  }
}
