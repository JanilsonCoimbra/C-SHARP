
namespace Atividade_07
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
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lbl_resultado.Location = new System.Drawing.Point(62, 49);
            this.lbl_resultado.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_resultado.MaximumSize = new System.Drawing.Size(900, 40);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Padding = new System.Windows.Forms.Padding(0, 0, 70, 0);
            this.lbl_resultado.Size = new System.Drawing.Size(584, 39);
            this.lbl_resultado.TabIndex = 0;
            this.lbl_resultado.Text = "A soma entre valor 1 e valor 2 é: ";
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_resultado.Click += new System.EventHandler(this.lbl_resultado_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.lbl_resultado);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_resultado;
    }
}