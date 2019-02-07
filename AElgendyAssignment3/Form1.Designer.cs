namespace AElgendyAssignment3
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
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.btnPlayer1On = new System.Windows.Forms.Button();
            this.btnPlayer2On = new System.Windows.Forms.Button();
            this.txtPlayerTurn = new System.Windows.Forms.TextBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.Location = new System.Drawing.Point(567, 172);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(97, 158);
            this.btnPlayer1.TabIndex = 0;
            this.btnPlayer1.Text = "Player1";
            this.btnPlayer1.UseVisualStyleBackColor = true;
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.Location = new System.Drawing.Point(670, 172);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(97, 158);
            this.btnPlayer2.TabIndex = 0;
            this.btnPlayer2.Text = "Player2";
            this.btnPlayer2.UseVisualStyleBackColor = true;
            // 
            // btnPlayer1On
            // 
            this.btnPlayer1On.Location = new System.Drawing.Point(567, 140);
            this.btnPlayer1On.Name = "btnPlayer1On";
            this.btnPlayer1On.Size = new System.Drawing.Size(97, 33);
            this.btnPlayer1On.TabIndex = 1;
            this.btnPlayer1On.UseVisualStyleBackColor = true;
            // 
            // btnPlayer2On
            // 
            this.btnPlayer2On.Location = new System.Drawing.Point(670, 140);
            this.btnPlayer2On.Name = "btnPlayer2On";
            this.btnPlayer2On.Size = new System.Drawing.Size(97, 33);
            this.btnPlayer2On.TabIndex = 1;
            this.btnPlayer2On.UseVisualStyleBackColor = true;
            // 
            // txtPlayerTurn
            // 
            this.txtPlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerTurn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPlayerTurn.Location = new System.Drawing.Point(567, 90);
            this.txtPlayerTurn.Name = "txtPlayerTurn";
            this.txtPlayerTurn.ReadOnly = true;
            this.txtPlayerTurn.Size = new System.Drawing.Size(200, 34);
            this.txtPlayerTurn.TabIndex = 2;
            this.txtPlayerTurn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGameName.Location = new System.Drawing.Point(166, 9);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(174, 29);
            this.lblGameName.TabIndex = 3;
            this.lblGameName.Text = "TIC TAC TOE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.txtPlayerTurn);
            this.Controls.Add(this.btnPlayer2On);
            this.Controls.Add(this.btnPlayer1On);
            this.Controls.Add(this.btnPlayer2);
            this.Controls.Add(this.btnPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayer1;
        private System.Windows.Forms.Button btnPlayer2;
        private System.Windows.Forms.Button btnPlayer1On;
        private System.Windows.Forms.Button btnPlayer2On;
        private System.Windows.Forms.TextBox txtPlayerTurn;
        private System.Windows.Forms.Label lblGameName;
    }
}

