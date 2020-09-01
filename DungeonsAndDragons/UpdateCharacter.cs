using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonsAndDragons
{
    public partial class UpdateCharacter : Form
    {
        public UpdateCharacter()
        {
            InitializeComponent();
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateCharacter_Load(object sender, EventArgs e)
        {
            List<CharInfo> characters = CharacterDB.GetAllCharacters();
            PopulateCharList(characters);

        }
        private void PopulateCharList(List<CharInfo> chars)
        {
            listBox1.Items.Clear();
            foreach (CharInfo c in chars)
            {
                listBox1.Items.Add(c);
            }
        }

        private void AddCharacterBTN_Click(object sender, EventArgs e)
        {
            CharInfo c = new CharInfo();
            CharStat s = new CharStat();

            c.CharacterName = CharNameTXT.Text;
            c.PlayerName = PlayerNameTXT.Text;
            c.Class = Convert.ToString(ClassCBX.SelectedItem);
            c.Level = Convert.ToInt32(LevelNUM.Value);
            c.Race = Convert.ToString(RaceCBX.SelectedItem);
            //c.Alignment = getEthics() + " " + getMorals();
            c.Background = BackgroundTXT.Text;

            s.Charisma = Convert.ToInt32(CharNUM.Value);
            s.Constitution = Convert.ToInt32(ConNUM.Value);
            s.Dexterity = Convert.ToInt32(DexNUM.Value);
            s.Intelligence = Convert.ToInt32(IntNUM.Value);
            s.Strength = Convert.ToInt32(StrNUM.Value);
            s.Wisdom = Convert.ToInt32(WisNUM.Value);

            CharacterDB.Update(c);
            CharacterDB.Update(s);

            Close();
        }
    }
}
