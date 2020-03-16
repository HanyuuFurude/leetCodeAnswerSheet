/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;
    
    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }
    
    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/
using System;
using System.Collections.Generic;
using Graph;
using Number133;
public partial class Solution
{
    public Node CloneGraph(Node node)
    {
        var demo = new C(node);
        return demo.res;
    }
}
namespace Number133
{
    public class C
    {
        public Dictionary<int, Node> existed;
        public Dictionary<int, Node> hosted = new Dictionary<int, Node>();
        public Node res;
        public C(Node src)
        {
            existed = new Dictionary<int, Node>();
            if (src == null) { return; }
            existed.Add(src.val, new Node(src.val));
            search(src);
            res = existed[src.val];
        }
        public void search(Node src)
        {
            if (!existed.ContainsKey(src.val))
            {
                existed.Add(src.val, new Node(src.val));
            }
            hosted.Add(src.val,src);
            foreach (var node in src.neighbors)
            {
                if (!existed.ContainsKey(node.val))
                {
                    existed.Add(node.val, new Node(node.val));
                }
                existed[node.val].neighbors.Add(existed[src.val]);
                existed[src.val].neighbors.Add(existed[node.val]);
                if (!hosted.ContainsKey(node.val))
                {
                    search(node);
                }
            }
        }

    }
}