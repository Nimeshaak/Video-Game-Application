using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PDSA_Game
{
    public class matrixnode
    {
        public string Name;
        public List<Edge> Edges = new List<Edge>();

        public matrixnode(string name)
        {
            Name = name;
        }

        public matrixnode AddEdge(matrixnode child, int w)
        {
            Edges.Add(new Edge
            {
                Parent = this,
                Child = child,
                Weigth = w
            });
            if (!child.Edges.Exists(a => a.Parent == child && a.Child == this))
            {
                child.AddEdge(this, w);
            }

            return this;

        }

    }


}
