
namespace CNPWinForm
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
            this.textBox_CNP = new System.Windows.Forms.TextBox();
            this.button_Verifica_CNP = new System.Windows.Forms.Button();
            this.label_CNP_value = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Afiseaza = new System.Windows.Forms.Button();
            this.label_Sex = new System.Windows.Forms.Label();
            this.label_An = new System.Windows.Forms.Label();
            this.label_Luna = new System.Windows.Forms.Label();
            this.label_Zi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_CNP
            // 
            this.textBox_CNP.Location = new System.Drawing.Point(76, 32);
            this.textBox_CNP.Name = "textBox_CNP";
            this.textBox_CNP.Size = new System.Drawing.Size(100, 20);
            this.textBox_CNP.TabIndex = 0;
            this.textBox_CNP.MouseHover += new System.EventHandler(this.textBox_CNP_MouseHover);
            // 
            // button_Verifica_CNP
            // 
            this.button_Verifica_CNP.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_Verifica_CNP.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_Verifica_CNP.Location = new System.Drawing.Point(281, 32);
            this.button_Verifica_CNP.Name = "button_Verifica_CNP";
            this.button_Verifica_CNP.Size = new System.Drawing.Size(81, 23);
            this.button_Verifica_CNP.TabIndex = 1;
            this.button_Verifica_CNP.Text = "Verifica_CNP";
            this.button_Verifica_CNP.UseVisualStyleBackColor = false;
            this.button_Verifica_CNP.Click += new System.EventHandler(this.button_Verifica_CNP_Click);
            // 
            // label_CNP_value
            // 
            this.label_CNP_value.AutoSize = true;
            this.label_CNP_value.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_CNP_value.Location = new System.Drawing.Point(73, 84);
            this.label_CNP_value.Name = "label_CNP_value";
            this.label_CNP_value.Size = new System.Drawing.Size(61, 13);
            this.label_CNP_value.TabIndex = 2;
            this.label_CNP_value.Text = "CNP_value";
            // 
            // button_Clear
            // 
            this.button_Clear.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button_Clear.Location = new System.Drawing.Point(688, 400);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 4;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Afiseaza
            // 
            this.button_Afiseaza.Location = new System.Drawing.Point(287, 134);
            this.button_Afiseaza.Name = "button_Afiseaza";
            this.button_Afiseaza.Size = new System.Drawing.Size(75, 23);
            this.button_Afiseaza.TabIndex = 5;
            this.button_Afiseaza.Text = "Afiseaza";
            this.button_Afiseaza.UseVisualStyleBackColor = true;
            this.button_Afiseaza.Click += new System.EventHandler(this.button_Afiseaza_Click);
            // 
            // label_Sex
            // 
            this.label_Sex.AutoSize = true;
            this.label_Sex.Location = new System.Drawing.Point(76, 139);
            this.label_Sex.Name = "label_Sex";
            this.label_Sex.Size = new System.Drawing.Size(25, 13);
            this.label_Sex.TabIndex = 6;
            this.label_Sex.Text = "Sex";
            // 
            // label_An
            // 
            this.label_An.AutoSize = true;
            this.label_An.Location = new System.Drawing.Point(76, 177);
            this.label_An.Name = "label_An";
            this.label_An.Size = new System.Drawing.Size(20, 13);
            this.label_An.TabIndex = 7;
            this.label_An.Text = "An";
            // 
            // label_Luna
            // 
            this.label_Luna.AutoSize = true;
            this.label_Luna.Location = new System.Drawing.Point(76, 222);
            this.label_Luna.Name = "label_Luna";
            this.label_Luna.Size = new System.Drawing.Size(31, 13);
            this.label_Luna.TabIndex = 8;
            this.label_Luna.Text = "Luna";
            // 
            // label_Zi
            // 
            this.label_Zi.AutoSize = true;
            this.label_Zi.Location = new System.Drawing.Point(76, 267);
            this.label_Zi.Name = "label_Zi";
            this.label_Zi.Size = new System.Drawing.Size(16, 13);
            this.label_Zi.TabIndex = 9;
            this.label_Zi.Text = "Zi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Zi);
            this.Controls.Add(this.label_Luna);
            this.Controls.Add(this.label_An);
            this.Controls.Add(this.label_Sex);
            this.Controls.Add(this.button_Afiseaza);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label_CNP_value);
            this.Controls.Add(this.button_Verifica_CNP);
            this.Controls.Add(this.textBox_CNP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_CNP;
        private System.Windows.Forms.Button button_Verifica_CNP;
        private System.Windows.Forms.Label label_CNP_value;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Afiseaza;
        private System.Windows.Forms.Label label_Sex;
        private System.Windows.Forms.Label label_An;
        private System.Windows.Forms.Label label_Luna;
        private System.Windows.Forms.Label label_Zi;
    }
}

