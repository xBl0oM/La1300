namespace MatheQuiz
{
    partial class Potenz
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
            this.countB = new System.Windows.Forms.Label();
            this.countA = new System.Windows.Forms.Label();
            this.countC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countB
            // 
            this.countB.AutoSize = true;
            this.countB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countB.Location = new System.Drawing.Point(302, 67);
            this.countB.Name = "countB";
            this.countB.Size = new System.Drawing.Size(151, 46);
            this.countB.TabIndex = 1;
            this.countB.Text = "Potenz";
            this.countB.Click += new System.EventHandler(this.label2_Click);
            // 
            // countA
            // 
            this.countA.AutoSize = true;
            this.countA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countA.Location = new System.Drawing.Point(318, 216);
            this.countA.Name = "countA";
            this.countA.Size = new System.Drawing.Size(95, 36);
            this.countA.TabIndex = 4;
            this.countA.Text = "label2";
            // 
            // countC
            // 
            this.countC.AutoSize = true;
            this.countC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countC.Location = new System.Drawing.Point(331, 180);
            this.countC.Name = "countC";
            this.countC.Size = new System.Drawing.Size(95, 36);
            this.countC.TabIndex = 5;
            this.countC.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // res
            // 
            this.res.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.Location = new System.Drawing.Point(375, 216);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(100, 41);
            this.res.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(498, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Control";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Potenz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.res);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countC);
            this.Controls.Add(this.countA);
            this.Controls.Add(this.countB);
            this.Name = "Potenz";
            this.Text = "Potenz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label countB;
        private System.Windows.Forms.Label countA;
        private System.Windows.Forms.Label countC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Button button1;
    }
}