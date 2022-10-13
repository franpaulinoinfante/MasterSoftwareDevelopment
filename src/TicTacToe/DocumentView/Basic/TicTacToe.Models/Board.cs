﻿using System.Diagnostics;
using TicTacToe.Types;
using TicTacToe.Utils.Coordinates;

namespace TicTacToe.Models
{
    internal class Board
    {
        private readonly Token[,] _tokens;

        public Board()
        {
            _tokens = new Token[Coordinate.DIMENSION, Coordinate.DIMENSION];
            Reset();
        }

        internal void Reset()
        {
            for (int i = 0; i < Coordinate.DIMENSION; i++)
            {
                for (int j = 0; j < Coordinate.DIMENSION; j++)
                {
                    _tokens[i, j] = Token.NULL;
                }
            }
        }

        internal bool IsComplete(Token token)
        {
            int count = 0;
            for (int i = 0; i < Coordinate.DIMENSION; i++)
            {
                for (int j = 0; j < Coordinate.DIMENSION; j++)
                {
                    if (IsOccupied(new Coordinate(i, j), token))
                    {
                        count++;
                    }
                }
            }
            return count == Coordinate.DIMENSION;
        }

        private bool IsOccupied(Coordinate coordinate, Token token)
        {
            return _tokens[coordinate.Row, coordinate.Column] == token;
        }

        internal void PutToken(Coordinate coordinate, Token token)
        {
            Debug.Assert(coordinate != null);

            _tokens[coordinate.Row, coordinate.Column] = token;
        }

        internal ErrorCode GetErrorCodeToPut(Coordinate coordinate)
        {
            if (!IsEmpty(coordinate))
            {
                return ErrorCode.NOT_EMPTY;
            }
            return ErrorCode.NULL;
        }

        internal bool IsEmpty(Coordinate coordinate)
        {
            return IsOccupied(coordinate, Token.NULL);
        }

        internal void Move(Coordinate origin, Coordinate target)
        {
            Debug.Assert(origin.IsNull() && (!IsEmpty(origin)));
            Debug.Assert(target.IsNull() && IsEmpty(target));
            Debug.Assert(!origin.Equals(target));

            Token token = GetColor(origin);
            PutToken(origin, token);
            PutToken(target, token);
        }

        private Token GetColor(Coordinate origin)
        {
            Debug.Assert(!origin.IsNull());

            return _tokens[origin.Row, origin.Column];
        }

        internal ErrorCode GetErrorCodeToMoveTarget(Coordinate origin, Coordinate target)
        {
            if (origin.Equals(target))
            {
                return ErrorCode.SAME_COORDINATES;
            }
            if (!IsEmpty(target))
            {
                return ErrorCode.NOT_EMPTY;
            }
            return ErrorCode.NULL;
        }

        internal bool IsticTacToe(Token token)
        {
            Debug.Assert(token != Token.NULL);

            List<Direction> directions = GetDirections(token);
            for (int i = 0; i < directions.Count; i++)
            {
                if (directions[i] != directions[i + 1])
                {
                    return false;
                }
            }
            return directions[0] != Direction.NULL;
        }

        private List<Direction> GetDirections(Token token)
        {
            Debug.Assert(token != Token.NULL);

            List<Direction> directions = new List<Direction>();
            List<Coordinate> coordinates = GetCoordinates(token);
            if (coordinates.Any())
            {
                for (int i = 0; i < coordinates.Count - 1; i++)
                {
                    directions.Add(coordinates[i].GetDirection(coordinates[i + 1]));
                }
            }
            return directions;
        }

        private List<Coordinate> GetCoordinates(Token token)
        {
            Debug.Assert(token != Token.NULL);

            List<Coordinate> coordinates = new List<Coordinate>();
            for (int i = 0; i < Coordinate.DIMENSION; i++)
            {
                for (int j = 0; j < Coordinate.DIMENSION; j++)
                {
                    if (GetColor(new Coordinate(i, j)) == token)
                    {
                        coordinates.Add(new Coordinate(i, j));
                    }
                }
            }

            return coordinates;
        }
    }
}