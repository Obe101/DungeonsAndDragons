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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void NewCharBtn_Click(object sender, EventArgs e)
        {
            AddNewCharacter addNew = new AddNewCharacter();

            addNew.ShowDialog();
        }

        private void UpdateCharBtn_Click(object sender, EventArgs e)
        {
            UpdateCharacter update = new UpdateCharacter();

            update.ShowDialog();
        }

        private void DeleteCharBtn_Click(object sender, EventArgs e)
        {
            DeleteForm delete = new DeleteForm();
            delete.ShowDialog();
        }
    }
}
