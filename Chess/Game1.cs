using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Chess
{
    using ContentService = ContentService<ContentEnum>;
    enum ContentEnum
    {
        BlackBishop,
        BlackKnight,
        BlackKing,
        BlackPawn,
        BlackQueen,
        BlackRook,
        WhiteBishop,
        WhiteKnight,
        WhiteKing,
        WhitePawn,
        WhiteQueen,
        WhiteRook,
        
    }

    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        ScreenManager screenManager;

        Texture2D pixel;
        Vector2 position;
        Sprite square;
        Sprite[,] board = new Sprite[8,8]; 

        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;


        }

        protected override void Initialize()
        {
             // TODO: Add your initialization logic here
            graphics.PreferredBackBufferHeight = 1024;
            graphics.PreferredBackBufferWidth = 1024;
            graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            ContentService.Instance.LoadContentFonts(Content, "Black Bishop", ContentEnum.BlackBishop);
            ContentService.Instance.LoadContentFonts(Content, "Black King", ContentEnum.BlackKing);
            ContentService.Instance.LoadContentFonts(Content, "Black Knight", ContentEnum.BlackKnight);
            ContentService.Instance.LoadContentFonts(Content, "Black Pawn", ContentEnum.BlackPawn);
            ContentService.Instance.LoadContentFonts(Content, "Black Queen", ContentEnum.BlackQueen);
            ContentService.Instance.LoadContentFonts(Content, "Black Rook", ContentEnum.BlackRook);
            ContentService.Instance.LoadContentFonts(Content, "White Bishop", ContentEnum.WhiteBishop);
            ContentService.Instance.LoadContentFonts(Content, "White King", ContentEnum.WhiteKing);
            ContentService.Instance.LoadContentFonts(Content, "White Knight", ContentEnum.WhiteKnight);
            ContentService.Instance.LoadContentFonts(Content, "White Pawn", ContentEnum.WhitePawn);
            ContentService.Instance.LoadContentFonts(Content, "White Queen", ContentEnum.WhiteQueen);
            ContentService.Instance.LoadContentFonts(Content, "White Rook", ContentEnum.WhiteRook);



            spriteBatch = new SpriteBatch(GraphicsDevice);
            position = new Vector2(0, 0);
            // TODO: use this.Content to load your game content here
            
            pixel = new Texture2D(GraphicsDevice, 1, 1);
            pixel.SetData(new Color[] { Color.Black });
            square = new Sprite(pixel, position, null, Color.White, 0f, new Vector2(0, 0), new Vector2(100, 100), SpriteEffects.None, 0);
            Texture2D bishop = Content.Load<Texture2D>("b_bishop_png_128px");
        
        }

        protected override void Update(GameTime gameTime)
        {


            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            square.Draw(spriteBatch);
            /*
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    board[i, j].Draw(spriteBatch);
                    spriteBatch.Draw(pixel, board[i,j].SourceRectangle,  Color.White);
                }
            }
            */
            //spriteBatch.Draw();

            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}