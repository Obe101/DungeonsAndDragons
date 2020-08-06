using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons
{
    public class CharInfo
    {
        /// <summary>
        /// The reference ID for individual created characters
        /// </summary>
        public int CharacterId { get; set; }

        /// <summary>
        /// The name and/or user name of the human player
        /// Example: "Johnny Appleseed"
        /// </summary>
        public string PlayerName { get; set; }


        /// <summary>
        /// The (First, Middle, and/or Last) name of a single 
        /// player character 
        /// Example: "Brunor Steelbane"
        /// </summary>
        public string CharacterName { get; set; }

        /// <summary>
        /// Your class is the primary definition of what 
        /// your character can do 
        /// Example: "Wizard", "Bard", "Fighter, etc
        /// NOTE: Not to be confused with the programming term "class"
        /// </summary>
        public string Class { get; set; }


        /// <summary>
        /// As your character goes on adventures and overcomes 
        /// challenges, they gains levels
        /// Example: "Level 3" 
        /// </summary>
        public int Level { get; set; }


        /// <summary>
        /// Race is a rule in Dungeons & Dragons referring to the 
        /// fantasy species or ancestry of a character. Players are 
        /// generally free to select their character's skin tone, 
        /// hair color and other details of appearance as they see fit.
        /// Example: "Orc", "Human", "Tiefling"
        /// </summary>
        public string Race { get; set; }

        /// <summary>
        /// A bit of pre-created information about your character available
        /// from the background list in the Player's Handbook (or online).
        /// Example: "Soldier" , "Acolyte" , "Entertainer"
        /// </summary>
        public string Background { get; set; }

        /// <summary>
        /// Alignment is a categorization of the
        /// ethical and moral perspective of characters 
        /// Example: "Lawful Evil", "Neutral Good", "Chaotic Neutral"
        /// </summary>
        public string Alignment { get; set; }
    }
}
