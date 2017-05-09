namespace SIDECA
{
    partial class BuscarProfesionalEliminarForm
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
            this.lbErrorNoEncontrado = new System.Windows.Forms.Label();
            this.lbErrorNombre = new System.Windows.Forms.Label();
            this.txtNombreProfesional = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarDepartamento = new System.Windows.Forms.Button();
            this.txtOficinaDepartamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbErrorNoEncontrado
            // 
            this.lbErrorNoEncontrado.AutoSize = true;
            this.lbErrorNoEncontrado.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorNoEncontrado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorNoEncontrado.ForeColor = System.Drawing.Color.Red;
            this.lbErrorNoEncontrado.Location = new System.Drawing.Point(501, 336);
            this.lbErrorNoEncontrado.Name = "lbErrorNoEncontrado";
            this.lbErrorNoEncontrado.Size = new System.Drawing.Size(313, 16);
            this.lbErrorNoEncontrado.TabIndex = 92;
            this.lbErrorNoEncontrado.Text = "*No se encontraron coincidencias, intentelo de nuevo";
            this.lbErrorNoEncontrado.Visible = false;
            // 
            // lbErrorNombre
            // 
            this.lbErrorNombre.AutoSize = true;
            this.lbErrorNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorNombre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lbErrorNombre.Location = new System.Drawing.Point(837, 305);
            this.lbErrorNombre.Name = "lbErrorNombre";
            this.lbErrorNombre.Size = new System.Drawing.Size(162, 16);
            this.lbErrorNombre.TabIndex = 91;
            this.lbErrorNombre.Text = "*Ingrese un nombre válido";
            this.lbErrorNombre.Visible = false;
            // 
            // txtNombreProfesional
            // 
            this.txtNombreProfesional.AccessibleDescription = "";
            this.txtNombreProfesional.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProfesional.ForeColor = System.Drawing.Color.Gray;
            this.txtNombreProfesional.Location = new System.Drawing.Point(512, 300);
            this.txtNombreProfesional.Name = "txtNombreProfesional";
            this.txtNombreProfesional.Size = new System.Drawing.Size(280, 30);
            this.txtNombreProfesional.TabIndex = 90;
            this.txtNombreProfesional.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(530, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 89;
            this.label1.Text = "Eliminar Profesional";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(12, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 29);
            this.label10.TabIndex = 88;
            this.label10.Text = "Oficinas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 29);
            this.label9.TabIndex = 87;
            this.label9.Text = "Departamentos";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 29);
            this.label8.TabIndex = 86;
            this.label8.Text = "Profesionales";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 29);
            this.label7.TabIndex = 85;
            this.label7.Text = "Usuarios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 29);
            this.label6.TabIndex = 84;
            this.label6.Text = "Reportes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 83;
            this.label5.Text = "Acerca de...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 82;
            this.label4.Text = "Casos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(12, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 29);
            this.label11.TabIndex = 81;
            this.label11.Text = "Denuncias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(507, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 29);
            this.label2.TabIndex = 80;
            this.label2.Text = "Apellidos del Profesional";
            // 
            // btnBuscarDepartamento
            // 
            this.btnBuscarDepartamento.BackColor = System.Drawing.Color.Lime;
            this.btnBuscarDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarDepartamento.FlatAppearance.BorderSize = 0;
            this.btnBuscarDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDepartamento.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDepartamento.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarDepartamento.Location = new System.Drawing.Point(572, 389);
            this.btnBuscarDepartamento.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscarDepartamento.Name = "btnBuscarDepartamento";
            this.btnBuscarDepartamento.Size = new System.Drawing.Size(164, 37);
            this.btnBuscarDepartamento.TabIndex = 79;
            this.btnBuscarDepartamento.Text = "Aceptar";
            this.btnBuscarDepartamento.UseVisualStyleBackColor = false;
            this.btnBuscarDepartamento.Click += new System.EventHandler(this.btnBuscarDepartamento_Click);
            // 
            // txtOficinaDepartamento
            // 
            this.txtOficinaDepartamento.AutoSize = true;
            this.txtOficinaDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.txtOficinaDepartamento.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOficinaDepartamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtOficinaDepartamento.Location = new System.Drawing.Point(495, 183);
            this.txtOficinaDepartamento.Name = "txtOficinaDepartamento";
            this.txtOficinaDepartamento.Size = new System.Drawing.Size(291, 29);
            this.txtOficinaDepartamento.TabIndex = 78;
            this.txtOficinaDepartamento.Text = "Ingrese el Nombre y/o los";
            // 
            // BuscarProfesionalEliminarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIDECA.Properties.Resources.fondoPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.lbErrorNoEncontrado);
            this.Controls.Add(this.lbErrorNombre);
            this.Controls.Add(this.txtNombreProfesional);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarDepartamento);
            this.Controls.Add(this.txtOficinaDepartamento);
            this.Name = "BuscarProfesionalEliminarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarProfesionalEliminarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbErrorNoEncontrado;
        private System.Windows.Forms.Label lbErrorNombre;
        private System.Windows.Forms.TextBox txtNombreProfesional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarDepartamento;
        private System.Windows.Forms.Label txtOficinaDepartamento;
    }
}