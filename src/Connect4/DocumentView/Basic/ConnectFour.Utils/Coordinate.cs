﻿namespace ConnectFour.Utils;

public class Coordinate
{
    public static int Rows = 6;
    public static int Colunms  = 7;

    private int _row;
    private int _column;

    public Coordinate()
    {
    }

    public Coordinate(int row, int column)
    {
        _row = row;
        _column = column;
    }

    public int Row { get => _row; set => _row = value; }
    public int Column { get => _column; set => _column = value; }

    public bool IsValid()
    {
        return new ClosedInterval(Coordinate.Rows, Coordinate.Colunms).IsValid(_row) && new ClosedInterval(Coordinate.Rows, Coordinate.Colunms).IsValid(_column);
    }

    public bool IsValid(int value)
    {
        return new ClosedInterval(min: 0, Coordinate.Colunms - 1).IsValid(value);
    }


}
