namespace Client_tic_tac_toe_
{
    partial class WinnerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlayer = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picwon = new System.Windows.Forms.PictureBox();
            this.picLoose = new System.Windows.Forms.PictureBox();
            this.picDraw = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picwon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Oswald", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlayer.Location = new System.Drawing.Point(167, 446);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(100, 49);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "Player: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Client_tic_tac_toe_.Properties.Resources.tic_tac_toe;
            this.pictureBox2.Location = new System.Drawing.Point(141, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Client_tic_tac_toe_.Properties.Resources.coollogo_com_1337086;
            this.pictureBox1.Location = new System.Drawing.Point(40, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // picwon
            // 
            this.picwon.BackColor = System.Drawing.Color.Transparent;
            this.picwon.Image = global::Client_tic_tac_toe_.Properties.Resources.coollogo_com_3540129;
            this.picwon.Location = new System.Drawing.Point(40, 296);
            this.picwon.Name = "picwon";
            this.picwon.Size = new System.Drawing.Size(440, 199);
            this.picwon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picwon.TabIndex = 1;
            this.picwon.TabStop = false;
            // 
            // picLoose
            // 
            this.picLoose.BackColor = System.Drawing.Color.Transparent;
            this.picLoose.Image = global::Client_tic_tac_toe_.Properties.Resources.coollogo_com_19339157;
            this.picLoose.Location = new System.Drawing.Point(40, 299);
            this.picLoose.Name = "picLoose";
            this.picLoose.Size = new System.Drawing.Size(440, 199);
            this.picLoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoose.TabIndex = 1;
            this.picLoose.TabStop = false;
            // 
            // picDraw
            // 
            this.picDraw.BackColor = System.Drawing.Color.Transparent;
            this.picDraw.Image = global::Client_tic_tac_toe_.Properties.Resources.coollogo_com_132615030;
            this.picDraw.Location = new System.Drawing.Point(40, 306);
            this.picDraw.Name = "picDraw";
            this.picDraw.Size = new System.Drawing.Size(440, 199);
            this.picDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDraw.TabIndex = 1;
            this.picDraw.TabStop = false;
            // 
            // WinnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 518);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picLoose);
            this.Controls.Add(this.picDraw);
            this.Controls.Add(this.picwon);
            this.Name = "WinnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WinnerForm";
            this.Load += new System.EventHandler(this.WinnerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picwon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picLoose;
        private System.Windows.Forms.PictureBox picwon;
        private System.Windows.Forms.PictureBox picDraw;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPlayer;
    }
}