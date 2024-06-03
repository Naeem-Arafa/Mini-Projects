using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Screens;

namespace Tic_Tac_Toe_Game
{
    public partial class frmStartGame : Form
    {
        Thread th;
        public frmStartGame()
        {
            InitializeComponent();
        }

        public void opened(object obj)
        {
            Application.Run(new GameScreen());
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opened);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
