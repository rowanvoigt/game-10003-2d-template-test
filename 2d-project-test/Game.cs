// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("This is a 2d test");
            Window.SetSize(800,800);
            Window.TargetFPS = 60;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Magenta);
            Color orange = new Color(255, 255, 255);
            Draw.FillColor = Color.Black;
            Draw.LineColor = orange;
            Draw.LineSize = 10;
            Vector2 rectanglePosition = new Vector2(300, 200);
            Vector2 rectangleSize = new Vector2(200, 100);
            Draw.Rectangle(Input.GetMousePosition() - rectangleSize/2, rectangleSize);
        }
    }

}
