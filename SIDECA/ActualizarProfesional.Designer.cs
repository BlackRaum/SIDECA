namespace SIDECA
{
    partial class ActualizarProfesional
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
            this.cbDepartamentosProfesional = new System.Windows.Forms.ComboBox();
            this.txtCorreoProfesional = new System.Windows.Forms.TextBox();
            this.txtTelefonoProfesional = new System.Windows.Forms.TextBox();
            this.lbErrorCorreo = new System.Windows.Forms.Label();
            this.lbErrorTelefono = new System.Windows.Forms.Label();
            this.lbErrorEspecialidad = new System.Windows.Forms.Label();
            this.lbErrorNombre = new System.Windows.Forms.Label();
            this.btnEditarProfesional = new System.Windows.Forms.Button();
            this.txtEspecialidadProfesional = new System.Windows.Forms.TextBox();
            this.txtNombreProfesional = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbDepartamentosProfesional
            // 
            this.cbDepartamentosProfesional.BackColor = System.Drawing.SystemColors.Info;
            this.cbDepartamentosProfesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamentosProfesional.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartamentosProfesional.FormattingEnabled = true;
            this.cbDepartamentosProfesional.Location = new System.Drawing.Point(427, 443);
            this.cbDepartamentosProfesional.Name = "cbDepartamentosProfesional";
            this.cbDepartamentosProfesional.Size = new System.Drawing.Size(280, 31);
            this.cbDepartamentosProfesional.TabIndex = 83;
            // 
            // txtCorreoProfesional
            // 
            this.txtCorreoProfesional.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoProfesional.ForeColor = System.Drawing.Color.Gray;
            this.txtCorreoProfesional.Location = new System.Drawing.Point(427, 376);
            this.txtCorreoProfesional.Name = "txtCorreoProfesional";
            this.txtCorreoProfesional.Size = new System.Drawing.Size(280, 30);
            this.txtCorreoProfesional.TabIndex = 80;
            this.txtCorreoProfesional.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelefonoProfesional
            // 
            this.txtTelefonoProfesional.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoProfesional.ForeColor = System.Drawing.Color.Gray;
            this.txtTelefonoProfesional.Location = new System.Drawing.Point(427, 301);
            this.txtTelefonoProfesional.Name = "txtTelefonoProfesional";
            this.txtTelefonoProfesional.Size = new System.Drawing.Size(280, 30);
            this.txtTelefonoProfesional.TabIndex = 79;
            this.txtTelefonoProfesional.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbErrorCorreo
            // 
            this.lbErrorCorreo.AutoSize = true;
            this.lbErrorCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorCorreo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorCorreo.ForeColor = System.Drawing.Color.Red;
            this.lbErrorCorreo.Location = new System.Drawing.Point(731, 385);
            this.lbErrorCorreo.Name = "lbErrorCorreo";
            this.lbErrorCorreo.Size = new System.Drawing.Size(221, 16);
            this.lbErrorCorreo.TabIndex = 78;
            this.lbErrorCorreo.Text = "*Ingrese un correo electrónico válido";
            this.lbErrorCorreo.Visible = false;
            // 
            // lbErrorTelefono
            // 
            this.lbErrorTelefono.AutoSize = true;
            this.lbErrorTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorTelefono.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorTelefono.ForeColor = System.Drawing.Color.Red;
            this.lbErrorTelefono.Location = new System.Drawing.Point(731, 310);
            this.lbErrorTelefono.Name = "lbErrorTelefono";
            this.lbErrorTelefono.Size = new System.Drawing.Size(168, 16);
            this.lbErrorTelefono.TabIndex = 77;
            this.lbErrorTelefono.Text = "*Ingrese un Teléfono válido";
            this.lbErrorTelefono.Visible = false;
            // 
            // lbErrorEspecialidad
            // 
            this.lbErrorEspecialidad.AutoSize = true;
            this.lbErrorEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorEspecialidad.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorEspecialidad.ForeColor = System.Drawing.Color.Red;
            this.lbErrorEspecialidad.Location = new System.Drawing.Point(731, 231);
            this.lbErrorEspecialidad.Name = "lbErrorEspecialidad";
            this.lbErrorEspecialidad.Size = new System.Drawing.Size(195, 16);
            this.lbErrorEspecialidad.TabIndex = 76;
            this.lbErrorEspecialidad.Text = "*Ingrese una Especialidad válido";
            this.lbErrorEspecialidad.Visible = false;
            // 
            // lbErrorNombre
            // 
            this.lbErrorNombre.AutoSize = true;
            this.lbErrorNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorNombre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lbErrorNombre.Location = new System.Drawing.Point(732, 162);
            this.lbErrorNombre.Name = "lbErrorNombre";
            this.lbErrorNombre.Size = new System.Drawing.Size(162, 16);
            this.lbErrorNombre.TabIndex = 75;
            this.lbErrorNombre.Text = "*Ingrese un nombre válido";
            this.lbErrorNombre.Visible = false;
            // 
            // btnEditarProfesional
            // 
            this.btnEditarProfesional.BackColor = System.Drawing.Color.Lime;
            this.btnEditarProfesional.FlatAppearance.BorderSize = 0;
            this.btnEditarProfesional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProfesional.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProfesional.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditarProfesional.Location = new System.Drawing.Point(489, 496);
            this.btnEditarProfesional.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditarProfesional.Name = "btnEditarProfesional";
            this.btnEditarProfesional.Size = new System.Drawing.Size(158, 39);
            this.btnEditarProfesional.TabIndex = 74;
            this.btnEditarProfesional.Text = "Editar";
            this.btnEditarProfesional.UseVisualStyleBackColor = false;
            this.btnEditarProfesional.Click += new System.EventHandler(this.btnEditarProfesional_Click);
            // 
            // txtEspecialidadProfesional
            // 
            this.txtEspecialidadProfesional.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidadProfesional.ForeColor = System.Drawing.Color.Gray;
            this.txtEspecialidadProfesional.Location = new System.Drawing.Point(427, 221);
            this.txtEspecialidadProfesional.Name = "txtEspecialidadProfesional";
            this.txtEspecialidadProfesional.Size = new System.Drawing.Size(280, 30);
            this.txtEspecialidadProfesional.TabIndex = 73;
            this.txtEspecialidadProfesional.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombreProfesional
            // 
            this.txtNombreProfesional.AccessibleDescription = "";
            this.txtNombreProfesional.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProfesional.ForeColor = System.Drawing.Color.Gray;
            this.txtNombreProfesional.Location = new System.Drawing.Point(427, 153);
            this.txtNombreProfesional.Name = "txtNombreProfesional";
            this.txtNombreProfesional.Size = new System.Drawing.Size(280, 30);
            this.txtNombreProfesional.TabIndex = 70;
            this.txtNombreProfesional.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(447, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 69;
            this.label1.Text = "Editar Profesional";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(12, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 29);
            this.label10.TabIndex = 68;
            this.label10.Text = "Oficinas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 29);
            this.label9.TabIndex = 67;
            this.label9.Text = "Departamentos";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 29);
            this.label8.TabIndex = 66;
            this.label8.Text = "Profesionales";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 29);
            this.label7.TabIndex = 65;
            this.label7.Text = "Usuarios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 29);
            this.label6.TabIndex = 64;
            this.label6.Text = "Reportes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 63;
            this.label5.Text = "Acerca de...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 62;
            this.label4.Text = "Casos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 61;
            this.label3.Text = "Denuncias";
            // 
            // ActualizarProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIDECA.Properties.Resources.fondoPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.cbDepartamentosProfesional);
            this.Controls.Add(this.txtCorreoProfesional);
            this.Controls.Add(this.txtTelefonoProfesional);
            this.Controls.Add(this.lbErrorCorreo);
            this.Controls.Add(this.lbErrorTelefono);
            this.Controls.Add(this.lbErrorEspecialidad);
            this.Controls.Add(this.lbErrorNombre);
            this.Controls.Add(this.btnEditarProfesional);
            this.Controls.Add(this.txtEspecialidadProfesional);
            this.Controls.Add(this.txtNombreProfesional);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "ActualizarProfesional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarProfesional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbDepartamentosProfesional;
        private System.Windows.Forms.TextBox txtCorreoProfesional;
        private System.Windows.Forms.TextBox txtTelefonoProfesional;
        private System.Windows.Forms.Label lbErrorCorreo;
        private System.Windows.Forms.Label lbErrorTelefono;
        private System.Windows.Forms.Label lbErrorEspecialidad;
        private System.Windows.Forms.Label lbErrorNombre;
        private System.Windows.Forms.Button btnEditarProfesional;
        private System.Windows.Forms.TextBox txtEspecialidadProfesional;
        private System.Windows.Forms.TextBox txtNombreProfesional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}