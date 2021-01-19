
namespace CNPWinForm
{
    partial class StartForm
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
            this.button_Verifica = new System.Windows.Forms.Button();
            this.button_Calculeaza = new System.Windows.Forms.Button();
            this.label_BunVenit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Verifica
            // 
            this.button_Verifica.Location = new System.Drawing.Point(25, 34);
            this.button_Verifica.Name = "button_Verifica";
            this.button_Verifica.Size = new System.Drawing.Size(75, 23);
            this.button_Verifica.TabIndex = 0;
            this.button_Verifica.Text = "Verifica";
            this.button_Verifica.UseVisualStyleBackColor = true;
            this.button_Verifica.Click += new System.EventHandler(this.button_Verifica_Click);
            // 
            // button_Calculeaza
            // 
            this.button_Calculeaza.Location = new System.Drawing.Point(163, 34);
            this.button_Calculeaza.Name = "button_Calculeaza";
            this.button_Calculeaza.Size = new System.Drawing.Size(75, 23);
            this.button_Calculeaza.TabIndex = 1;
            this.button_Calculeaza.Text = "Calculeaza";
            this.button_Calculeaza.UseVisualStyleBackColor = true;
            this.button_Calculeaza.Click += new System.EventHandler(this.button_Calculeaza_Click);
            // 
            // label_BunVenit
            // 
            this.label_BunVenit.AutoSize = true;
            this.label_BunVenit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_BunVenit.Location = new System.Drawing.Point(64, 120);
            this.label_BunVenit.Name = "label_BunVenit";
            this.label_BunVenit.Size = new System.Drawing.Size(50, 13);
            this.label_BunVenit.TabIndex = 2;
            this.label_BunVenit.Text = "BunVenit";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 215);
            this.Controls.Add(this.label_BunVenit);
            this.Controls.Add(this.button_Calculeaza);
            this.Controls.Add(this.button_Verifica);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Verifica;
        private System.Windows.Forms.Button button_Calculeaza;
        private System.Windows.Forms.Label label_BunVenit;
    }
}