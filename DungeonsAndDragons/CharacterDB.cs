using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons
{
    static class CharacterDB
    {
        public static List<CharInfo> GetAllCharacters()
        {
            using (CharacterContext context = new CharacterContext())
            {
                List<CharInfo> allChars =
                        (from chars in context.Characters
                         select chars).ToList();
            return allChars;

            }
        }

        public static List<CharStat> GetAllCaracterStats()
        {
            using (CharacterContext context = new CharacterContext())
            {
                List<CharStat> allStats =
                    (from stat in context.Stats
                     select stat).ToList();
                return allStats;
            }
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
        public static CharInfo Update(CharInfo c)
        {
            CharacterContext context = new CharacterContext();
            context.Entry(c).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();

            return c;
        }

        public static CharStat Update(CharStat s)
        {
            CharacterContext context = new CharacterContext();
            context.Entry(s).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();

            return s;
        }
        public static void Delete(CharInfo c, CharStat s)
        {
            CharacterContext context = new CharacterContext();
            context.Entry(c).State = System.Data.Entity.EntityState.Deleted;
            context.Entry(s).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();

        }
        public static void Delete(int id)
        {
            CharacterContext context = new CharacterContext();
            CharInfo charToDelete =
                (from c in context.Characters
                 where c.CharacterId == id
                 select c).Single();
            CharStat statToDelete =
                (from s in context.Stats
                 where s.CharacterId == id
                 select s).Single();
            context.Entry(charToDelete).State = System.Data.Entity.EntityState.Deleted;
            context.Entry(statToDelete).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();

        }
    }
}
