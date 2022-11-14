namespace Menu_of_Games
{
    partial class Start_Menu
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
            this.UnoGame = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.UnoGame)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnoGame
            // 
            this.UnoGame.BackgroundImage = global::Menu_of_Games.Properties.Resources.Start;
            this.UnoGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UnoGame.Location = new System.Drawing.Point(361, 230);
            this.UnoGame.Name = "UnoGame";
            this.UnoGame.Size = new System.Drawing.Size(267, 120);
            this.UnoGame.TabIndex = 0;
            this.UnoGame.TabStop = false;
            this.UnoGame.Click += new System.EventHandler(this.UnoGame_Click);
            this.UnoGame.MouseLeave += new System.EventHandler(this.UnoGame_MouseLeave);
            this.UnoGame.MouseHover += new System.EventHandler(this.UnoGame_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Menu_of_Games.Properties.Resources.menu;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.UnoGame);
            this.panel1.Location = new System.Drawing.Point(605, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 982);
            this.panel1.TabIndex = 1;
            // 
            // Start_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(2292, 1006);
            this.Controls.Add(this.panel1);
            this.Name = "Start_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Menu";
            ((System.ComponentModel.ISupportInitialize)(this.UnoGame)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox UnoGame;
        private System.Windows.Forms.Panel panel1;
    }
}

