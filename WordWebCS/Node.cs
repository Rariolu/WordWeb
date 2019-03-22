using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordWebCS
{
    public class Node
    {
        Dictionary<string, Link> links = new Dictionary<string, Link>();
        public Link[] Links
        {
            get
            {
                return links.Values.ToArray();
            }
        }
        public Node[] Connotations
        {
            get
            {
                return links.Values.Select(l => l.A.Word == Word ? l.A : l.B).ToArray();
            }
        }
        public string[] ConnotationWords
        {
            get
            {
                return Connotations.Select(c => c.Word).ToArray();
            }
        }
        int id;
        public int ID
        {
            get
            {
                return id;
            }
        }
        static int count = 0;
        string _word;
        public string Word
        {
            get
            {
                return _word;
            }
        }
        Vector3 _position;
        public Vector3 Position
        {
            get
            {
                return _position;
            }
        }
        public Node(string word)
        {
            id = count++;
            _word = word;
            _position = Util.superRand.RandomVector3();
        }
        public void AddLink(string word, Link l)
        {
            links.Add(word, l);
        }
        public void Lerp(Vector3 pos)
        {
            _position.Lerp(pos, 0.01/links.Count);
        }
        public void Converge(Node n)
        {
            Vector3 oldPos = new Vector3(_position.X,_position.Y,_position.Z);
            if (!links.ContainsKey(n.Word))
            {
                Link l = new Link(this, n);
                links.Add(n.Word, l);
                n.AddLink(Word, l);
            }
            _position.Lerp(n.Position,0.01/links.Count);
            n.Lerp(oldPos);
        }
    }
}