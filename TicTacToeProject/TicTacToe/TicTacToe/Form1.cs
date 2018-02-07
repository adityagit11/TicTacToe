using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int player = 2; //even = X turn; odd = O turn;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;

        private void ButtonClick(object sender, EventArgs e)
        {
            // type casted the object sender to button type
            Button button = (Button)sender;

            if(button.Text=="")
            {
                if (player % 2 == 0)
                {
                    // even player that means X turn
                    button.Text = "X";
                }
                else
                {
                    // odd player that means O turn
                    button.Text = "O";
                }
                player++;
                turns++;
                if(CheckDraw())
                {
                    MessageBox.Show("Tie Game!");
                    sd ++;
                    NewGame();
                }

                if(CheckWinner())
                {
                    if(button.Text=="X")
                    {
                        MessageBox.Show("X Won!");
                        s1++;
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show("O Won!");
                        s2++;
                        NewGame();
                    }
                }
            }
        }

        private void ExitButton(object sender, EventArgs e)
        {
            this.Close();
        }

        void NewGame()
        {
            player = 2;
            turns = 0;
            A11.Text = A12.Text = A13.Text = A21.Text = A22.Text = A23.Text = A31.Text = A32.Text = A33.Text = "";
            XWin.Text = "X Wins: "+s1;
            OWin.Text = "O Wins: "+s2;
            Draws.Text = "Draws: "+sd;
        }

        private void NewGameButtonClick(object sender, EventArgs e)
        {
            NewGame();
        }

        bool CheckDraw()
        {
            if (turns == 9)
                return true;
            else
                return false;
        }

        bool CheckWinner()
        {
            // horizontal checks
            if ((A11.Text == A12.Text) && (A12.Text == A13.Text) && A11.Text != "")
                return true;
            else if ((A21.Text == A22.Text) && (A22.Text == A23.Text) && A21.Text != "")
                return true;
            else if ((A31.Text == A32.Text) && (A32.Text == A33.Text) && A31.Text != "")
                return true;

            // vertical checks
            if ((A11.Text == A21.Text) && (A21.Text == A31.Text) && A11.Text != "")
                return true;
            else if ((A12.Text == A22.Text) && (A22.Text == A32.Text) && A12.Text != "")
                return true;
            else if ((A13.Text == A23.Text) && (A23.Text == A33.Text) && A13.Text != "")
                return true;

            // diagonal checks
            if ((A11.Text == A22.Text) && (A22.Text == A33.Text) && A11.Text != "")
                return true;
            else if ((A13.Text == A22.Text) && (A22.Text == A31.Text) && A13.Text != "")
                return true;
            return false;
        }

        void reset()
        {
            s1 = 0;
            s2 = 0;
            sd = 0;
            XWin.Text = "X Win: " + s1;
            OWin.Text = "O Win: " + s2;
            Draws.Text = "Draws: " + sd;
        }

        private void RButton_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
