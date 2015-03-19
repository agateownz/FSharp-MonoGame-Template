module Game

open System.Collections.Generic
open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics
open Microsoft.Xna.Framework.Input

type Game1() as this =
    inherit Game()

    do this.Window.Title <- "F# MonoGame"

    do this.Content.RootDirectory <- "Content"

    let graphics = new GraphicsDeviceManager(this)

    let mutable spriteBatch = Unchecked.defaultof<SpriteBatch>

    override this.Initialize() =
        // TODO: Add your initialization logic here
        base.Initialize()

    override this.LoadContent() =
        spriteBatch <- new SpriteBatch(this.GraphicsDevice)
        // TODO: Load your game content here
        base.LoadContent()

    override this.UnloadContent() =
        // TODO: Unload any non ContentManager content here
        base.UnloadContent()

    override this.Update(gameTime) =
        if GamePad.GetState(PlayerIndex.One).Buttons.Back = ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape) then
            this.Exit()
        // TODO: Add your update logic here
        base.Update(gameTime)

    override this.Draw(gameTime) =
        this.GraphicsDevice.Clear(Color.CornflowerBlue)
        // TODO: Add your drawing code here
        base.Draw(gameTime)



