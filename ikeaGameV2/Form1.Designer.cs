namespace ikeaGameV2
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
            this.questionOutput = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.Button();
            this.input2 = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // questionOutput
            // 
            this.questionOutput.BackColor = System.Drawing.Color.White;
            this.questionOutput.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionOutput.Location = new System.Drawing.Point(266, 368);
            this.questionOutput.Name = "questionOutput";
            this.questionOutput.Size = new System.Drawing.Size(274, 73);
            this.questionOutput.TabIndex = 9;
            this.questionOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // input1
            // 
            this.input1.BackColor = System.Drawing.Color.Yellow;
            this.input1.FlatAppearance.BorderSize = 0;
            this.input1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input1.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(74, 378);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(152, 51);
            this.input1.TabIndex = 8;
            this.input1.UseVisualStyleBackColor = false;
            this.input1.Click += new System.EventHandler(this.input1_Click);
            // 
            // input2
            // 
            this.input2.BackColor = System.Drawing.Color.Yellow;
            this.input2.FlatAppearance.BorderSize = 0;
            this.input2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input2.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2.Location = new System.Drawing.Point(592, 378);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(150, 51);
            this.input2.TabIndex = 7;
            this.input2.UseVisualStyleBackColor = false;
            this.input2.Click += new System.EventHandler(this.input2_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(37, 28);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(727, 81);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.Location = new System.Drawing.Point(37, 112);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(727, 253);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.questionOutput);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label questionOutput;
        private System.Windows.Forms.Button input1;
        private System.Windows.Forms.Button input2;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

