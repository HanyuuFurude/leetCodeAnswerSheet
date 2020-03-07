using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        Func<string, string, bool> IsNabour = (a, b) =>
          {
              bool nabour = false;
              for (var i = 0; i < a.Length; ++i)
              {
                  if (a[i] != b[i])
                  {
                      if (nabour == false) { nabour = true; }
                      else { return false; }
                  }
              }
              return nabour;
          };
        List<IList<int>> graph = new List<IList<int>>();
        for (var i = 0; i < wordList.Count; ++i)
        { graph.Add(new List<int>()); }
        for (var i = 0; i < wordList.Count; ++i)
        {
            for (var j = i; j < wordList.Count; ++j)
            {
                if (IsNabour(wordList[i], wordList[j]))
                { graph[i].Add(j); graph[j].Add(i); }
            }
        }

        int res = 0;
        return res;
    }
}
namespace Number127
{
    public class C
    {

    }
}