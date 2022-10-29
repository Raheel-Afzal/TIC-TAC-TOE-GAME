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
using System.Runtime.Serialization.Formatters.Binary;

namespace Client_tic_tac_toe_
{
    public partial class GridForm : Form
    {
        TcpClient c;
        string symbol;
        string oponent;
        string winner;
        
        


       
        public GridForm(TcpClient c, string s)
        {
            this.c = c;
            symbol = s;
            InitializeComponent();
        }

        private void GridForm_Load(object sender, EventArgs e)
        {
            lblPlayer.Text = "Player: " + symbol;
            HideCross();
            HideCircle();
            CheckForIllegalCrossThreadCalls = false;

            if (symbol == "0")
            {
                oponent = "X";
                DisableControls();
                new Thread(() => Read()).Start();

            }
            else
                oponent = "0";
            
        }
       
        private void Read()
        {
            BinaryFormatter fobj = new BinaryFormatter();
            string msg = (string)fobj.Deserialize(c.GetStream());
            Mark(msg);
            CheckForWinning();
            EnableControls();
        }
 
        private void Mark(string msg)
        {
           
           
            string [] m = msg.Split(',');
            int r = int.Parse(m[0]);
            int c = int.Parse(m[1]);
            if (r==0 && c==0)
            {
                btn0_0.Text = oponent;
                btn0_0.Enabled = false;
                Check_And_ChangeColor_Blue();
            }
            if (r == 0 && c == 1)
            {
                btn0_1.Text = oponent;
                btn0_1.Enabled = false;
                Check_And_ChangeColor_Blue();
            }
            if (r == 0 && c == 2)
            {
                btn0_2.Text = oponent;
                btn0_2.Enabled = false;
                Check_And_ChangeColor_Blue();
            }
            if (r == 1 && c == 0)
            {
                btn1_0.Text = oponent;
                btn1_0.Enabled = false;
                Check_And_ChangeColor_Blue();
            }
            if (r == 1 && c == 1)
            {
                btn1_1.Text = oponent;
                btn1_1.Enabled = false;
                Check_And_ChangeColor_Blue();
            }
            if (r == 1 && c == 2)
            {
                btn1_2.Text = oponent;
                btn1_2.Enabled = false;
                Check_And_ChangeColor_Blue();
            }
            if (r == 2 && c == 0)
            {
                btn2_0.Text = oponent;
                btn2_0.Enabled = false;
                Check_And_ChangeColor_Blue();
            }
            if (r == 2 && c == 1)
            {
                btn2_1.Text = oponent;
                btn2_1.Enabled = false;
                Check_And_ChangeColor_Blue();
            }
            if (r == 2 && c == 2)
            {
                btn2_2.Text = oponent;
                btn2_2.Enabled = false;
                Check_And_ChangeColor_Blue();
            }
        }

        #region Buttons_Click

        private void btn0_0_Click(object sender, EventArgs e)
        {
            
            btn0_0.Text = symbol;
            
            btn0_0.Enabled = false;
            Check_And_ChangeColor_Blue();
            string m = "0,0";
            BinaryFormatter fobj;
            fobj = new BinaryFormatter();
            fobj.Serialize(c.GetStream(), m);
            DisableControls();
            CheckForWinning();
            new Thread(() => Read()).Start();
           

        }

        private void btn0_1_Click(object sender, EventArgs e)
        {
            
            btn0_1.Text = symbol;
            
            btn0_1.Enabled = false;
            Check_And_ChangeColor_Blue();
            string m = "0,1";
            BinaryFormatter fobj;
            fobj = new BinaryFormatter();
            fobj.Serialize(c.GetStream(), m);
            DisableControls();
            CheckForWinning();
            new Thread(() => Read()).Start();
            
        }

