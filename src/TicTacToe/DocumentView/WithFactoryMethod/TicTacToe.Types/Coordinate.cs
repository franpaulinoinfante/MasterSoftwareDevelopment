﻿using System.Diagnostics;
using TicTacToe.Utils.Coordinates;

namespace TicTacToe.Types;

public class Coordinate : ConcreteCoordinate
{
    public static int DIMENSION = 3;

    private ICoordinate _adaptee;

    public Coordinate() : base()
    {
        NullCoordinate.GetInstante();
    }

    public Coordinate(ICoordinate coordinate)
    {
        _adaptee = coordinate;
    }

    public Coordinate(int row, int column) : base(row, column)
    {
        _adaptee = new ConcreteCoordinate(row, column);
        Debug.Assert(IsValid());
    }

    public new int Row
    {
        get
        {
            Debug.Assert(!_adaptee.IsNull());
            return ((ConcreteCoordinate)_adaptee).Row;
        }
    }

    public int Colunm
    {
        get
        {
            Debug.Assert(!_adaptee.IsNull());
            return ((ConcreteCoordinate)_adaptee).Column;
        }
    }

    public new bool IsNull()
    {
        return _adaptee.IsNull();
    }

    public bool IsValid()
    {
        Debug.Assert(!_adaptee.IsNull());

        ConcreteCoordinate coordinate = (ConcreteCoordinate)_adaptee;
        return GetLimits().IsIncluide(coordinate.Row) && GetLimits().IsIncluide(coordinate.Column);
    }

    public ClosedInterval GetLimits()
    {
        return new ClosedInterval(min: 0, Coordinate.DIMENSION - 1);
    }

    public Direction GetDirection(ConcreteCoordinate concreteCoordinate)
    {
        if (this.Equals(concreteCoordinate) || IsNull() || concreteCoordinate.IsNull())
        {
            return Direction.NULL;
        }
        if (InverseDiagonal())
        {
            return Direction.INVERSE_DIAGONAL;
        }
        return _adaptee.GetDirection(concreteCoordinate);
    }

    private bool InverseDiagonal()
    {
        ConcreteCoordinate coordinate = (ConcreteCoordinate)_adaptee;
        return coordinate.Row + coordinate.Column == Coordinate.DIMENSION - 1;
    }

    public void Random()
    {
        Random random = new Random(Timeout.InfiniteTimeSpan.Milliseconds);
        _adaptee = new ConcreteCoordinate(random.Next(Coordinate.DIMENSION), random.Next(Coordinate.DIMENSION));
    }
}
