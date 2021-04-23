
namespace converter
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
            this.mainBox = new System.Windows.Forms.ComboBox();
            this.convertfrombox = new System.Windows.Forms.ComboBox();
            this.converttobox = new System.Windows.Forms.ComboBox();
            this.insertvaluebox = new System.Windows.Forms.TextBox();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainBox
            // 
            this.mainBox.FormattingEnabled = true;
            this.mainBox.Location = new System.Drawing.Point(163, 51);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(327, 21);
            this.mainBox.TabIndex = 0;
            this.mainBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // convertfrombox
            // 
            this.convertfrombox.FormattingEnabled = true;
            this.convertfrombox.Location = new System.Drawing.Point(253, 170);
            this.convertfrombox.Name = "convertfrombox";
            this.convertfrombox.Size = new System.Drawing.Size(237, 21);
            this.convertfrombox.TabIndex = 1;
            this.convertfrombox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // converttobox
            // 
            this.converttobox.FormattingEnabled = true;
            this.converttobox.Location = new System.Drawing.Point(253, 264);
            this.converttobox.Name = "converttobox";
            this.converttobox.Size = new System.Drawing.Size(237, 21);
            this.converttobox.TabIndex = 2;
            this.converttobox.SelectedIndexChanged += new System.EventHandler(this.converttobox_SelectedIndexChanged);
            // 
            // insertvaluebox
            // 
            this.insertvaluebox.Location = new System.Drawing.Point(116, 170);
            this.insertvaluebox.Name = "insertvaluebox";
            this.insertvaluebox.Size = new System.Drawing.Size(100, 20);
            this.insertvaluebox.TabIndex = 3;
            this.insertvaluebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // resultbox
            // 
            this.resultbox.Location = new System.Drawing.Point(116, 264);
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(100, 20);
            this.resultbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SELECT MEASURES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CONVERT TO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CONVERT FROM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 310);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.insertvaluebox);
            this.Controls.Add(this.converttobox);
            this.Controls.Add(this.convertfrombox);
            this.Controls.Add(this.mainBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox mainBox;
        private System.Windows.Forms.ComboBox convertfrombox;
        private System.Windows.Forms.ComboBox converttobox;
        private System.Windows.Forms.TextBox insertvaluebox;
        private System.Windows.Forms.TextBox resultbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

