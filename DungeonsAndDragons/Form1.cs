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
    }
}
