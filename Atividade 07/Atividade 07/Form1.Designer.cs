
namespace Atividade_07
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Valor1 = new System.Windows.Forms.Label();
            this.lbl_Valor2 = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lbl_Txt_Resultado = new System.Windows.Forms.Label();
            this.barra_Progresso = new System.Windows.Forms.ProgressBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Valor1
            // 
            resources.ApplyResources(this.lbl_Valor1, "lbl_Valor1");
            this.lbl_Valor1.Name = "lbl_Valor1";
            // 
            // lbl_Valor2
            // 
            resources.ApplyResources(this.lbl_Valor2, "lbl_Valor2");
            this.lbl_Valor2.Name = "lbl_Valor2";
            // 
            // btn_Calcular
            // 
            resources.ApplyResources(this.btn_Calcular, "btn_Calcular");
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Sair
            // 
            resources.ApplyResources(this.btn_Sair, "btn_Sair");
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lbl_Txt_Resultado
            // 
            resources.ApplyResources(this.lbl_Txt_Resultado, "lbl_Txt_Resultado");
            this.lbl_Txt_Resultado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Txt_Resultado.Name = "lbl_Txt_Resultado";
            this.lbl_Txt_Resultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // barra_Progresso
            // 
            resources.ApplyResources(this.barra_Progresso, "barra_Progresso");
            this.barra_Progresso.Name = "barra_Progresso";
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            this.textBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            this.textBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // lbl_Resultado
            // 
            resources.ApplyResources(this.lbl_Resultado, "lbl_Resultado");
            this.lbl_Resultado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Resultado.Name = "lbl_Resultado";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.barra_Progresso);
            this.Controls.Add(this.lbl_Txt_Resultado);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lbl_Valor2);
            this.Controls.Add(this.lbl_Valor1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Valor1;
        private System.Windows.Forms.Label lbl_Valor2;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lbl_Txt_Resultado;
        private System.Windows.Forms.ProgressBar barra_Progresso;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button button1;
    }
}

