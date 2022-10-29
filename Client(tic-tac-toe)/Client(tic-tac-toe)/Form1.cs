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
    public partial class Form1 : Form
    {
        TcpClient c = new TcpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl.Visible = false;
        }

       

        private void Play_Click_1(object sender, EventArgs e)
        {
            
           
            c.Connect("127.0.0.1", 9246);
            lbl.Visible = true;
            lbl.Refresh();


            BinaryFormatter fobj = new BinaryFormatter();
            string symbol = (string)fobj.Deserialize(c.GetStream());

            GridForm f = new GridForm(c,symbol);
            f.Show();
            this.Hide();

        }
    }
}
