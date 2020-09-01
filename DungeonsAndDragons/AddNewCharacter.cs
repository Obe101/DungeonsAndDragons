using System;
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
    public partial class AddNewCharacter : Form
    {
        public AddNewCharacter()
        {
            InitializeComponent();
        }

        private void AddNewCharacter_Load(object sender, EventArgs e)
        {

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
            c.Alignment = getEthics() + " " + getMorals();
            c.Background = BackgroundTXT.Text;

            s.Charisma = Convert.ToInt32(CharNUM.Value);
            s.Constitution = Convert.ToInt32(ConNUM.Value);
            s.Dexterity = Convert.ToInt32(DexNUM.Value);
            s.Intelligence = Convert.ToInt32(IntNUM.Value);
            s.Strength = Convert.ToInt32(StrNUM.Value);
            s.Wisdom = Convert.ToInt32(WisNUM.Value);

            CharacterDB.Add(c);
            CharacterDB.Add(s);

            Close();
        }

        private void CharNameTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void RaceCBX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LevelNUM_ValueChanged(object sender, EventArgs e)
        {

        }
        private string getEthics()
        {

            if (EthLawfulRBTN.Checked)
            {
                return "Lawful";
            }
            else if (EthNeutralRBTN.Checked)
            {
                return "Neutral";
            }
            else if (EthChaoticRBTN.Checked)
            {
                return "Chaotic";
            }
            else
            {
                return null;
            }
        }
        private string getMorals()
        {

            if (MorEvilRBTN.Checked)
            {
                return "Evil";
            }
            else if (MorNeutralRBTN.Checked)
            {
                return "Neutral";
            }
            else if (MorGoodRBTN.Checked)
            {
                return "Good";
            }
            else
            {
                return null;
            }
        }

        private void CharNUM_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
