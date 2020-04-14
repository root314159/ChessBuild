﻿using ChessBuildPieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBuildStones
{
    public class Bishop : Piece,IPiece
    {
        public Bishop() :base()
        {

        }
        public void CheckSquare()
        {
            int coordinateX = Square.Coordinate.X;
            int coordinateY = Square.Coordinate.Y;
            AvailableSquares.Clear();

            int i = 0;
            while (coordinateX + i < (int)Boards.upperLimit && coordinateY + i < (int)Boards.upperLimit)
            {
                i++;
                if (!PickSquare(coordinateX + i, coordinateY + i))
                    break;
            }

            int j = 0;
            while (coordinateX - j > (int)Boards.lowerLimit && coordinateY + j < (int)Boards.upperLimit)
            {
                j++;
                if (!PickSquare(coordinateX - j, coordinateY + j))
                    break;
            }

            int k = 0;
            while (coordinateX - k > (int)Boards.lowerLimit && coordinateY - k > (int)Boards.lowerLimit)
            {
                k++;
                if (!PickSquare(coordinateX - k, coordinateY - k))
                    break;
            }

            int m = 0;
            while (coordinateX + m < (int)Boards.upperLimit && coordinateY - m > (int)Boards.lowerLimit)
            {
                m++;
                if (!PickSquare(coordinateX + m, coordinateY - m))
                    break;
            }
        }

        public void SetPiece()
        {
            foreach (var square in Board.AllSquares)
            {
                if ((square.Coordinate.X == 3 && square.Coordinate.Y == 1) || (square.Coordinate.X == 6 && square.Coordinate.Y == 1))
                {
                    square.Piece = new Bishop() { Color = Color.white, ImageURL = Constant.whiteBishopImageURL,Square=square };
                    Board.WhitePieces.Add(square.Piece);
                }
                if ((square.Coordinate.X == 3 && square.Coordinate.Y == 8) || (square.Coordinate.X == 6 && square.Coordinate.Y == 8))
                {
                    square.Piece = new Bishop() { Color = Color.black, ImageURL = Constant.blackBishopImageURL,Square=square };
                    Board.BlackPieces.Add(square.Piece);
                }
            }
        }
    }
}
