namespace Postero.KingOfNumbers.View.WinForms
{
    partial class frmMain
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
            this.lbl1Left = new System.Windows.Forms.Label();
            this.lbl1Right = new System.Windows.Forms.Label();
            this.lbl1Name = new System.Windows.Forms.Label();
            this.lbl2Right = new System.Windows.Forms.Label();
            this.lbl2Left = new System.Windows.Forms.Label();
            this.lbl2Name = new System.Windows.Forms.Label();
            this.lblValue1Left = new System.Windows.Forms.Label();
            this.lblValue1Right = new System.Windows.Forms.Label();
            this.lblValue2Left = new System.Windows.Forms.Label();
            this.lblValue2Right = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1Left
            // 
            this.lbl1Left.AutoSize = true;
            this.lbl1Left.Location = new System.Drawing.Point(61, 237);
            this.lbl1Left.Name = "lbl1Left";
            this.lbl1Left.Size = new System.Drawing.Size(25, 13);
            this.lbl1Left.TabIndex = 0;
            this.lbl1Left.Text = "Left";
            this.lbl1Left.Click += new System.EventHandler(this.lbl1Left_Click);
            // 
            // lbl1Right
            // 
            this.lbl1Right.AutoSize = true;
            this.lbl1Right.Location = new System.Drawing.Point(315, 237);
            this.lbl1Right.Name = "lbl1Right";
            this.lbl1Right.Size = new System.Drawing.Size(32, 13);
            this.lbl1Right.TabIndex = 1;
            this.lbl1Right.Text = "Right";
            this.lbl1Right.Click += new System.EventHandler(this.lbl1Right_Click);
            // 
            // lbl1Name
            // 
            this.lbl1Name.AutoSize = true;
            this.lbl1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Name.Location = new System.Drawing.Point(178, 223);
            this.lbl1Name.Name = "lbl1Name";
            this.lbl1Name.Size = new System.Drawing.Size(60, 17);
            this.lbl1Name.TabIndex = 2;
            this.lbl1Name.Text = "Player 1";
            // 
            // lbl2Right
            // 
            this.lbl2Right.AutoSize = true;
            this.lbl2Right.Location = new System.Drawing.Point(53, 13);
            this.lbl2Right.Name = "lbl2Right";
            this.lbl2Right.Size = new System.Drawing.Size(32, 13);
            this.lbl2Right.TabIndex = 3;
            this.lbl2Right.Text = "Right";
            this.lbl2Right.Click += new System.EventHandler(this.lbl2Right_Click);
            // 
            // lbl2Left
            // 
            this.lbl2Left.AutoSize = true;
            this.lbl2Left.Location = new System.Drawing.Point(318, 13);
            this.lbl2Left.Name = "lbl2Left";
            this.lbl2Left.Size = new System.Drawing.Size(25, 13);
            this.lbl2Left.TabIndex = 4;
            this.lbl2Left.Text = "Left";
            this.lbl2Left.Click += new System.EventHandler(this.lbl2Left_Click);
            // 
            // lbl2Name
            // 
            this.lbl2Name.AutoSize = true;
            this.lbl2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Name.Location = new System.Drawing.Point(178, 13);
            this.lbl2Name.Name = "lbl2Name";
            this.lbl2Name.Size = new System.Drawing.Size(60, 17);
            this.lbl2Name.TabIndex = 5;
            this.lbl2Name.Text = "Player 2";
            // 
            // lblValue1Left
            // 
            this.lblValue1Left.AutoSize = true;
            this.lblValue1Left.BackColor = System.Drawing.Color.PeachPuff;
            this.lblValue1Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue1Left.Location = new System.Drawing.Point(57, 176);
            this.lblValue1Left.Name = "lblValue1Left";
            this.lblValue1Left.Size = new System.Drawing.Size(36, 39);
            this.lblValue1Left.TabIndex = 6;
            this.lblValue1Left.Text = "0";
            this.lblValue1Left.Click += new System.EventHandler(this.lblValue1Left_Click);
            // 
            // lblValue1Right
            // 
            this.lblValue1Right.AutoSize = true;
            this.lblValue1Right.BackColor = System.Drawing.Color.PeachPuff;
            this.lblValue1Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue1Right.Location = new System.Drawing.Point(314, 176);
            this.lblValue1Right.Name = "lblValue1Right";
            this.lblValue1Right.Size = new System.Drawing.Size(36, 39);
            this.lblValue1Right.TabIndex = 7;
            this.lblValue1Right.Text = "0";
            this.lblValue1Right.Click += new System.EventHandler(this.lblValue1Right_Click);
            // 
            // lblValue2Left
            // 
            this.lblValue2Left.AutoSize = true;
            this.lblValue2Left.BackColor = System.Drawing.Color.PeachPuff;
            this.lblValue2Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue2Left.Location = new System.Drawing.Point(314, 44);
            this.lblValue2Left.Name = "lblValue2Left";
            this.lblValue2Left.Size = new System.Drawing.Size(36, 39);
            this.lblValue2Left.TabIndex = 8;
            this.lblValue2Left.Text = "0";
            this.lblValue2Left.Click += new System.EventHandler(this.lblValue2Left_Click);
            // 
            // lblValue2Right
            // 
            this.lblValue2Right.AutoSize = true;
            this.lblValue2Right.BackColor = System.Drawing.Color.PeachPuff;
            this.lblValue2Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue2Right.Location = new System.Drawing.Point(57, 44);
            this.lblValue2Right.Name = "lblValue2Right";
            this.lblValue2Right.Size = new System.Drawing.Size(36, 39);
            this.lblValue2Right.TabIndex = 9;
            this.lblValue2Right.Text = "0";
            this.lblValue2Right.Click += new System.EventHandler(this.lblValue2Right_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 262);
            this.Controls.Add(this.lblValue2Right);
            this.Controls.Add(this.lblValue2Left);
            this.Controls.Add(this.lblValue1Right);
            this.Controls.Add(this.lblValue1Left);
            this.Controls.Add(this.lbl2Name);
            this.Controls.Add(this.lbl2Left);
            this.Controls.Add(this.lbl2Right);
            this.Controls.Add(this.lbl1Name);
            this.Controls.Add(this.lbl1Right);
            this.Controls.Add(this.lbl1Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "King of Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1Left;
        private System.Windows.Forms.Label lbl1Right;
        private System.Windows.Forms.Label lbl1Name;
        private System.Windows.Forms.Label lbl2Right;
        private System.Windows.Forms.Label lbl2Left;
        private System.Windows.Forms.Label lbl2Name;
        private System.Windows.Forms.Label lblValue1Left;
        private System.Windows.Forms.Label lblValue1Right;
        private System.Windows.Forms.Label lblValue2Left;
        private System.Windows.Forms.Label lblValue2Right;
    }
}