        private void btn0_2_Click(object sender, EventArgs e)
        {
            
            btn0_2.Text = symbol;
            
            btn0_2.Enabled = false;
            Check_And_ChangeColor_Blue();
            string m = "0,2";
            BinaryFormatter fobj;
            fobj = new BinaryFormatter();
            fobj.Serialize(c.GetStream(), m);
            DisableControls();
            CheckForWinning();
            new Thread(() => Read()).Start();
           
        }

        private void btn1_0_Click(object sender, EventArgs e)
        {
            
            btn1_0.Text = symbol;
            
            btn1_0.Enabled = false;
            Check_And_ChangeColor_Blue();
            string m = "1,0";
            BinaryFormatter fobj;
            fobj = new BinaryFormatter();
            fobj.Serialize(c.GetStream(), m);
            DisableControls();
            CheckForWinning();
            new Thread(() => Read()).Start();
           
        }

        private void btn1_1_Click(object sender, EventArgs e)
        {
           
            btn1_1.Text = symbol;
            
            btn1_1.Enabled = false;
            Check_And_ChangeColor_Blue();
            string m = "1,1";
            BinaryFormatter fobj;
            fobj = new BinaryFormatter();
            fobj.Serialize(c.GetStream(), m);
            DisableControls();
            CheckForWinning();
            new Thread(() => Read()).Start();
          
        }

        private void btn1_2_Click(object sender, EventArgs e)
        {
            
            btn1_2.Text = symbol;
            
            btn1_2.Enabled = false;
            Check_And_ChangeColor_Blue();
            string m = "1,2";
            BinaryFormatter fobj;
            fobj = new BinaryFormatter();
            fobj.Serialize(c.GetStream(), m);
            DisableControls();
            CheckForWinning();
            new Thread(() => Read()).Start();
           
        }

        private void btn2_0_Click(object sender, EventArgs e)
        {
           
            btn2_0.Text = symbol;
            
            btn2_0.Enabled = false;
            Check_And_ChangeColor_Blue();
            string m = "2,0";
            BinaryFormatter fobj;
            fobj = new BinaryFormatter();
            fobj.Serialize(c.GetStream(), m);
            DisableControls();
            CheckForWinning();
            new Thread(() => Read()).Start();
           
        }

        private void btn2_1_Click(object sender, EventArgs e)
        {
            
            btn2_1.Text = symbol;
            
            btn2_1.Enabled = false;
            Check_And_ChangeColor_Blue();
            string m = "2,1";
            BinaryFormatter fobj;
            fobj = new BinaryFormatter();
            fobj.Serialize(c.GetStream(), m);
            DisableControls();
            CheckForWinning();
            new Thread(() => Read()).Start();
            
        }

        private void btn2_2_Click(object sender, EventArgs e)
        {
            
            btn2_2.Text = symbol;
            btn2_2.Enabled = false;
            Check_And_ChangeColor_Blue();
            string m = "2,2";
            BinaryFormatter fobj;
            fobj = new BinaryFormatter();
            fobj.Serialize(c.GetStream(), m);
            DisableControls();
            CheckForWinning();
            new Thread(() => Read()).Start();
            
        }
        #endregion
        private void DisableControls()
        {
            lbl_turn.Visible = false;
            

            btn0_0.Enabled = false;
            btn0_1.Enabled = false;
            btn0_2.Enabled = false;
            btn1_0.Enabled = false;
            btn1_1.Enabled = false;
            btn1_2.Enabled = false;
            btn2_0.Enabled = false;
            btn2_1.Enabled = false;
            btn2_2.Enabled = false;

        }
        private void EnableControls()
        {
            lbl_turn.Visible = true;

            if (btn0_0.Text == string.Empty) { btn0_0.Enabled = true; }
            if (btn0_1.Text == string.Empty) { btn0_1.Enabled = true; }
            if (btn0_2.Text == string.Empty) { btn0_2.Enabled = true; }
            if (btn1_0.Text == string.Empty) { btn1_0.Enabled = true; }
            if (btn1_1.Text == string.Empty) { btn1_1.Enabled = true; }
            if (btn1_2.Text == string.Empty) { btn1_2.Enabled = true; }
            if (btn2_0.Text == string.Empty) { btn2_0.Enabled = true; }
            if (btn2_1.Text == string.Empty) { btn2_1.Enabled = true; }
            if (btn2_2.Text == string.Empty) { btn2_2.Enabled = true; }

        }

