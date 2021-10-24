using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetCAOSudoku.Ressources
{
    class Box
    {
        private Tile[][] box;

        public Box(Tile[][] grid) 
        {
            this.box = box;
        }

        public List<Tile> MatrixToList()
        {
            var list = new List<Tile>();
            /***
            foreach (Tile[] tArray in box)
            {
                foreach (Tile t in tArray)
                {
                    list.Add(t);
                }
            }
            ***/
            return list;
        }

        public List<Tile> GetLine(int line)
        {
            return box[line].ToList();
        }

        public List<Tile> GetColumn(int column)
        {
            var list = new List<Tile>();
            foreach (Tile[] t in box)
            {
                list.Add(t[column]);
            }

            return list;
        }
    }
}
