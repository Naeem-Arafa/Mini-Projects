using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game.Screens
{
    public partial class WinnerScreen : Form
    {
        private GameScreen _mainScreen;
        private string _result;
        public WinnerScreen(GameScreen mainScreen, string Res)
        {
            _mainScreen = mainScreen;
            _result = Res;
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            _mainScreen.Close();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WinnerScreen_Load(object sender, EventArgs e)
        {
            lblResult.Text = _result;
            if (_result == "PLAYER 1")
                pbWinner.Image = Resources.champion;
            else if (_result == "PLAYER 2")
                pbWinner.Image = Resources.champion__1_;
            else
                pbWinner.Image = Resources.thinking;
        }
    }
}
