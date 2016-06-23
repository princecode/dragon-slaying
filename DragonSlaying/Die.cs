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
            
            NumberOfSides = numberOfSides;
            random = new Random(); 
            
        }

        /// <summary>
        /// Rolls the die.
        /// </summary>
        /// <returns>A random number between 1 and <see cref="NumberOfSides"/></returns>
        public int Roll()
        {           
          
            //Random random = new Random();
            //int dieRoll = random.Next(21); <--- wrong, still would include 0
            return random.Next(1, NumberOfSides + 1); // could also be simply written as random.Next(NumberOfSides) + 1  ---- the 1 in "()" sets the min value for range but still doesnt account for 1 less than max value entered
            
        }
    }
}
