namespace PROVATOPICO
{
    partial class FormPrinci
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
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btAgendar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(173, 12);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(96, 35);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btAgendar
            // 
            this.btAgendar.Location = new System.Drawing.Point(275, 12);
            this.btAgendar.Name = "btAgendar";
            this.btAgendar.Size = new System.Drawing.Size(157, 35);
            this.btAgendar.TabIndex = 1;
            this.btAgendar.Text = "Agendar Consulta";
            this.btAgendar.UseVisualStyleBackColor = true;
            this.btAgendar.Click += new System.EventHandler(this.btAgendar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Consultar Agenda";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btConsulta
            // 
            this.btConsulta.Location = new System.Drawing.Point(10, 12);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(157, 35);
            this.btConsulta.TabIndex = 3;
            this.btConsulta.Text = "Consultar Pacientes";
            this.btConsulta.UseVisualStyleBackColor = true;
            // 
            // FormPrinci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 308);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btAgendar);
            this.Controls.Add(this.btCadastrar);
            this.Name = "FormPrinci";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btAgendar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btConsulta;
    }
}