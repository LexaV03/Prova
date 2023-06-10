namespace PROVATOPICO
{
    partial class FormAgendar
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
            this.btAgendar = new System.Windows.Forms.Button();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbDia = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btVoltar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAgendar
            // 
            this.btAgendar.Location = new System.Drawing.Point(278, 193);
            this.btAgendar.Name = "btAgendar";
            this.btAgendar.Size = new System.Drawing.Size(95, 23);
            this.btAgendar.TabIndex = 13;
            this.btAgendar.Text = "Agendar";
            this.btAgendar.UseVisualStyleBackColor = true;
            this.btAgendar.Click += new System.EventHandler(this.btAgendar_Click);
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(234, 156);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(191, 22);
            this.txtHorario.TabIndex = 12;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(234, 128);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(191, 22);
            this.txtDia.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(234, 100);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(191, 22);
            this.txtID.TabIndex = 10;
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.Location = new System.Drawing.Point(168, 156);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(52, 16);
            this.lbHorario.TabIndex = 9;
            this.lbHorario.Text = "Horário";
            // 
            // lbDia
            // 
            this.lbDia.AutoSize = true;
            this.lbDia.Location = new System.Drawing.Point(184, 128);
            this.lbDia.Name = "lbDia";
            this.lbDia.Size = new System.Drawing.Size(36, 16);
            this.lbDia.TabIndex = 8;
            this.lbDia.Text = "Data";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(152, 100);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(76, 16);
            this.lbID.TabIndex = 7;
            this.lbID.Text = "ID Paciente";
            // 
            // btVoltar2
            // 
            this.btVoltar2.Location = new System.Drawing.Point(278, 234);
            this.btVoltar2.Name = "btVoltar2";
            this.btVoltar2.Size = new System.Drawing.Size(95, 23);
            this.btVoltar2.TabIndex = 14;
            this.btVoltar2.Text = "Voltar";
            this.btVoltar2.UseVisualStyleBackColor = true;
            this.btVoltar2.Click += new System.EventHandler(this.btVoltar2_Click);
            // 
            // FormAgendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 317);
            this.Controls.Add(this.btVoltar2);
            this.Controls.Add(this.btAgendar);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbHorario);
            this.Controls.Add(this.lbDia);
            this.Controls.Add(this.lbID);
            this.Name = "FormAgendar";
            this.Text = "FormAgendar";
            this.Load += new System.EventHandler(this.FormAgendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgendar;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Label lbDia;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btVoltar2;
    }
}