using System.Collections.Generic;
public partial class Solution
{
    public string SimplifyPath(string path)
    {
        path += '/';//促使最后一个路径被处理
        List<string> directory = new List<string>();
        string dirNameCache = "";
        foreach (var i in path)
        {
            switch (i)
            {
                case '/':
                    if (dirNameCache.Length == 0) { break; }
                    else if (dirNameCache == ".") { dirNameCache = ""; break; }
                    else if (dirNameCache == "..") { if (directory.Count > 0) { directory.RemoveAt(directory.Count - 1); } dirNameCache = ""; break; }
                    else { directory.Add(dirNameCache); dirNameCache = ""; break; }
                default:
                    dirNameCache += i; break;
            }
        }
        if (directory.Count == 0) { return "/"; }
        else
        {
            dirNameCache = "";
            foreach (var i in directory)
            {
                dirNameCache += $"/{i}";
            }
            return dirNameCache;
        }

    }
}