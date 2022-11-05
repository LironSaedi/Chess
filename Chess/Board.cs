using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Chess
{
    using static Constants;
    class Board
    {
        enum Turn
        {
            Player1,
            Player2
        }
        enum ChessColor
        {
            Black,
            White
        }

        Button whites;
        Button blacks;

        Sprite[,] grid;

        Pieces[,] board;
        public Pieces LastPieceMoved;

        public Board()
        {
            Texture2D gridSquares = ContentService<ContentEnum>.Instance.Textures[ContentEnum.];
            grid = new Sprite[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Rectangle rect = new Rectangle(j * tilesize, i * tilesize, tilesize, tilesize);
                    grid[i, j] = new Sprite(gridSquares, rect, Color.DarkGray);
                    if ((i + j) % 2 == 0) grid[i, j].Color = Color.White;
                }
            }


        }
    }
}