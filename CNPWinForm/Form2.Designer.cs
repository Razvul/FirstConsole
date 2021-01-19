
namespace CNPWinForm
{
    partial class Form2
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
            this.button_Creaza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Sex_Input = new System.Windows.Forms.TextBox();
            this.label_Debug = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Creaza
            // 
            this.button_Creaza.Location = new System.Drawing.Point(300, 58);
            this.button_Creaza.Name = "button_Creaza";
            this.button_Creaza.Size = new System.Drawing.Size(75, 23);
            this.button_Creaza.TabIndex = 0;
            this.button_Creaza.Text = "Creaza";
            this.button_Creaza.UseVisualStyleBackColor = true;
            this.button_Creaza.Click += new System.EventHandler(this.button_Creaza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sex";
            // 
            // textBox_Sex_Input
            // 
            this.textBox_Sex_Input.Location = new System.Drawing.Point(149, 58);
            this.textBox_Sex_Input.Name = "textBox_Sex_Input";
            this.textBox_Sex_Input.Size = new System.Drawing.Size(100, 20);
            this.textBox_Sex_Input.TabIndex = 2;
            // 
            // label_Debug
            // 
            this.label_Debug.AutoSize = true;
            this.label_Debug.Location = new System.Drawing.Point(641, 68);
            this.label_Debug.Name = "label_Debug";
            this.label_Debug.Size = new System.Drawing.Size(39, 13);
            this.label_Debug.TabIndex = 3;
            this.label_Debug.Text = "Debug";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Debug);
            this.Controls.Add(this.textBox_Sex_Input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Creaza);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Creaza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Sex_Input;
        private System.Windows.Forms.Label label_Debug;
    }
}