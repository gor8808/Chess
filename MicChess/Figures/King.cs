using System.Collections.Generic;

namespace MicChess
{
    public class King
    {
        private int[,] Coordinate = ChessBoard.Coordinate;
        readonly List<(int, int)> AvalibleSteps = new List<(int, int)>();
        public int Color { get; set; }
        
        public List<(int, int)> Step(int XCoordinate, int YCoordinate)
        {
            if (XCoordinate + 1 < 8 && Coordinate[XCoordinate,YCoordinate] == 0)
            {
                AvalibleSteps.Add((XCoordinate + 1, YCoordinate));
            }
            if (XCoordinate + 1 < 8 && YCoordinate + 1 < 8 && Coordinate[XCoordinate, YCoordinate] == 0)
            {
                AvalibleSteps.Add((XCoordinate + 1, YCoordinate +  1));
            }
            if (YCoordinate + 1 < 8 && Coordinate[XCoordinate, YCoordinate] == 0)
            {
                AvalibleSteps.Add((XCoordinate, YCoordinate +  1));
            }
            if (XCoordinate - 1 > 0 && YCoordinate + 1 < 8 && Coordinate[XCoordinate, YCoordinate] == 0) 
            {
                AvalibleSteps.Add((XCoordinate - 1, YCoordinate + 1));
            }
            if (XCoordinate - 1 > 0 && Coordinate[XCoordinate, YCoordinate] == 0) 
            {
                AvalibleSteps.Add((XCoordinate - 1, YCoordinate));
            }
            if (XCoordinate - 1 > 0 && YCoordinate - 1 > 0 && Coordinate[XCoordinate, YCoordinate] == 0) 
            {
                AvalibleSteps.Add((XCoordinate - 1, YCoordinate - 1));
            }
            if (YCoordinate - 1 > 0 && Coordinate[XCoordinate, YCoordinate] == 0) 
            {
                AvalibleSteps.Add((XCoordinate, YCoordinate - 1));
            }
            if (YCoordinate + 1 < 8 && YCoordinate - 1 > 0 && Coordinate[XCoordinate, YCoordinate] == 0) 
            {
                AvalibleSteps.Add((XCoordinate + 1, YCoordinate - 1));
            }
            return AvalibleSteps;
        }
    }
}