        private void HideCross()
        {
            cross0_0.Visible = false;
            cross0_1.Visible = false;
            cross0_2.Visible = false;
            cross1_0.Visible = false;
            cross1_1.Visible = false;
            cross1_2.Visible = false;
            cross2_0.Visible = false;
            cross2_1.Visible = false;
            cross2_2.Visible = false;
        }
        private void HideCircle()
        {
            circle0_0.Visible = false;
            circle0_1.Visible = false;
            circle0_2.Visible = false;
            circle1_0.Visible = false;
            circle1_1.Visible = false;
            circle1_2.Visible = false;
            circle2_0.Visible = false;
            circle2_1.Visible = false;
            circle2_2.Visible = false;
        }
        private void CheckForWinning()
        {
            if ((btn0_0.Text == "0" && btn0_1.Text == "0" && btn0_2.Text == "0") ||
                (btn1_0.Text == "0" && btn1_1.Text == "0" && btn1_2.Text == "0") ||
                (btn2_0.Text == "0" && btn2_1.Text == "0" && btn2_2.Text == "0") ||

                (btn0_0.Text == "0" && btn1_0.Text == "0" && btn2_0.Text == "0") ||
                (btn0_1.Text == "0" && btn1_1.Text == "0" && btn2_1.Text == "0") ||
                (btn0_2.Text == "0" && btn1_2.Text == "0" && btn2_2.Text == "0") ||

                (btn0_0.Text == "0" && btn1_1.Text == "0" && btn2_2.Text == "0") ||
                (btn0_2.Text == "0" && btn1_1.Text == "0" && btn2_0.Text == "0") ||
                (btn0_1.Text == "0" && btn1_1.Text == "0" && btn2_1.Text == "0"))
            {
                int ch = 0;
                winner = "0";
                if (winner == symbol)
                    ch = 1;
                WinnerForm wf = new WinnerForm(ch,symbol);
                wf.ShowDialog();
                this.Hide();


            }

            else if
                ((btn0_0.Text == "X" && btn0_1.Text == "X" && btn0_2.Text == "X") ||
                (btn1_0.Text == "X" && btn1_1.Text == "X" && btn1_2.Text == "X") ||
                (btn2_0.Text == "X" && btn2_1.Text == "X" && btn2_2.Text == "X") ||

                (btn0_0.Text == "X" && btn1_0.Text == "X" && btn2_0.Text == "X") ||
                (btn0_1.Text == "X" && btn1_1.Text == "X" && btn2_1.Text == "X") ||
                (btn0_2.Text == "X" && btn1_2.Text == "X" && btn2_2.Text == "X") ||

                (btn0_0.Text == "X" && btn1_1.Text == "X" && btn2_2.Text == "X") ||
                (btn0_2.Text == "X" && btn1_1.Text == "X" && btn2_0.Text == "X") ||
                (btn0_1.Text == "X" && btn1_1.Text == "X" && btn2_1.Text == "X"))
            {
                int ch = 0;
                winner = "X";
                if (winner == symbol)
                    ch = 1;
                WinnerForm wf = new WinnerForm(ch, symbol);
                wf.ShowDialog();
                this.Hide();

            }
            else if
                ((btn0_0.Text != "" && btn0_1.Text != "" && btn0_2.Text != "") &&
                (btn1_0.Text != "" && btn1_1.Text != "" && btn1_2.Text != "") &&
                (btn2_0.Text != "" && btn2_1.Text != "" && btn2_2.Text != "") &&

                (btn0_0.Text != "" && btn1_0.Text != "" && btn2_0.Text != "") &&
                (btn0_1.Text != "" && btn1_1.Text != "" && btn2_1.Text != "") &&
                (btn0_2.Text != "" && btn1_2.Text != "" && btn2_2.Text != "") &&

                (btn0_0.Text != "" && btn1_1.Text != "" && btn2_2.Text != "") &&
                (btn0_2.Text != "" && btn1_1.Text != "" && btn2_0.Text != "") &&
                (btn0_1.Text != "" && btn1_1.Text != "" && btn2_1.Text != ""))
            {

                WinnerForm wf = new WinnerForm(2,symbol);
                wf.ShowDialog();
                this.Hide();
            }


        }
        private void Check_And_ChangeColor_Blue()
        {
                       
              if(  btn0_0.Text == "X"  && cross0_0.Visible == false) 
              {
                
                cross0_0.Visible = true;
              }
            if (btn0_0.Text == "0" && circle0_0.Visible == false)//circle
            {

                circle0_0.Visible = true;
            }

            else if(  btn1_0.Text == "X" && cross1_0.Visible == false) 
              {
                cross1_0.Visible = true;
              }
            else if (btn1_0.Text == "0" && circle1_0.Visible == false)//circle
            {
                circle1_0.Visible = true;
            }
            else if(  btn2_0.Text == "X" && cross2_0.Visible == false) 
              {
                cross2_0.Visible = true;
              }
            else if (btn2_0.Text == "0" && circle2_0.Visible == false)//circle
            {
                circle2_0.Visible = true;
            }
            else if(  btn0_1.Text == "X" && cross0_1.Visible == false) 
              {
                cross0_1.Visible = true;
              }
            else if (btn0_1.Text == "0" && circle0_1.Visible == false)//circle
            {
                circle0_1.Visible = true;
            }
            else if(  btn1_1.Text == "X" && cross1_1.Visible == false) 
              {
                cross1_1.Visible = true;
              }
            else if (btn1_1.Text == "0" && circle1_1.Visible == false)//circle
            {
                circle1_1.Visible = true;
            }
            else if(  btn2_1.Text == "X" && cross2_1.Visible == false) 
              {
                cross2_1.Visible = true;
              }
            else if (btn2_1.Text == "0" && circle2_1.Visible == false)//circle
            {
                circle2_1.Visible = true;
            }
            else if(  btn0_2.Text == "X" && cross0_2.Visible == false) 
              {
                cross0_2.Visible = true;
              }
            else if (btn0_2.Text == "0" && circle0_2.Visible == false)//circle
            {
                circle0_2.Visible = true;
            }
            else if(  btn1_2.Text == "X" && cross1_2.Visible == false) 
              {
                cross1_2.Visible = true;
              }
            else if (btn1_2.Text == "0" && circle1_2.Visible == false)//circle
            {
               circle1_2.Visible = true;
            }
            else if(  btn2_2.Text == "X" && cross2_2.Visible == false) 
              {
                 cross2_2.Visible = true;
              }
            else if (btn2_2.Text == "0" && circle2_2.Visible == false) //circle
            {
               circle2_2.Visible = true;
            }

        }

        private void circle0_2_Click(object sender, EventArgs e)
        {

        }

        private void circle0_1_Click(object sender, EventArgs e)
        {

        }

        private void circle0_0_Click(object sender, EventArgs e)
        {

        }

        private void circle1_0_Click(object sender, EventArgs e)
        {

        }

        private void circle1_1_Click(object sender, EventArgs e)
        {

        }

        private void circle1_2_Click(object sender, EventArgs e)
        {

        }

        private void circle2_2_Click(object sender, EventArgs e)
        {

        }

        private void circle2_1_Click(object sender, EventArgs e)
        {

        }

        private void circle2_0_Click(object sender, EventArgs e)
        {

        }
    }
}
