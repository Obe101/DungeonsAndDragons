using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons
{
    class CharacterDB
    {
        public static List<CharInfo> GetAllCharacters()
        {

        }

        public static List<CharStat> GetAllCaracterStats()
        {

        }

        public static CharInfo Add(CharInfo c) 
        {
            CharacterContext context = new CharacterContext();
            context.Characters.Add(c);
            context.SaveChanges();
            return c;
        }

        public static CharStat Add(CharStat s)
        {
            CharacterContext context = new CharacterContext();
            context.Stats.Add(s);
            context.SaveChanges();
            return s;
        }
    }
}
