using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetCAOSudoku.Ressources
{
    class Board
    {
        const int GridSize = 9;
        private Tile[][] grid;
        //private Box[,] grid;

        public Board()
        {
            grid = new Tile[GridSize][];
            for(int ctr = 0; ctr < GridSize; ctr++)
            {
                grid[ctr] = new Tile[GridSize];
            }
            //grid = new Box[3, 3];­­
        }

        public void setAnswerAt(int indexRow, int indexColumn, int answer)
        {
            if (answer > 0 && answer <= GridSize)
                grid[indexRow][indexColumn].answer = answer;
        }

        public void checkLine(int index)
        {
            Tile[] line = grid[index];
            //bool validLine = true;


            foreach(Tile t in line)
            {
                if(t.answer != null && line.Count(x => x.answer == t.answer) > 1)
                {
                    //validLine = false;
                    t.isValid = false;
                }
                else
                {
                    t.isValid = true;
                }
            }

            //return validLine;
        }

        public void checkColumn(int index)
        {
            Tile[] column = new Tile[GridSize];

            for(int ctr = 0; ctr < grid.Count(); ctr++)
            {
                column[ctr] = grid[ctr][index];                      
            }

            foreach (Tile t in column)
            {
                if (t.answer != null && column.Count(x => x.answer == t.answer) > 1)
                {
                    //validLine = false;
                    t.isValid = false;
                }
                else
                {
                    t.isValid = true;
                }
            }

            //return validLine;
        }

        public void checkBox()
        {

        }
    }
}
