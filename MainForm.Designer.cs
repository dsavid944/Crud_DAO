namespace Crud_DAO
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = global::Crud_DAO.Properties.Resources.Logo_Sin_Fondo;
            this.Logo.Location = new System.Drawing.Point(344, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(150, 146);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(320, 220);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(199, 38);
            this.btnVer.TabIndex = 1;
            this.btnVer.Text = "Ver Funcionarios";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(320, 285);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(199, 38);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Funcionario";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.Location = new System.Drawing.Point(320, 349);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(199, 38);
            this.btnGestion.TabIndex = 3;
            this.btnGestion.Text = "Gestión de Funcionarios";
            this.btnGestion.UseVisualStyleBackColor = true;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 483);
            this.Controls.Add(this.btnGestion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.Logo);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGestion;
    }
}
