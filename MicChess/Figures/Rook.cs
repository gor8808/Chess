using System.Collections.Generic;

namespace MicChess
{
    public class Rook
    {
        private int[,] Coordinate = ChessBoard.Coordinate;
        public int Color { get; set; }

        readonly List<(int, int)> AvalibleSteps = new List<(int, int)>();

        public List<(int, int)> Step(int XCoordinate, int YCoordinate)
        {
            for (int i = 7; i >= 0; i--)
            {
                if (XCoordinate == i || Coordinate[i,YCoordinate] != 0)  {   }
                else
                    AvalibleSteps.Add((i, YCoordinate));
                if (YCoordinate == i || Coordinate[XCoordinate, i] != 0)   {   }
                else 
                    AvalibleSteps.Add((XCoordinate, i));
            }
            return AvalibleSteps;
        }
    }
}
