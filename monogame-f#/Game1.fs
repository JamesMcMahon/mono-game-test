﻿module Game

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics
open Microsoft.Xna.Framework.Input

type Game1() as x =
    inherit Game()

    do x.Content.RootDirectory <- "Content"
    let graphics = new GraphicsDeviceManager(x)

    let mutable spriteBatch =
        Unchecked.defaultof<SpriteBatch>

    override x.Initialize() =

        spriteBatch <- new SpriteBatch(x.GraphicsDevice)
        base.Initialize()

        // TODO: Add your initialization logic here

        ()

    override x.LoadContent() =

        // TODO: use x.Content to load your game content here
        // On Windows you can load any PNG file directly as Texture2D

        // Read more about MonoGame's Content Pipeline: https://docs.monogame.net/articles/tools/mgcb_editor.html
        // or install it with package manager console: [dotnet tool install -g dotnet-mgcb-editor]

        ()

    override x.Update(gameTime) =
        if
            GamePad.GetState(PlayerIndex.One).Buttons.Back = ButtonState.Pressed
            || Keyboard.GetState().IsKeyDown(Keys.Escape)
        then
            x.Exit()


        // TODO: Add your update logic here

        ``base``.Update(gameTime)

        ()

    override x.Draw(gameTime) =

        x.GraphicsDevice.Clear Color.CornflowerBlue

        // TODO: Add your drawing code here

        ``base``.Draw(gameTime)

        ()
