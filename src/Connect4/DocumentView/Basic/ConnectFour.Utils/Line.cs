using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.Utils;

public class Line
{
    public const int Length = 4;

    private Coordinate _origine;
    private Coordinate[] _coordinates;
    private Direction _oppositeDirection;

    public Line(Coordinate origine)
    {
        _origine = origine;
    }

    public Coordinate[] Coordinates => _coordinates;

    public Direction Direction
    {
        set
        {
            _coordinates = new Coordinate[Line.Length];
            _coordinates[0] = _origine;
            for (int i = 1; i < Line.Length; i++)
            {
                _coordinates[i] = _coordinates[i - 1].Shifted(value.Coordinate);
            }

            _oppositeDirection = value.OppositeDirection;
        }
    }

    public void Shift()
    {
        for (int i = 0; i < _coordinates.Length; i++)
        {
            _coordinates[i] = _coordinates[i].Shifted(_oppositeDirection.Coordinate);
        }
    }
}
