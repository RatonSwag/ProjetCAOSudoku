using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetCAOSudoku.Ressources
{
    class Tile
    {
        public int? answer { get; set; }
        public bool isValid { get; set; }
        //pubblic List<Comment>

        public Tile() 
        {
            this.answer = null;
            this.isValid = true;
        }

        public Tile(int answer)
        {
            this.answer = answer;
            this.isValid = true;
        }
    }
}
