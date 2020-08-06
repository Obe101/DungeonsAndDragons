using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons
{
    public class CharStat
    {
        // All stats are in range (8 - 20) inclusive 

        /// <summary>
        /// The reference ID for individual created characters
        /// </summary>
        public int CharacterId { get; set; }


        /// <summary>
        /// Strength measures your character's 
        /// muscle and physical power 
        /// </summary>
        public int Strength { get; set; }

        /// <summary>
        /// Dexterity encompasses a number of physical 
        /// attributes including hand-eye 
        /// coordination, agility, reflexes, 
        /// fine motor skills, balance and speed of movement
        /// </summary>
        public int Dexterity { get; set; }

        /// <summary>
        /// Constitution represents a character's 
        /// health, stamina, and vital force
        /// </summary>
        public int Constitution { get; set; }

        /// <summary>
        /// Intelligence measures 
        /// mental acuity, accuracy of recall, 
        /// and the ability to reason
        /// </summary>
        public int Intelligence { get; set; }


        /// <summary>
        /// While Intelligence represents one’s ability
        /// to analyze information, Wisdom represents 
        /// being in tune with and aware of one’s surroundings
        /// </summary>
        public int Wisdom { get; set; }


        /// <summary>
        /// Charisma measures a character's force of 
        /// personality, persuasiveness, personal magnetism,
        /// and ability to lead. This ability represents 
        /// actual strength of personality, not merely 
        /// how one is perceived by others in a social setting
        /// </summary>
        public int Charisma { get; set; }
    }
}
