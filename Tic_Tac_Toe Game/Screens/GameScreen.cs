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
    public partial class GameScreen : Form
    {
        // Counters for wins by each player
        private byte _cntPlayer1 = 0, _cntPlayer2 = 0;

        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }

        public GameScreen()
        {
            InitializeComponent();
        }

        // Method to handle the game winner and display the winner screen
        void GameWinner()
        {
            string Winner = "";

            // Determine the winner and update the win count
            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    _cntPlayer1++;
                    Winner = "PLAYER 1";
                    lblPlayer1WinRounds.Text = _cntPlayer1.ToString(); 
                    break;

                case enWinner.Player2:
                    _cntPlayer2++;
                    Winner = "PLAYER 2";
                    lblPlayer2WinRounds.Text = _cntPlayer2.ToString();
                    break;

                default:
                    Winner = "Draw";
                    break;
            }
            Form frmWinner = new WinnerScreen(this, Winner);
            frmWinner.ShowDialog();
            ResetGame();// Reset the game for a new round
        }

        // Method to check if three buttons have the same value (X or O) and determine the winner
        public bool CheckValues(PictureBox btn1, PictureBox btn2, PictureBox btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    GameWinner();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    GameWinner();
                    return true;
                }
            }
            GameStatus.GameOver = false;
            return false;
        }

        // Method to check the game state after each move
        void CheckGame()
        {
            // Check rows for a win
            if (CheckValues(pbGame1, pbGame2, pbGame3))
                return;
            if (CheckValues(pbGame4, pbGame5, pbGame6))
                return;
            if (CheckValues(pbGame7, pbGame8, pbGame9))
                return;

            // Check columns for a win
            if (CheckValues(pbGame1, pbGame4, pbGame7))
                return;
            if (CheckValues(pbGame2, pbGame5, pbGame8))
                return;
            if (CheckValues(pbGame3, pbGame6, pbGame9))
                return;

            // Check diagonals for a win
            if (CheckValues(pbGame1, pbGame5, pbGame9))
                return;
            if (CheckValues(pbGame3, pbGame5, pbGame7))
                return;
        }

        // Method to handle the logic when a player chooses a box
        void ChooseBox( PictureBox PbGame)
        {
            // Check if the box is available
            if (PbGame.Tag.ToString() == "?")
            {
                // Update the box based on the current player's turn
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        PbGame.Image = Resources.x;
                        PlayerTurn = enPlayer.Player2;
                        lblTurnPlayer.Text = "PLAYER 2";
                        GameStatus.PlayCount++;
                        PbGame.Tag = "X";
                        CheckGame();
                        break;
                    case enPlayer.Player2:
                        PbGame.Image = Resources.o;
                        PlayerTurn = enPlayer.Player1;
                        lblTurnPlayer.Text = "PLAYER 1";
                        GameStatus.PlayCount++;
                        PbGame.Tag = "O";
                        CheckGame();
                        break;
                }
            }
            // Show error if the box is already chosen
            else
                MessageBox.Show("You Can't Choose This ", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Check if the game is a draw
            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                GameWinner();
            }
        }

        // Method to reset the game for a new round
        void ResetGame()
        {
            // To Reset Only XOGame Box.
            pbGame1.Tag = "?";
            pbGame1.Image = Resources.question_mark__1_;

            pbGame2.Tag = "?";
            pbGame2.Image = Resources.question_mark__1_;

            pbGame2.Tag = "?";
            pbGame2.Image = Resources.question_mark__1_;

            pbGame3.Tag = "?";
            pbGame3.Image = Resources.question_mark__1_;

            pbGame4.Tag = "?";
            pbGame4.Image = Resources.question_mark__1_;

            pbGame5.Tag = "?";
            pbGame5.Image = Resources.question_mark__1_;

            pbGame6.Tag = "?";
            pbGame6.Image = Resources.question_mark__1_;

            pbGame7.Tag = "?";
            pbGame7.Image = Resources.question_mark__1_;

            pbGame8.Tag = "?";
            pbGame8.Image = Resources.question_mark__1_;

            pbGame9.Tag = "?";
            pbGame9.Image = Resources.question_mark__1_;

            // Reset player turn and game status
            PlayerTurn = enPlayer.Player1;
            lblTurnPlayer.Text = "PLAYER 1";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;

        }

        // Event handler for clicking on a game box
        private void pbGame_Click(object sender, EventArgs e)
        {
            ChooseBox((PictureBox)sender);
        }

        // Event handler for clicking the reset button
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
