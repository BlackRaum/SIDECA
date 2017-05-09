namespace SIDECA
{
    partial class InsertarDepartamentoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreDepartamento = new System.Windows.Forms.TextBox();
            this.txtTelefonoDepartamento = new System.Windows.Forms.TextBox();
            this.txtFaxDepartamento = new System.Windows.Forms.TextBox();
            this.txtCorreoDepartamento = new System.Windows.Forms.TextBox();
            this.btnInsertarDeparatmento = new System.Windows.Forms.Button();
            this.lbErrorNombreDepto = new System.Windows.Forms.Label();
            this.lbErrorTelefonoDepto = new System.Windows.Forms.Label();
            this.lbErrorCorreoDepto = new System.Windows.Forms.Label();
            this.lbErrorFaxDepto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOficinas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(478, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insertar Departamento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreDepartamento
            // 
            this.txtNombreDepartamento.AccessibleDescription = "";
            this.txtNombreDepartamento.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDepartamento.ForeColor = System.Drawing.Color.Gray;
            this.txtNombreDepartamento.Location = new System.Drawing.Point(483, 155);
            this.txtNombreDepartamento.Name = "txtNombreDepartamento";
            this.txtNombreDepartamento.Size = new System.Drawing.Size(280, 30);
            this.txtNombreDepartamento.TabIndex = 2;
            this.txtNombreDepartamento.Text = "Nombre del Departamento";
            this.txtNombreDepartamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreDepartamento.TextChanged += new System.EventHandler(this.txtNombreDepartamento_TextChanged);
            // 
            // txtTelefonoDepartamento
            // 
            this.txtTelefonoDepartamento.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoDepartamento.ForeColor = System.Drawing.Color.Gray;
            this.txtTelefonoDepartamento.Location = new System.Drawing.Point(483, 213);
            this.txtTelefonoDepartamento.Name = "txtTelefonoDepartamento";
            this.txtTelefonoDepartamento.Size = new System.Drawing.Size(280, 30);
            this.txtTelefonoDepartamento.TabIndex = 3;
            this.txtTelefonoDepartamento.Text = "Teléfono";
            this.txtTelefonoDepartamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefonoDepartamento.TextChanged += new System.EventHandler(this.txtTelefonoDepartamento_TextChanged);
            // 
            // txtFaxDepartamento
            // 
            this.txtFaxDepartamento.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaxDepartamento.ForeColor = System.Drawing.Color.Gray;
            this.txtFaxDepartamento.Location = new System.Drawing.Point(483, 272);
            this.txtFaxDepartamento.Name = "txtFaxDepartamento";
            this.txtFaxDepartamento.Size = new System.Drawing.Size(280, 30);
            this.txtFaxDepartamento.TabIndex = 4;
            this.txtFaxDepartamento.Text = "Fax";
            this.txtFaxDepartamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFaxDepartamento.TextChanged += new System.EventHandler(this.txtFaxDepartamento_TextChanged);
            // 
            // txtCorreoDepartamento
            // 
            this.txtCorreoDepartamento.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoDepartamento.ForeColor = System.Drawing.Color.Gray;
            this.txtCorreoDepartamento.Location = new System.Drawing.Point(483, 333);
            this.txtCorreoDepartamento.Name = "txtCorreoDepartamento";
            this.txtCorreoDepartamento.Size = new System.Drawing.Size(280, 30);
            this.txtCorreoDepartamento.TabIndex = 5;
            this.txtCorreoDepartamento.Text = "Correo Electrónico";
            this.txtCorreoDepartamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCorreoDepartamento.TextChanged += new System.EventHandler(this.txtCorreoDepartamento_TextChanged);
            // 
            // btnInsertarDeparatmento
            // 
            this.btnInsertarDeparatmento.BackColor = System.Drawing.Color.Lime;
            this.btnInsertarDeparatmento.FlatAppearance.BorderSize = 0;
            this.btnInsertarDeparatmento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarDeparatmento.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarDeparatmento.ForeColor = System.Drawing.Color.Transparent;
            this.btnInsertarDeparatmento.Location = new System.Drawing.Point(532, 457);
            this.btnInsertarDeparatmento.Margin = new System.Windows.Forms.Padding(0);
            this.btnInsertarDeparatmento.Name = "btnInsertarDeparatmento";
            this.btnInsertarDeparatmento.Size = new System.Drawing.Size(158, 39);
            this.btnInsertarDeparatmento.TabIndex = 15;
            this.btnInsertarDeparatmento.Text = "Insertar";
            this.btnInsertarDeparatmento.UseVisualStyleBackColor = false;
            this.btnInsertarDeparatmento.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbErrorNombreDepto
            // 
            this.lbErrorNombreDepto.AutoSize = true;
            this.lbErrorNombreDepto.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorNombreDepto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorNombreDepto.ForeColor = System.Drawing.Color.Red;
            this.lbErrorNombreDepto.Location = new System.Drawing.Point(787, 160);
            this.lbErrorNombreDepto.Name = "lbErrorNombreDepto";
            this.lbErrorNombreDepto.Size = new System.Drawing.Size(265, 16);
            this.lbErrorNombreDepto.TabIndex = 16;
            this.lbErrorNombreDepto.Text = "*Ingrese un nombre de Departamento válido";
            this.lbErrorNombreDepto.Visible = false;
            this.lbErrorNombreDepto.Click += new System.EventHandler(this.lbErrorNombreDepto_Click);
            // 
            // lbErrorTelefonoDepto
            // 
            this.lbErrorTelefonoDepto.AutoSize = true;
            this.lbErrorTelefonoDepto.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorTelefonoDepto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorTelefonoDepto.ForeColor = System.Drawing.Color.Red;
            this.lbErrorTelefonoDepto.Location = new System.Drawing.Point(792, 221);
            this.lbErrorTelefonoDepto.Name = "lbErrorTelefonoDepto";
            this.lbErrorTelefonoDepto.Size = new System.Drawing.Size(168, 16);
            this.lbErrorTelefonoDepto.TabIndex = 17;
            this.lbErrorTelefonoDepto.Text = "*Ingrese un Teléfono válido";
            this.lbErrorTelefonoDepto.Visible = false;
            this.lbErrorTelefonoDepto.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbErrorCorreoDepto
            // 
            this.lbErrorCorreoDepto.AutoSize = true;
            this.lbErrorCorreoDepto.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorCorreoDepto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorCorreoDepto.ForeColor = System.Drawing.Color.Red;
            this.lbErrorCorreoDepto.Location = new System.Drawing.Point(792, 341);
            this.lbErrorCorreoDepto.Name = "lbErrorCorreoDepto";
            this.lbErrorCorreoDepto.Size = new System.Drawing.Size(221, 16);
            this.lbErrorCorreoDepto.TabIndex = 19;
            this.lbErrorCorreoDepto.Text = "*Ingrese un correo electrónico válido";
            this.lbErrorCorreoDepto.Visible = false;
            this.lbErrorCorreoDepto.Click += new System.EventHandler(this.lbErrorCorreoDepto_Click);
            // 
            // lbErrorFaxDepto
            // 
            this.lbErrorFaxDepto.AutoSize = true;
            this.lbErrorFaxDepto.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorFaxDepto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorFaxDepto.ForeColor = System.Drawing.Color.Red;
            this.lbErrorFaxDepto.Location = new System.Drawing.Point(792, 281);
            this.lbErrorFaxDepto.Name = "lbErrorFaxDepto";
            this.lbErrorFaxDepto.Size = new System.Drawing.Size(138, 16);
            this.lbErrorFaxDepto.TabIndex = 18;
            this.lbErrorFaxDepto.Text = "*Ingrese un Fax válido";
            this.lbErrorFaxDepto.Visible = false;
            this.lbErrorFaxDepto.Click += new System.EventHandler(this.lbErrorFaxDepto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(21, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 29);
            this.label10.TabIndex = 31;
            this.label10.Text = "Oficinas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(21, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "Departamentos";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(21, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "Profesionales";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(21, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Usuarios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(21, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Reportes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(21, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Acerca de...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(21, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Casos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Denuncias";
            // 
            // cbOficinas
            // 
            this.cbOficinas.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOficinas.FormattingEnabled = true;
            this.cbOficinas.Location = new System.Drawing.Point(483, 393);
            this.cbOficinas.Name = "cbOficinas";
            this.cbOficinas.Size = new System.Drawing.Size(280, 31);
            this.cbOficinas.TabIndex = 32;
            // 
            // InsertarDepartamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIDECA.Properties.Resources.fondoPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.cbOficinas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbErrorCorreoDepto);
            this.Controls.Add(this.lbErrorFaxDepto);
            this.Controls.Add(this.lbErrorTelefonoDepto);
            this.Controls.Add(this.lbErrorNombreDepto);
            this.Controls.Add(this.btnInsertarDeparatmento);
            this.Controls.Add(this.txtCorreoDepartamento);
            this.Controls.Add(this.txtFaxDepartamento);
            this.Controls.Add(this.txtTelefonoDepartamento);
            this.Controls.Add(this.txtNombreDepartamento);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InsertarDepartamentoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "insertarDepartamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreDepartamento;
        private System.Windows.Forms.TextBox txtTelefonoDepartamento;
        private System.Windows.Forms.TextBox txtFaxDepartamento;
        private System.Windows.Forms.TextBox txtCorreoDepartamento;
        private System.Windows.Forms.Button btnInsertarDeparatmento;
        private System.Windows.Forms.Label lbErrorNombreDepto;
        private System.Windows.Forms.Label lbErrorTelefonoDepto;
        private System.Windows.Forms.Label lbErrorCorreoDepto;
        private System.Windows.Forms.Label lbErrorFaxDepto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbOficinas;
    }
}