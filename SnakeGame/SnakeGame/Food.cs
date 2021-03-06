using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    /// <summary>
    /// A class contating information about the food. Appearance and the outcome for when it is eaten
    /// </summary>
    public class Food : GameObject
    {
        /// <summary>
        /// Constructor that gives object its appearance and instance of Position
        /// </summary>
        /// <param name="startAppearance">The char instance that represents objects appearance</param>
        /// <param name="posX"> The int instance that represents objects position horizontally</param>
        /// <param name="posY"> The int instance that represents objects position vertically</param>
        public Food(char startAppearance, int posX, int posY) : base(startAppearance,posX,posY)
        {
            color = GetRandomConsoleColor();
        }
 
        public override void Update()
        {
            
        }
        /// <summary>
        /// Randomly generating colors and position for the food object
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// A method which randomly selects colors for the food
        /// </summary>
        /// <returns>A randomly genereted color is given</returns>
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(1,7));  
        }
        /// <summary> 
        /// The outcome for when the food is eaten. Random color is generated and a new random position is set
        /// </summary>
        public override void AteFood(int W, int H)
        {
            position.X = _random.Next(3,W-2);
            position.Y = _random.Next(3,H-2);
            color = GetRandomConsoleColor();
        }

    }
}
