namespace Prvado.CAPAPRESENTACION
{
    partial class Empleados
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtAreas = new System.Windows.Forms.TextBox();
            this.btnbuscar2 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDpi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 167;
            this.label4.Text = "Direccion:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(203, 435);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(251, 20);
            this.txtTelefono.TabIndex = 166;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(203, 408);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(251, 20);
            this.txtDireccion.TabIndex = 165;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 164;
            this.label10.Text = "Telefono:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " dd-MM-yyyy hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(203, 372);
            this.dateTimePicker1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 20);
            this.dateTimePicker1.TabIndex = 163;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 162;
            this.label1.Text = "Fecha Ingreso:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(269, 216);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(10, 13);
            this.label23.TabIndex = 161;
            this.label23.Text = ".";
            // 
            // txtAreas
            // 
            this.txtAreas.Location = new System.Drawing.Point(646, 268);
            this.txtAreas.Name = "txtAreas";
            this.txtAreas.Size = new System.Drawing.Size(251, 20);
            this.txtAreas.TabIndex = 160;
            // 
            // btnbuscar2
            // 
            this.btnbuscar2.Location = new System.Drawing.Point(593, 211);
            this.btnbuscar2.Name = "btnbuscar2";
            this.btnbuscar2.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar2.TabIndex = 159;
            this.btnbuscar2.Text = "Buscar";
            this.btnbuscar2.UseVisualStyleBackColor = true;
            this.btnbuscar2.Click += new System.EventHandler(this.btnbuscar2_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(417, 212);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(170, 20);
            this.txtBuscar.TabIndex = 158;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(317, 216);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 13);
            this.label22.TabIndex = 157;
            this.label22.Text = "Codigo Area";
            // 
            // btn_reporte
            // 
            this.btn_reporte.Location = new System.Drawing.Point(417, 541);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(71, 43);
            this.btn_reporte.TabIndex = 156;
            this.btn_reporte.Text = "Imprimir";
            this.btn_reporte.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(267, 240);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 13);
            this.label20.TabIndex = 155;
            this.label20.Text = "EMPLEADOS";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(340, 541);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(71, 43);
            this.btnCalcular.TabIndex = 154;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 153;
            this.label5.Text = "Nombres:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(203, 497);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(251, 20);
            this.txtSueldo.TabIndex = 152;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(203, 470);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(251, 20);
            this.txtCargo.TabIndex = 151;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(203, 345);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(251, 20);
            this.txtApellidos.TabIndex = 150;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(203, 318);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(251, 20);
            this.txtNombres.TabIndex = 149;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 148;
            this.label8.Text = "Sueldo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 147;
            this.label7.Text = "Cargo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 146;
            this.label6.Text = "Apellidos:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(259, 543);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 41);
            this.btnInsertar.TabIndex = 145;
            this.btnInsertar.Text = "Agregar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(97, 538);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 46);
            this.btnEliminar.TabIndex = 144;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(178, 541);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 41);
            this.btnEditar.TabIndex = 143;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 15);
            this.label9.TabIndex = 142;
            this.label9.Text = "Listado de productos / VISTA USUARIO";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(547, 541);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(324, 41);
            this.btnAgregar.TabIndex = 141;
            this.btnAgregar.Text = "GUARDAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 140;
            this.label3.Text = "Dpi:";
            // 
            // txtDpi
            // 
            this.txtDpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDpi.Location = new System.Drawing.Point(203, 289);
            this.txtDpi.Name = "txtDpi";
            this.txtDpi.Size = new System.Drawing.Size(251, 21);
            this.txtDpi.TabIndex = 139;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 138;
            this.label2.Text = "Area:";
            // 
            // cbArea
            // 
            this.cbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(203, 262);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(251, 23);
            this.cbArea.TabIndex = 137;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(0, 22);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(1017, 173);
            this.dgvEmpleados.TabIndex = 136;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(486, 240);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 13);
            this.linkLabel1.TabIndex = 168;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Volver al menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 613);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtAreas);
            this.Controls.Add(this.btnbuscar2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDpi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtAreas;
        private System.Windows.Forms.Button btnbuscar2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDpi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}