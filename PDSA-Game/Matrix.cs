using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PDSA_Game
{
    public class Matrix
    {
        public matrixnode Root;
        public List<matrixnode> AllNodes = new List<matrixnode>();


        public matrixnode CreateRoot(string name)
        {
            Root = Creatematrixnode(name);
            return Root;
        }

        public matrixnode Creatematrixnode(string name)  //a,b,c
        {
            var n = new matrixnode(name);
            AllNodes.Add(n);
            return n;
        }

        public int[,] CreatedjkMatrix()
        {
            int[,] djk = new int[AllNodes.Count, AllNodes.Count];

            for (int i = 0; i < AllNodes.Count; i++)
            {
                matrixnode n1 = AllNodes[i];

                for (int j = 0; j < AllNodes.Count; j++)
                {
                    matrixnode n2 = AllNodes[j];

                    var arc = n1.Edges.FirstOrDefault(a => a.Child == n2);

                    if (arc != null)
                    {
                        djk[i, j] = arc.Weigth;
                    }
                }
            }

            return djk; 

        }
    }
}
