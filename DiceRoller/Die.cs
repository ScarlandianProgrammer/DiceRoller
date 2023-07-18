using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    /// <summary>
    /// This class makes an object that represents a single, six-sided die.
    /// </summary>
    public class Die
    {
        /// <summary>
        /// Sets the face value for the die on creation.
        /// </summary>
        public Die()
        {
            Roll();
        }
        /// <summary>
        /// The value of the die's current top side.
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// True it the die is held.
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rolls the die and sets the <see cref="FaceValue"> to the random number.
        /// </summary>
        /// <returns>Returns the new <see cref="FaceValue"/> </returns>
        public byte Roll()
        {
            Random random = new();
            byte newValue = (byte)random.Next(1, 7);
            FaceValue = newValue;
            return newValue;
        }
    }
}
