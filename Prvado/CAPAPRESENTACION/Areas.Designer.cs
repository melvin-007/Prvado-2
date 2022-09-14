namespace Prvado.CAPAPRESENTACION
{
    partial class Areas
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
            this.btn_reporte = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAreas = new System.Windows.Forms.DataGridView();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_reporte
            // 
            this.btn_reporte.Location = new System.Drawing.Point(378, 392);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(71, 43);
            this.btn_reporte.TabIndex = 111;
            this.btn_reporte.Text = "Imprimir";
            this.btn_reporte.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(241, 229);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 110;
            this.label20.Text = "AREAS";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(301, 392);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(71, 43);
            this.btnCalcular.TabIndex = 103;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(58, 389);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 46);
            this.btnEliminar.TabIndex = 81;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(139, 392);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 41);
            this.btnEditar.TabIndex = 80;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 15);
            this.label9.TabIndex = 79;
            this.label9.Text = "Listado de Areas / VISTA USUARIO";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(508, 392);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(324, 41);
            this.btnGuardar.TabIndex = 78;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 76;
            this.label3.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(178, 307);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(251, 21);
            this.txtDescripcion.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 73;
            this.label2.Text = "Area:";
            // 
            // dgvAreas
            // 
            this.dgvAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreas.Location = new System.Drawing.Point(12, 21);
            this.dgvAreas.Name = "dgvAreas";
            this.dgvAreas.Size = new System.Drawing.Size(934, 198);
            this.dgvAreas.TabIndex = 69;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(178, 281);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(250, 20);
            this.txtArea.TabIndex = 112;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(414, 228);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 13);
            this.linkLabel1.TabIndex = 113;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Volver al menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 468);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAreas);
            this.Name = "Areas";
            this.Text = "Areas";
            this.Load += new System.EventHandler(this.Areas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAreas;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}