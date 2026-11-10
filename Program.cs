// raylib boilerplate, will work on the main game design first

using Raylib_cs;

class Program
{
    static void Main()
    {
        Raylib.InitWindow(800, 600, "Boilerplate");
        Raylib.SetTargetFPS(60);

        float playerX = 400;
        float playerY = 300;
        float speed = 400.0f;

        while (!Raylib.WindowShouldClose())
        {
            float delta = Raylib.GetFrameTime();

            if (Raylib.IsKeyDown(KeyboardKey.Left) || Raylib.IsKeyDown(KeyboardKey.A)) playerX -= speed * delta;
            if (Raylib.IsKeyDown(KeyboardKey.Right) || Raylib.IsKeyDown(KeyboardKey.D)) playerX += speed * delta;
            if (Raylib.IsKeyDown(KeyboardKey.Up) || Raylib.IsKeyDown(KeyboardKey.W)) playerY -= speed * delta;
            if (Raylib.IsKeyDown(KeyboardKey.Down) || Raylib.IsKeyDown(KeyboardKey.S)) playerY += speed * delta;

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.DarkGray);

            Raylib.DrawText("Use WASD or Arrow Keys to move the square!", 20, 20, 20, Color.LightGray);

            Raylib.DrawRectangle((int)playerX, (int)playerY, 40, 40, Color.Blue);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}