
namespace MyFirsrtWinForm
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
            this.textBox_Numar1 = new System.Windows.Forms.TextBox();
            this.button_Calculeaza = new System.Windows.Forms.Button();
            this.label_Scadere_value = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.textBox_Numar2 = new System.Windows.Forms.TextBox();
            this.label_Adunare = new System.Windows.Forms.Label();
            this.label_Inmultire_value = new System.Windows.Forms.Label();
            this.label_Impartire_value = new System.Windows.Forms.Label();
            this.label_Check1 = new System.Windows.Forms.Label();
            this.label_Check2 = new System.Windows.Forms.Label();
            this.button_Verifica = new System.Windows.Forms.Button();
            this.label_Adunare_value = new System.Windows.Forms.Label();
            this.label_Scadere = new System.Windows.Forms.Label();
            this.label_Inmultire = new System.Windows.Forms.Label();
            this.label_Impartire = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Numar1
            // 
            this.textBox_Numar1.Location = new System.Drawing.Point(32, 45);
            this.textBox_Numar1.Name = "textBox_Numar1";
            this.textBox_Numar1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Numar1.TabIndex = 0;
            this.textBox_Numar1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Numar1_KeyPress);
            // 
            // button_Calculeaza
            // 
            this.button_Calculeaza.Location = new System.Drawing.Point(292, 266);
            this.button_Calculeaza.Name = "button_Calculeaza";
            this.button_Calculeaza.Size = new System.Drawing.Size(75, 23);
            this.button_Calculeaza.TabIndex = 1;
            this.button_Calculeaza.Text = "Calculeaza";
            this.button_Calculeaza.UseVisualStyleBackColor = true;
            this.button_Calculeaza.Click += new System.EventHandler(this.button_Calculeaza_Click);
            // 
            // label_Scadere_value
            // 
            this.label_Scadere_value.AutoSize = true;
            this.label_Scadere_value.Location = new System.Drawing.Point(133, 241);
            this.label_Scadere_value.Name = "label_Scadere_value";
            this.label_Scadere_value.Size = new System.Drawing.Size(107, 13);
            this.label_Scadere_value.TabIndex = 2;
            this.label_Scadere_value.Text = "label_Scadere_value";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(703, 415);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 3;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // textBox_Numar2
            // 
            this.textBox_Numar2.Location = new System.Drawing.Point(267, 45);
            this.textBox_Numar2.Name = "textBox_Numar2";
            this.textBox_Numar2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Numar2.TabIndex = 4;
            this.textBox_Numar2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Numar2_KeyPress);
            // 
            // label_Adunare
            // 
            this.label_Adunare.AutoSize = true;
            this.label_Adunare.Location = new System.Drawing.Point(32, 182);
            this.label_Adunare.Name = "label_Adunare";
            this.label_Adunare.Size = new System.Drawing.Size(47, 13);
            this.label_Adunare.TabIndex = 5;
            this.label_Adunare.Text = "Adunare";
            // 
            // label_Inmultire_value
            // 
            this.label_Inmultire_value.AutoSize = true;
            this.label_Inmultire_value.Location = new System.Drawing.Point(133, 299);
            this.label_Inmultire_value.Name = "label_Inmultire_value";
            this.label_Inmultire_value.Size = new System.Drawing.Size(106, 13);
            this.label_Inmultire_value.TabIndex = 6;
            this.label_Inmultire_value.Text = "label_Inmultire_value";
            // 
            // label_Impartire_value
            // 
            this.label_Impartire_value.AutoSize = true;
            this.label_Impartire_value.Location = new System.Drawing.Point(132, 350);
            this.label_Impartire_value.Name = "label_Impartire_value";
            this.label_Impartire_value.Size = new System.Drawing.Size(107, 13);
            this.label_Impartire_value.TabIndex = 7;
            this.label_Impartire_value.Text = "label_Impartire_value";
            // 
            // label_Check1
            // 
            this.label_Check1.AutoSize = true;
            this.label_Check1.Location = new System.Drawing.Point(32, 97);
            this.label_Check1.Name = "label_Check1";
            this.label_Check1.Size = new System.Drawing.Size(72, 13);
            this.label_Check1.TabIndex = 10;
            this.label_Check1.Text = "label_Check1";
            // 
            // label_Check2
            // 
            this.label_Check2.AutoSize = true;
            this.label_Check2.Location = new System.Drawing.Point(264, 97);
            this.label_Check2.Name = "label_Check2";
            this.label_Check2.Size = new System.Drawing.Size(72, 13);
            this.label_Check2.TabIndex = 11;
            this.label_Check2.Text = "label_Check2";
            // 
            // button_Verifica
            // 
            this.button_Verifica.Location = new System.Drawing.Point(450, 45);
            this.button_Verifica.Name = "button_Verifica";
            this.button_Verifica.Size = new System.Drawing.Size(75, 23);
            this.button_Verifica.TabIndex = 12;
            this.button_Verifica.Text = "Verifica";
            this.button_Verifica.UseVisualStyleBackColor = true;
            this.button_Verifica.Click += new System.EventHandler(this.button_Verifica_Click);
            // 
            // label_Adunare_value
            // 
            this.label_Adunare_value.AutoSize = true;
            this.label_Adunare_value.Location = new System.Drawing.Point(133, 182);
            this.label_Adunare_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Adunare_value.Name = "label_Adunare_value";
            this.label_Adunare_value.Size = new System.Drawing.Size(107, 13);
            this.label_Adunare_value.TabIndex = 13;
            this.label_Adunare_value.Text = "label_Adunare_value";
            // 
            // label_Scadere
            // 
            this.label_Scadere.AutoSize = true;
            this.label_Scadere.Location = new System.Drawing.Point(35, 241);
            this.label_Scadere.Name = "label_Scadere";
            this.label_Scadere.Size = new System.Drawing.Size(47, 13);
            this.label_Scadere.TabIndex = 14;
            this.label_Scadere.Text = "Scadere";
            // 
            // label_Inmultire
            // 
            this.label_Inmultire.AutoSize = true;
            this.label_Inmultire.Location = new System.Drawing.Point(32, 299);
            this.label_Inmultire.Name = "label_Inmultire";
            this.label_Inmultire.Size = new System.Drawing.Size(46, 13);
            this.label_Inmultire.TabIndex = 15;
            this.label_Inmultire.Text = "Inmultire";
            // 
            // label_Impartire
            // 
            this.label_Impartire.AutoSize = true;
            this.label_Impartire.Location = new System.Drawing.Point(35, 350);
            this.label_Impartire.Name = "label_Impartire";
            this.label_Impartire.Size = new System.Drawing.Size(47, 13);
            this.label_Impartire.TabIndex = 16;
            this.label_Impartire.Text = "Impartire";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Impartire);
            this.Controls.Add(this.label_Inmultire);
            this.Controls.Add(this.label_Scadere);
            this.Controls.Add(this.label_Adunare_value);
            this.Controls.Add(this.button_Verifica);
            this.Controls.Add(this.label_Check2);
            this.Controls.Add(this.label_Check1);
            this.Controls.Add(this.label_Impartire_value);
            this.Controls.Add(this.label_Inmultire_value);
            this.Controls.Add(this.label_Adunare);
            this.Controls.Add(this.textBox_Numar2);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label_Scadere_value);
            this.Controls.Add(this.button_Calculeaza);
            this.Controls.Add(this.textBox_Numar1);
            this.Name = "Form1";
            this.Text = "Andrei";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Numar1;
        private System.Windows.Forms.Button button_Calculeaza;
        private System.Windows.Forms.Label label_Scadere_value;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.TextBox textBox_Numar2;
        private System.Windows.Forms.Label label_Adunare;
        private System.Windows.Forms.Label label_Inmultire_value;
        private System.Windows.Forms.Label label_Impartire_value;
        private System.Windows.Forms.Label label_Check1;
        private System.Windows.Forms.Label label_Check2;
        private System.Windows.Forms.Button button_Verifica;
        private System.Windows.Forms.Label label_Adunare_value;
        private System.Windows.Forms.Label label_Scadere;
        private System.Windows.Forms.Label label_Inmultire;
        private System.Windows.Forms.Label label_Impartire;
    }
}

