namespace Menu
{
    partial class Game_over
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
            this.replay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // replay
            // 
            this.replay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.replay.BackColor = System.Drawing.SystemColors.MenuText;
            this.replay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replay.ForeColor = System.Drawing.SystemColors.Control;
            this.replay.Location = new System.Drawing.Point(313, 189);
            this.replay.Name = "replay";
            this.replay.Size = new System.Drawing.Size(154, 56);
            this.replay.TabIndex = 2;
            this.replay.Text = "Replay";
            this.replay.UseVisualStyleBackColor = false;
            this.replay.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(160, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "You lost, play again to delight your dog !";
            // 
            // Quit
            // 
            this.Quit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Quit.BackColor = System.Drawing.SystemColors.MenuText;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.SystemColors.Control;
            this.Quit.Location = new System.Drawing.Point(313, 294);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(154, 57);
            this.Quit.TabIndex = 12;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Game_over
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.replay);
            this.Name = "Game_over";
            this.Text = "Game_over";
            this.Load += new System.EventHandler(this.Game_over_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button replay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Quit;
    }
}