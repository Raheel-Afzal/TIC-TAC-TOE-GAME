using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Client_tic_tac_toe_
{
    public partial class WinnerForm : Form
    {
        int winner;
        string symbol;
        public WinnerForm(int winner, string symbol)
        {
            this.winner = winner;
            this.symbol = symbol;
            InitializeComponent();
        }

        private void WinnerForm_Load(object sender, EventArgs e)
        {
            
            lblPlayer.Text = "Player: " + symbol;
            picLoose.Visible = false;
            picwon.Visible = false;
            picDraw.Visible = false;


            if (winner == 1)
                picwon.Visible = true;
            else if (winner == 0)
                picLoose.Visible = true;
            else if (winner == 2)
                picDraw.Visible = true;
            
            
            
        }       
    }
}
