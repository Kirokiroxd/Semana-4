
namespace _01_Mi_Primera_Vez.Presentacion
{
    partial class MenuPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRespaldos = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnAsistencias = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.PanelGeneral = new System.Windows.Forms.Panel();
            this.Panel_Bienvenida = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.PanelGeneral.SuspendLayout();
            this.Panel_Bienvenida.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnRespaldos);
            this.panel1.Controls.Add(this.btnRestaurar);
            this.panel1.Controls.Add(this.btnPersonal);
            this.panel1.Controls.Add(this.btnAsistencias);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 749);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 760);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Control de Asistencia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::_01_Mi_Primera_Vez.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 571);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnRespaldos
            // 
            this.btnRespaldos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRespaldos.Image = global::_01_Mi_Primera_Vez.Properties.Resources.archivo_de_base_de_datos;
            this.btnRespaldos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRespaldos.Location = new System.Drawing.Point(0, 484);
            this.btnRespaldos.Name = "btnRespaldos";
            this.btnRespaldos.Size = new System.Drawing.Size(212, 87);
            this.btnRespaldos.TabIndex = 3;
            this.btnRespaldos.Text = "Respaldos";
            this.btnRespaldos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRespaldos.UseVisualStyleBackColor = true;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRestaurar.Image = global::_01_Mi_Primera_Vez.Properties.Resources.recuperacion_de_datos;
            this.btnRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurar.Location = new System.Drawing.Point(0, 398);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(212, 86);
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.Text = "Restaurar BD";
            this.btnRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // btnPersonal
            // 
            this.btnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.Image = global::_01_Mi_Primera_Vez.Properties.Resources.grupo_de_trabajo;
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.Location = new System.Drawing.Point(0, 301);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(212, 97);
            this.btnPersonal.TabIndex = 1;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPerosnal_Click);
            // 
            // btnAsistencias
            // 
            this.btnAsistencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(124)))));
            this.btnAsistencias.Image = global::_01_Mi_Primera_Vez.Properties.Resources.asistencia;
            this.btnAsistencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencias.Location = new System.Drawing.Point(0, 206);
            this.btnAsistencias.Name = "btnAsistencias";
            this.btnAsistencias.Size = new System.Drawing.Size(212, 95);
            this.btnAsistencias.TabIndex = 0;
            this.btnAsistencias.Text = "Asistencia";
            this.btnAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsistencias.UseVisualStyleBackColor = true;
            this.btnAsistencias.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnUsuarios);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 206);
            this.panel3.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(212, 97);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.BackColor = System.Drawing.Color.SkyBlue;
            this.PanelGeneral.Controls.Add(this.Panel_Bienvenida);
            this.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGeneral.Location = new System.Drawing.Point(212, 0);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.Size = new System.Drawing.Size(873, 749);
            this.PanelGeneral.TabIndex = 1;
            // 
            // Panel_Bienvenida
            // 
            this.Panel_Bienvenida.Controls.Add(this.label2);
            this.Panel_Bienvenida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Bienvenida.Location = new System.Drawing.Point(0, 0);
            this.Panel_Bienvenida.Name = "Panel_Bienvenida";
            this.Panel_Bienvenida.Size = new System.Drawing.Size(873, 749);
            this.Panel_Bienvenida.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(873, 749);
            this.label2.TabIndex = 0;
            this.label2.Text = "BIENVENIDO AL SISTEMA DE CONTROL DE ASISTENCIAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1085, 749);
            this.Controls.Add(this.PanelGeneral);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.PanelGeneral.ResumeLayout(false);
            this.Panel_Bienvenida.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelGeneral;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAsistencias;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnRespaldos;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_Bienvenida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUsuarios;
    }
}