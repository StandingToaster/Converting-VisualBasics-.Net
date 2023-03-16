namespace AquariumTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonUS = new System.Windows.Forms.RadioButton();
            this.radioButtonUK = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonUS
            // 
            this.radioButtonUS.AutoSize = true;
            this.radioButtonUS.Checked = true;
            this.radioButtonUS.Location = new System.Drawing.Point(122, 103);
            this.radioButtonUS.Name = "radioButtonUS";
            this.radioButtonUS.Size = new System.Drawing.Size(40, 17);
            this.radioButtonUS.TabIndex = 2;
            this.radioButtonUS.TabStop = true;
            this.radioButtonUS.Text = "US";
            this.radioButtonUS.UseVisualStyleBackColor = true;
            // 
            // radioButtonUK
            // 
            this.radioButtonUK.AutoSize = true;
            this.radioButtonUK.Location = new System.Drawing.Point(122, 126);
            this.radioButtonUK.Name = "radioButtonUK";
            this.radioButtonUK.Size = new System.Drawing.Size(40, 17);
            this.radioButtonUK.TabIndex = 3;
            this.radioButtonUK.Text = "UK";
            this.radioButtonUK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Location:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonUK);
            this.Controls.Add(this.radioButtonUS);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonUS;
        private System.Windows.Forms.RadioButton radioButtonUK;
        private System.Windows.Forms.Label label1;
    }
}

