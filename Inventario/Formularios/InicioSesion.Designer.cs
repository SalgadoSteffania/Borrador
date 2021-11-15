
namespace Inventario.Formularios
{
    partial class InicioSesion
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
            this.TITULO = new System.Windows.Forms.Label();
            this.SUBTITULO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnNoIngresar = new System.Windows.Forms.Button();
            this.pnlinicioSesion = new System.Windows.Forms.Panel();
            this.pnlinicioSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // TITULO
            // 
            this.TITULO.AutoSize = true;
            this.TITULO.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITULO.ForeColor = System.Drawing.Color.White;
            this.TITULO.Location = new System.Drawing.Point(12, 32);
            this.TITULO.Name = "TITULO";
            this.TITULO.Size = new System.Drawing.Size(761, 44);
            this.TITULO.TabIndex = 0;
            this.TITULO.Text = "SISTEMA DE INVENTARIO Y FACTURACIÓN";
            // 
            // SUBTITULO
            // 
            this.SUBTITULO.AutoSize = true;
            this.SUBTITULO.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBTITULO.ForeColor = System.Drawing.Color.White;
            this.SUBTITULO.Location = new System.Drawing.Point(286, 96);
            this.SUBTITULO.Name = "SUBTITULO";
            this.SUBTITULO.Size = new System.Drawing.Size(202, 35);
            this.SUBTITULO.TabIndex = 1;
            this.SUBTITULO.Text = "Inicio de Sesión";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(88, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(156, 201);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(332, 26);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(156, 300);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(332, 26);
            this.txtContraseña.TabIndex = 5;
            // 
            // btnIngresar
            // 
            this.btnIngresar.ForeColor = System.Drawing.Color.Green;
            this.btnIngresar.Location = new System.Drawing.Point(127, 388);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(128, 30);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Iniciar Sesión";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnNoIngresar
            // 
            this.btnNoIngresar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnNoIngresar.Location = new System.Drawing.Point(305, 388);
            this.btnNoIngresar.Name = "btnNoIngresar";
            this.btnNoIngresar.Size = new System.Drawing.Size(128, 30);
            this.btnNoIngresar.TabIndex = 7;
            this.btnNoIngresar.Text = "Cancelar";
            this.btnNoIngresar.UseVisualStyleBackColor = true;
            // 
            // pnlinicioSesion
            // 
            this.pnlinicioSesion.Controls.Add(this.btnNoIngresar);
            this.pnlinicioSesion.Controls.Add(this.btnIngresar);
            this.pnlinicioSesion.Controls.Add(this.txtContraseña);
            this.pnlinicioSesion.Controls.Add(this.txtUsuario);
            this.pnlinicioSesion.Controls.Add(this.label4);
            this.pnlinicioSesion.Controls.Add(this.label3);
            this.pnlinicioSesion.Controls.Add(this.SUBTITULO);
            this.pnlinicioSesion.Controls.Add(this.TITULO);
            this.pnlinicioSesion.Location = new System.Drawing.Point(15, 8);
            this.pnlinicioSesion.Name = "pnlinicioSesion";
            this.pnlinicioSesion.Size = new System.Drawing.Size(785, 449);
            this.pnlinicioSesion.TabIndex = 8;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(823, 468);
            this.Controls.Add(this.pnlinicioSesion);
            this.Name = "InicioSesion";
            this.Text = "Inicio de sesión";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlinicioSesion.ResumeLayout(false);
            this.pnlinicioSesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TITULO;
        private System.Windows.Forms.Label SUBTITULO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnNoIngresar;
        private System.Windows.Forms.Panel pnlinicioSesion;
    }
}