
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
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "b";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "a";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(74, 23);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wynik:";
            // 
            // wynik1
            // 
            this.wynik1.Location = new System.Drawing.Point(93, 50);
            this.wynik1.Name = "wynik1";
            this.wynik1.ReadOnly = true;
            this.wynik1.Size = new System.Drawing.Size(156, 23);
            this.wynik1.TabIndex = 3;
            this.wynik1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MOD_button
            // 
            this.MOD_button.Location = new System.Drawing.Point(174, 79);
            this.MOD_button.Name = "MOD_button";
            this.MOD_button.Size = new System.Drawing.Size(75, 23);
            this.MOD_button.TabIndex = 2;
            this.MOD_button.Text = "MOD";
            this.MOD_button.UseVisualStyleBackColor = true;
            this.MOD_button.Click += new System.EventHandler(this.MOD_button_Click);
            // 
            // NWW_button
            // 
            this.NWW_button.Location = new System.Drawing.Point(93, 79);
            this.NWW_button.Name = "NWW_button";
            this.NWW_button.Size = new System.Drawing.Size(75, 23);
            this.NWW_button.TabIndex = 1;
            this.NWW_button.Text = "NWW";
            this.NWW_button.UseVisualStyleBackColor = true;
            // 
            // NWD_button
            // 
            this.NWD_button.Location = new System.Drawing.Point(12, 79);
            this.NWD_button.Name = "NWD_button";
            this.NWD_button.Size = new System.Drawing.Size(75, 23);
            this.NWD_button.TabIndex = 0;
            this.NWD_button.Text = "NWD";
            this.NWD_button.UseVisualStyleBackColor = true;
            this.NWD_button.Click += new System.EventHandler(this.NWD_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
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

