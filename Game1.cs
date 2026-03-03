using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using AbraxasGameLibrary;

namespace abraxasengine2mono;

public class Game1 : Core
{
    // Esta clase es la equivalente de GamePanel.java en la raiz del proyecto
    // Para correr el proyecto, tiene que ser 
    // Mejor aprendemos la wea bien: https://docs.monogame.net/articles/tutorials/building_2d_games/04_creating_a_class_library/index.html?tabs=vscode

    private Texture2D _logo;

    public Game1() : base("Abraxas Engine II", 1280, 720, false)
    {

    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _logo = Content.Load<Texture2D>("images/logo");     // Si esta wea no funciona, hay que revisar la ruta en las propiedades del Content.mgcb!
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

        SpriteBatch.Begin();
        SpriteBatch.Draw(_logo, Vector2.Zero, Color.White);
        SpriteBatch.End();

        base.Draw(gameTime);
    }
}
