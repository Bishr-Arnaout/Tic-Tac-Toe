namespace Tic_Tac_Toe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnStart_Game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart_Game
            // 
            this.btnStart_Game.BackColor = System.Drawing.Color.Transparent;
            this.btnStart_Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart_Game.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart_Game.ForeColor = System.Drawing.Color.Red;
            this.btnStart_Game.Location = new System.Drawing.Point(347, 366);
            this.btnStart_Game.Name = "btnStart_Game";
            this.btnStart_Game.Size = new System.Drawing.Size(130, 44);
            this.btnStart_Game.TabIndex = 3;
            this.btnStart_Game.Text = "Start";
            this.btnStart_Game.UseVisualStyleBackColor = false;
            this.btnStart_Game.Click += new System.EventHandler(this.btnStart_Game_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.wallpaperflare_com_wallpaper__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart_Game);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnStart_Game;
    }
}

