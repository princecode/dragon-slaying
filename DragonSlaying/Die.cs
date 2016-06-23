using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlaying
{
    public class Die
    {
        Random random;
        public int NumberOfSides { get; set; }

        /// <summary>
        /// Constructs a 6-sided Die.
        /// </summary>
        public Die() : this(6)
            // says take this objects constructor and input 6 as the value
        {
        }

        /// <summary>
        /// Constructs a Die with the specified number of sides.
        /// </summary>
        /// <param name="numberOfSides">The number of sides on the Die</param>
        public Die(int numberOfSides)
        {
            // TODO - Done?
            NumberOfSides = numberOfSides;
           //numberOfSides = 20;
            
        }

        /// <summary>
        /// Rolls the die.
        /// </summary>
        /// <returns>A random number between 1 and <see cref="NumberOfSides"/></returns>
        public int Roll()
        {
            retunr 1;
            //TODO - Done?
            //Random random = new Random();
            //int dieRoll = random.Next(21);
            int dieRoll = random.Next(20) + 1; 
            
        }
    }
}
