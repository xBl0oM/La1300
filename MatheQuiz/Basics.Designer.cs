namespace MatheQuiz
{
    partial class Basics
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.questionA = new System.Windows.Forms.TextBox();
            this.solution1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // questionA
            // 
            this.questionA.Location = new System.Drawing.Point(224, 168);
            this.questionA.Multiline = true;
            this.questionA.Name = "questionA";
            this.questionA.ReadOnly = true;
            this.questionA.Size = new System.Drawing.Size(216, 51);
            this.questionA.TabIndex = 2;
            // 
            // solution1
            // 
            this.solution1.BackColor = System.Drawing.Color.DarkGray;
            this.solution1.Location = new System.Drawing.Point(435, 168);
            this.solution1.Multiline = true;
            this.solution1.Name = "solution1";
            this.solution1.Size = new System.Drawing.Size(76, 51);
            this.solution1.TabIndex = 3;
            this.solution1.TextChanged += new System.EventHandler(this.solution1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Basics";
            // 
            // Basics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.solution1);
            this.Controls.Add(this.questionA);
            this.Name = "Basics";
            this.Text = "Basics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox questionA;
        private System.Windows.Forms.TextBox solution1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}