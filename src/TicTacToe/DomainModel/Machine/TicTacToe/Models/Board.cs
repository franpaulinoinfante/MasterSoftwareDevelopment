using System.Diagnostics;
using TicTacToe.ConsolesIO;
using TicTacToe.Types;

namespace TicTacToe.Models
{
    internal class Board
    {
        private readonly Token[,] _tokens;

        public Board()
        {
            _tokens = new Token[Coordinate.DIMENSION, Coordinate.DIMENSION];
            NewGame();
        }

        internal void NewGame()
        {
            for (int i = 0; i < Coordinate.DIMENSION; i++)
            {
                for (int j = 0; j < Coordinate.DIMENSION; j++)
                {
                    _tokens[i, j] = Token.NULL;
                }
            }
        }

        internal bool IsOccupied(Coordinate coordinate, Token token)
        {
            Debug.Assert(coordinate != null);

            return _tokens[coordinate.Row, coordinate.Colunm] == token;
        }

        internal void PutToken(Coordinate coordinate, Token token)
        {
            Debug.Assert(coordinate != null);

            _tokens[coordinate.Row, coordinate.Colunm] = token;
        }

        internal void MoveToken(Coordinate origin, Coordinate target)
        {
            Debug.Assert((origin != null) && (!IsOccupied(origin, Token.NULL)));
            Debug.Assert((target != null) && IsOccupied(target, Token.NULL));
            Debug.Assert(!origin.Equals(target));

            Token token = GetToken(origin);
            PutToken(origin, Token.NULL);
            PutToken(target, token);
        }

        private Token GetToken(Coordinate coordinate)
        {
            return _tokens[coordinate.Row, coordinate.Colunm];
        }

        internal bool IsTicTacToe(Token token)
        {
            Debug.Assert(token != Token.NULL);

            List<Direction> directions = GetDirection(token);
            if (directions.Count < Coordinate.DIMENSION - 1)
            {
                return false;
            }
            for (int i = 0; i < directions.Count - 1; i++)
            {
                if (directions[i] != directions[i + 1])
                {
                    return false;
                }
            }
            return directions[0] != Direction.NULL;
        }

        private List<Direction> GetDirection(Token token)
        {
            Debug.Assert(token != Token.NULL);

            List<Coordinate> coordinates = GetCoordinates(token);
            List<Direction> directions = new List<Direction>();
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
                    if (GetToken(new Coordinate(i, j)) == token)
                    {
                        coordinates.Add(new Coordinate(i, j));
                    }
                }
            }
            return coordinates;
        }

        internal void Write()
        {
            Message message = new Message(MessageType.HORIZONTAL_LINE);
            message.WriteLine();
            for (int i = 0; i < Coordinate.DIMENSION; i++)
            {
                message.Write(MessageType.VERTICAL_LINE);
                for (int j = 0; j < Coordinate.DIMENSION; j++)
                {
                    ConsoleIO.GetInstance().Write(new TokenType().ToString(_tokens[i, j]));
                    message.Write(MessageType.VERTICAL_LINE);
                }
                ConsoleIO.GetInstance().WriteLine();
            }
            message.WriteLine(MessageType.HORIZONTAL_LINE);
        }
    }
}