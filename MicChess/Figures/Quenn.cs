using System.Collections.Generic;

namespace MicChess
{
    public class Quenn
    {
        private int[,] Coordinate = ChessBoard.Coordinate;
        public int Color { get; set; }

        readonly List<(int, int)> AvalibleSteps = new List<(int, int)>();

        public List<(int, int)> Step(int XCoordinate, int YCoordinate)
        {
            for (int i = 7; i >= 0; i--)
            {
                if (XCoordinate == i - 1 || Coordinate[i, YCoordinate] != 0) { }
                else
                    AvalibleSteps.Add((i, YCoordinate));
                if (YCoordinate == i || Coordinate[XCoordinate, i] != 0) { }
                else
                    AvalibleSteps.Add((XCoordinate, i));
                if(i == 0)
                    continue;
                else 
                {
                    if (XCoordinate + i < 8 && YCoordinate + i < 8 && Coordinate[XCoordinate + i, YCoordinate + i] == 0)
                        AvalibleSteps.Add((XCoordinate + i, YCoordinate + i));
                    if (XCoordinate + i < 8 && YCoordinate - i >= 0 && Coordinate[XCoordinate + i, YCoordinate - i] == 0)
                        AvalibleSteps.Add((XCoordinate + i, YCoordinate - i));
                    if (XCoordinate - i >= 0 && YCoordinate + i < 8 && Coordinate[XCoordinate - i, YCoordinate + i] == 0)
                        AvalibleSteps.Add((XCoordinate - i, YCoordinate + i));
                    if (XCoordinate - i >= 0 && YCoordinate - i >= 0 && Coordinate[XCoordinate - i, YCoordinate - i] == 0)
                        AvalibleSteps.Add((XCoordinate - i, YCoordinate - i));
                }
            }
            return AvalibleSteps;
        }
    }
}
