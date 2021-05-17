
namespace Kalkulator_ITE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wynik1 = new System.Windows.Forms.TextBox();
            this.MOD_button = new System.Windows.Forms.Button();
            this.NWW_button = new System.Windows.Forms.Button();
            this.NWD_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.textBox3);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.wynik1);
            this.splitContainer1.Panel1.Controls.Add(this.MOD_button);
            this.splitContainer1.Panel1.Controls.Add(this.NWW_button);
            this.splitContainer1.Panel1.Controls.Add(this.NWD_button);
            this.splitContainer1.Size = new System.Drawing.Size(914, 600);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "b";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "a";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 27);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(84, 27);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 28);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 27);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wynik:";
            // 
            // wynik1
            // 
            this.wynik1.Location = new System.Drawing.Point(106, 67);
            this.wynik1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wynik1.Name = "wynik1";
            this.wynik1.ReadOnly = true;
            this.wynik1.Size = new System.Drawing.Size(178, 27);
            this.wynik1.TabIndex = 3;
            // 
            // MOD_button
            // 
            this.MOD_button.Location = new System.Drawing.Point(199, 105);
            this.MOD_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MOD_button.Name = "MOD_button";
            this.MOD_button.Size = new System.Drawing.Size(86, 31);
            this.MOD_button.TabIndex = 2;
            this.MOD_button.Text = "MOD";
            this.MOD_button.UseVisualStyleBackColor = true;
            this.MOD_button.Click += new System.EventHandler(this.MOD_button_Click);
            // 
            // NWW_button
            // 
            this.NWW_button.Location = new System.Drawing.Point(106, 105);
            this.NWW_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NWW_button.Name = "NWW_button";
            this.NWW_button.Size = new System.Drawing.Size(86, 31);
            this.NWW_button.TabIndex = 1;
            this.NWW_button.Text = "NWW";
            this.NWW_button.UseVisualStyleBackColor = true;
            this.NWW_button.Click += new System.EventHandler(this.NWW_button_Click);
            // 
            // NWD_button
            // 
            this.NWD_button.Location = new System.Drawing.Point(14, 105);
            this.NWD_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NWD_button.Name = "NWD_button";
            this.NWD_button.Size = new System.Drawing.Size(86, 31);
            this.NWD_button.TabIndex = 0;
            this.NWD_button.Text = "NWD";
            this.NWD_button.UseVisualStyleBackColor = true;
            this.NWD_button.Click += new System.EventHandler(this.NWD_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Kalkulator ITE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox wynik1;
        private System.Windows.Forms.Button MOD_button;
        private System.Windows.Forms.Button NWW_button;
        private System.Windows.Forms.Button NWD_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

