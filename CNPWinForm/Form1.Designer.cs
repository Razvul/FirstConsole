
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
            this.SuspendLayout();
            // 
            // textBox_CNP
            // 
            this.textBox_CNP.Location = new System.Drawing.Point(76, 32);
            this.textBox_CNP.Name = "textBox_CNP";
            this.textBox_CNP.Size = new System.Drawing.Size(100, 20);
            this.textBox_CNP.TabIndex = 0;
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
            this.label_CNP_value.Location = new System.Drawing.Point(76, 119);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label_CNP_value);
            this.Controls.Add(this.button_Verifica_CNP);
            this.Controls.Add(this.textBox_CNP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_CNP;
        private System.Windows.Forms.Button button_Verifica_CNP;
        private System.Windows.Forms.Label label_CNP_value;
        private System.Windows.Forms.Button button_Clear;
    }
}

