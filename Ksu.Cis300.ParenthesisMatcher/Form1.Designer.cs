namespace Ksu.Cis300.ParenthesisMatcher
{
    partial class uxWindow
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
            this.uxLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxTextBox = new System.Windows.Forms.TextBox();
            this.uxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxLabel
            // 
            this.uxLabel.AutoSize = true;
            this.uxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabel.Location = new System.Drawing.Point(12, 42);
            this.uxLabel.Name = "uxLabel";
            this.uxLabel.Size = new System.Drawing.Size(98, 20);
            this.uxLabel.TabIndex = 0;
            this.uxLabel.Text = "Enter String:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(57, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // uxTextBox
            // 
            this.uxTextBox.Location = new System.Drawing.Point(116, 42);
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.Size = new System.Drawing.Size(255, 20);
            this.uxTextBox.TabIndex = 2;
            // 
            // uxButton
            // 
            this.uxButton.Location = new System.Drawing.Point(116, 78);
            this.uxButton.Name = "uxButton";
            this.uxButton.Size = new System.Drawing.Size(115, 29);
            this.uxButton.TabIndex = 3;
            this.uxButton.Text = "Check";
            this.uxButton.UseVisualStyleBackColor = true;
            this.uxButton.Click += new System.EventHandler(this.uxButton_Click);
            // 
            // uxWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 119);
            this.Controls.Add(this.uxButton);
            this.Controls.Add(this.uxTextBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.uxLabel);
            this.Name = "uxWindow";
            this.Text = "Parenthesis Matcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox uxTextBox;
        private System.Windows.Forms.Button uxButton;
    }
}

