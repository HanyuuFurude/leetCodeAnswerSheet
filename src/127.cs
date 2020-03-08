using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        List<string> wList = new List<string>();
        bool[] visited = new bool[wordList.Count + 1];
        wList.Add(beginWord);
        foreach(var i in wordList)
        { wList.Add(i); }
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
        for (var i = 0; i < wList.Count; ++i)
        { graph.Add(new List<int>()); }
        for (var i = 0; i < wList.Count; ++i)
        {
            for (var j = i; j < wList.Count; ++j)
            {
                if (IsNabour(wList[i], wList[j]))
                { graph[i].Add(j); graph[j].Add(i); }
            }
        }
        int pathLenght = 1, target = wList.IndexOf(endWord);
        List<int> layer = new List<int>();
        layer.Add(wList.IndexOf(beginWord));
        visited[wList.IndexOf(beginWord)] = true;
        while (!layer.Contains(target))
        {
            if(layer.Count==0)
            { return 0; }
            List<int> nextlayer = new List<int>();
            foreach(var i in layer)
            {
                foreach(var j in graph[i])
                {
                    if(visited[j]==false)
                    {
                        nextlayer.Add(j);
                        visited[j] = true;
                    }
                }
            }
            layer = nextlayer; ++pathLenght;
        }
        return pathLenght;
    }
}