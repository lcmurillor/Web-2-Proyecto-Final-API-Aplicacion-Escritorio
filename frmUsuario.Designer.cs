﻿
namespace WindowsFormsProyecto2
{
    partial class frmUsuario
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
            this.pnlGeneralUsuario = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboxEmpleado = new System.Windows.Forms.ComboBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnActualiszar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNumeroSucursal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.cboxRol = new System.Windows.Forms.ComboBox();
            this.pnlGeneralUsuario.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGeneralUsuario
            // 
            this.pnlGeneralUsuario.Controls.Add(this.panel3);
            this.pnlGeneralUsuario.Controls.Add(this.dgvFactura);
            this.pnlGeneralUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneralUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlGeneralUsuario.Name = "pnlGeneralUsuario";
            this.pnlGeneralUsuario.Size = new System.Drawing.Size(1264, 654);
            this.pnlGeneralUsuario.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cboxRol);
            this.panel3.Controls.Add(this.txtContrasena);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Controls.Add(this.cboxEmpleado);
            this.panel3.Controls.Add(this.btnAnular);
            this.panel3.Controls.Add(this.btnActualiszar);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.txtNumeroSucursal);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1240, 277);
            this.panel3.TabIndex = 34;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(229, 77);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(397, 20);
            this.txtContrasena.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "ROL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "CONTRASEÑA";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(818, 209);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 63);
            this.btnAgregar.TabIndex = 46;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cboxEmpleado
            // 
            this.cboxEmpleado.FormattingEnabled = true;
            this.cboxEmpleado.Location = new System.Drawing.Point(229, 113);
            this.cboxEmpleado.Name = "cboxEmpleado";
            this.cboxEmpleado.Size = new System.Drawing.Size(398, 21);
            this.cboxEmpleado.TabIndex = 37;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(1100, 209);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(135, 63);
            this.btnAnular.TabIndex = 34;
            this.btnAnular.Text = "ANULAR";
            this.btnAnular.UseVisualStyleBackColor = true;
            // 
            // btnActualiszar
            // 
            this.btnActualiszar.Location = new System.Drawing.Point(959, 209);
            this.btnActualiszar.Name = "btnActualiszar";
            this.btnActualiszar.Size = new System.Drawing.Size(135, 63);
            this.btnActualiszar.TabIndex = 33;
            this.btnActualiszar.Text = "ACTUALIZAR ";
            this.btnActualiszar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(467, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(159, 23);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "BUSCAR NOMBRE";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNumeroSucursal
            // 
            this.txtNumeroSucursal.Location = new System.Drawing.Point(229, 36);
            this.txtNumeroSucursal.Name = "txtNumeroSucursal";
            this.txtNumeroSucursal.Size = new System.Drawing.Size(218, 20);
            this.txtNumeroSucursal.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "EMPLEADO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "NOMBRE DE USUARIO";
            // 
            // dgvFactura
            // 
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(12, 295);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.RowHeadersWidth = 51;
            this.dgvFactura.Size = new System.Drawing.Size(1240, 347);
            this.dgvFactura.TabIndex = 33;
            // 
            // cboxRol
            // 
            this.cboxRol.FormattingEnabled = true;
            this.cboxRol.Location = new System.Drawing.Point(229, 152);
            this.cboxRol.Name = "cboxRol";
            this.cboxRol.Size = new System.Drawing.Size(398, 21);
            this.cboxRol.TabIndex = 58;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 654);
            this.Controls.Add(this.pnlGeneralUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.pnlGeneralUsuario.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneralUsuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboxEmpleado;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnActualiszar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNumeroSucursal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.ComboBox cboxRol;
    }
}