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
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.LightGray;
            this.PnlGame.Location = new System.Drawing.Point(12, 149);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(600, 400);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // TmrBall
            // 
            this.TmrBall.Enabled = true;
            this.TmrBall.Tick += new System.EventHandler(this.TmrBall_Tick);
            // 
            // TmrLadybug
            // 
            this.TmrLadybug.Interval = 50;
            this.TmrLadybug.Tick += new System.EventHandler(this.TmrLadybug_Tick);
            // 
            // FrmLadybug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PnlGame);
            this.KeyPreview = true;
            this.Name = "FrmLadybug";
            this.Text = "Fly Ladybug ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLadybug_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLadybug_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrBall;
        private System.Windows.Forms.Timer TmrLadybug;
    }
}

