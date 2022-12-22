namespace MatheQuiz
{
    partial class Algebra
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
            this.algebra1 = new System.Windows.Forms.TextBox();
            this.equalsX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.euqalsY = new System.Windows.Forms.TextBox();
            this.equalsZ = new System.Windows.Forms.TextBox();
            this.solX = new System.Windows.Forms.TextBox();
            this.solZ = new System.Windows.Forms.TextBox();
            this.solY = new System.Windows.Forms.TextBox();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // algebra1
            // 
            this.algebra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algebra1.Location = new System.Drawing.Point(49, 169);
            this.algebra1.Multiline = true;
            this.algebra1.Name = "algebra1";
            this.algebra1.ReadOnly = true;
            this.algebra1.Size = new System.Drawing.Size(395, 71);
            this.algebra1.TabIndex = 0;
            // 
            // equalsX
            // 
            this.equalsX.BackColor = System.Drawing.SystemColors.Window;
            this.equalsX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsX.Location = new System.Drawing.Point(444, 169);
            this.equalsX.Name = "equalsX";
            this.equalsX.ReadOnly = true;
            this.equalsX.Size = new System.Drawing.Size(37, 27);
            this.equalsX.TabIndex = 1;
            this.equalsX.Text = "x=";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "Controle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // euqalsY
            // 
            this.euqalsY.BackColor = System.Drawing.SystemColors.Window;
            this.euqalsY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euqalsY.Location = new System.Drawing.Point(444, 190);
            this.euqalsY.Name = "euqalsY";
            this.euqalsY.ReadOnly = true;
            this.euqalsY.Size = new System.Drawing.Size(37, 27);
            this.euqalsY.TabIndex = 3;
            this.euqalsY.Text = "y=";
            // 
            // equalsZ
            // 
            this.equalsZ.BackColor = System.Drawing.SystemColors.Window;
            this.equalsZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsZ.Location = new System.Drawing.Point(444, 213);
            this.equalsZ.Name = "equalsZ";
            this.equalsZ.ReadOnly = true;
            this.equalsZ.Size = new System.Drawing.Size(37, 27);
            this.equalsZ.TabIndex = 4;
            this.equalsZ.Text = "z=";
            // 
            // solX
            // 
            this.solX.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.solX.Location = new System.Drawing.Point(487, 169);
            this.solX.Name = "solX";
            this.solX.Size = new System.Drawing.Size(93, 22);
            this.solX.TabIndex = 5;
            // 
            // solZ
            // 
            this.solZ.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.solZ.Location = new System.Drawing.Point(487, 218);
            this.solZ.Name = "solZ";
            this.solZ.Size = new System.Drawing.Size(93, 22);
            this.solZ.TabIndex = 6;
            // 
            // solY
            // 
            this.solY.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.solY.Location = new System.Drawing.Point(487, 193);
            this.solY.Name = "solY";
            this.solY.Size = new System.Drawing.Size(93, 22);
            this.solY.TabIndex = 7;
            this.solY.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(623, 260);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(76, 73);
            this.buttonFinish.TabIndex = 8;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click_1);
            // 
            // Algebra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.solY);
            this.Controls.Add(this.solZ);
            this.Controls.Add(this.solX);
            this.Controls.Add(this.equalsZ);
            this.Controls.Add(this.euqalsY);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.equalsX);
            this.Controls.Add(this.algebra1);
            this.Name = "Algebra";
            this.Text = "Algebra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox algebra1;
        private System.Windows.Forms.TextBox equalsX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox euqalsY;
        private System.Windows.Forms.TextBox equalsZ;
        private System.Windows.Forms.TextBox solX;
        private System.Windows.Forms.TextBox solZ;
        private System.Windows.Forms.TextBox solY;
        private System.Windows.Forms.Button buttonFinish;
    }
}