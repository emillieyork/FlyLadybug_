namespace FlyLadybug
{
    partial class FrmLadybug
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
            this.components = new System.ComponentModel.Container();
            this.PnlGame = new System.Windows.Forms.Panel();
            this.TmrBall = new System.Windows.Forms.Timer(this.components);
            this.TmrLadybug = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtlives = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Azure;
            this.PnlGame.BackgroundImage = global::FlyLadybug.Properties.Resources.skyaaaaa_png;
            this.PnlGame.Location = new System.Drawing.Point(19, 136);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(600, 400);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // TmrBall
            // 
            this.TmrBall.Interval = 50;
            this.TmrBall.Tick += new System.EventHandler(this.TmrBall_Tick);
            // 
            // TmrLadybug
            // 
            this.TmrLadybug.Enabled = true;
            this.TmrLadybug.Interval = 50;
            this.TmrLadybug.Tick += new System.EventHandler(this.TmrLadybug_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(638, 176);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 2;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "score";
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Location = new System.Drawing.Point(637, 242);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(13, 13);
            this.LblScore.TabIndex = 4;
            this.LblScore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lives";
            // 
            // Txtlives
            // 
            this.Txtlives.Location = new System.Drawing.Point(640, 299);
            this.Txtlives.Name = "Txtlives";
            this.Txtlives.Size = new System.Drawing.Size(100, 20);
            this.Txtlives.TabIndex = 6;
            this.Txtlives.Text = "5";
            this.Txtlives.TextChanged += new System.EventHandler(this.Txtlives_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStart,
            this.MnuStop});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuStart
            // 
            this.MnuStart.Name = "MnuStart";
            this.MnuStart.Size = new System.Drawing.Size(43, 20);
            this.MnuStart.Text = "Start";
            this.MnuStart.Click += new System.EventHandler(this.MnuStart_Click);
            // 
            // MnuStop
            // 
            this.MnuStop.Name = "MnuStop";
            this.MnuStop.Size = new System.Drawing.Size(43, 20);
            this.MnuStop.Text = "Stop";
            this.MnuStop.Click += new System.EventHandler(this.MnuStop_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 50);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ladybug";
            // 
            // FrmLadybug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txtlives);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmLadybug";
            this.Text = "Fly Ladybug ";
            this.Load += new System.EventHandler(this.FrmLadybug_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLadybug_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLadybug_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrBall;
        private System.Windows.Forms.Timer TmrLadybug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtlives;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuStart;
        private System.Windows.Forms.ToolStripMenuItem MnuStop;
        private System.Windows.Forms.Label label4;
    }
}

