namespace AslinCueva
{
    partial class Formulario2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductoTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalAPagarTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DescripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.GenerarFacturaButton = new System.Windows.Forms.Button();
            this.CerrarFormularioButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.AgregarProductoButton = new System.Windows.Forms.Button();
            this.BorrarFacturaButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio:";
            // 
            // ProductoTextBox
            // 
            this.ProductoTextBox.Location = new System.Drawing.Point(111, 215);
            this.ProductoTextBox.Name = "ProductoTextBox";
            this.ProductoTextBox.Size = new System.Drawing.Size(196, 26);
            this.ProductoTextBox.TabIndex = 3;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(111, 281);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(196, 26);
            this.PrecioTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descuento s/venta:";
            // 
            // TotalAPagarTextBox
            // 
            this.TotalAPagarTextBox.Enabled = false;
            this.TotalAPagarTextBox.Location = new System.Drawing.Point(498, 528);
            this.TotalAPagarTextBox.Name = "TotalAPagarTextBox";
            this.TotalAPagarTextBox.Size = new System.Drawing.Size(196, 26);
            this.TotalAPagarTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subtotal:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescripcionColumn,
            this.PrecioColumn});
            this.dataGridView1.Location = new System.Drawing.Point(30, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(293, 240);
            this.dataGridView1.TabIndex = 9;
            // 
            // DescripcionColumn
            // 
            this.DescripcionColumn.Frozen = true;
            this.DescripcionColumn.HeaderText = "Descripción";
            this.DescripcionColumn.Name = "DescripcionColumn";
            this.DescripcionColumn.ReadOnly = true;
            this.DescripcionColumn.Width = 119;
            // 
            // PrecioColumn
            // 
            this.PrecioColumn.Frozen = true;
            this.PrecioColumn.HeaderText = "Precio Unitario";
            this.PrecioColumn.Name = "PrecioColumn";
            this.PrecioColumn.ReadOnly = true;
            this.PrecioColumn.Width = 130;
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Enabled = false;
            this.DescuentoTextBox.Location = new System.Drawing.Point(498, 448);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(196, 26);
            this.DescuentoTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "TOTAL A PAGAR:";
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.Enabled = false;
            this.SubtotalTextBox.Location = new System.Drawing.Point(498, 368);
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.Size = new System.Drawing.Size(196, 26);
            this.SubtotalTextBox.TabIndex = 12;
            // 
            // GenerarFacturaButton
            // 
            this.GenerarFacturaButton.Image = global::AslinCueva.Properties.Resources.presupuesto;
            this.GenerarFacturaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GenerarFacturaButton.Location = new System.Drawing.Point(529, 202);
            this.GenerarFacturaButton.Name = "GenerarFacturaButton";
            this.GenerarFacturaButton.Size = new System.Drawing.Size(160, 51);
            this.GenerarFacturaButton.TabIndex = 13;
            this.GenerarFacturaButton.Text = "Generar Factura";
            this.GenerarFacturaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GenerarFacturaButton.UseVisualStyleBackColor = true;
            this.GenerarFacturaButton.Click += new System.EventHandler(this.GenerarFacturaButton_Click);
            // 
            // CerrarFormularioButton
            // 
            this.CerrarFormularioButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CerrarFormularioButton.Image = global::AslinCueva.Properties.Resources.cerrar_sesion;
            this.CerrarFormularioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CerrarFormularioButton.Location = new System.Drawing.Point(529, 268);
            this.CerrarFormularioButton.Name = "CerrarFormularioButton";
            this.CerrarFormularioButton.Size = new System.Drawing.Size(160, 51);
            this.CerrarFormularioButton.TabIndex = 14;
            this.CerrarFormularioButton.Text = "Cerrar Formulario";
            this.CerrarFormularioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CerrarFormularioButton.UseVisualStyleBackColor = true;
            this.CerrarFormularioButton.Click += new System.EventHandler(this.CerrarFormularioButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AgregarProductoButton
            // 
            this.AgregarProductoButton.Image = global::AslinCueva.Properties.Resources.mas;
            this.AgregarProductoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarProductoButton.Location = new System.Drawing.Point(337, 202);
            this.AgregarProductoButton.Name = "AgregarProductoButton";
            this.AgregarProductoButton.Size = new System.Drawing.Size(161, 51);
            this.AgregarProductoButton.TabIndex = 5;
            this.AgregarProductoButton.Text = "Agregar Nuevo Producto";
            this.AgregarProductoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarProductoButton.UseVisualStyleBackColor = true;
            this.AgregarProductoButton.Click += new System.EventHandler(this.AgregarProductoButton_Click);
            // 
            // BorrarFacturaButton
            // 
            this.BorrarFacturaButton.Image = global::AslinCueva.Properties.Resources.borrar;
            this.BorrarFacturaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarFacturaButton.Location = new System.Drawing.Point(337, 268);
            this.BorrarFacturaButton.Name = "BorrarFacturaButton";
            this.BorrarFacturaButton.Size = new System.Drawing.Size(161, 51);
            this.BorrarFacturaButton.TabIndex = 15;
            this.BorrarFacturaButton.Text = "Eliminar Factura";
            this.BorrarFacturaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BorrarFacturaButton.UseVisualStyleBackColor = true;
            this.BorrarFacturaButton.Click += new System.EventHandler(this.BorrarFacturaButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AslinCueva.Properties.Resources.supermercado_la_colonia_logo_5740E3DAFC_seeklogo_com;
            this.pictureBox1.Location = new System.Drawing.Point(14, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Formulario2
            // 
            this.AcceptButton = this.AgregarProductoButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.CerrarFormularioButton;
            this.ClientSize = new System.Drawing.Size(706, 677);
            this.Controls.Add(this.BorrarFacturaButton);
            this.Controls.Add(this.CerrarFormularioButton);
            this.Controls.Add(this.GenerarFacturaButton);
            this.Controls.Add(this.SubtotalTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotalAPagarTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AgregarProductoButton);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.ProductoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Formulario2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario2";
            this.Load += new System.EventHandler(this.Formulario2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductoTextBox;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Button AgregarProductoButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalAPagarTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SubtotalTextBox;
        private System.Windows.Forms.Button GenerarFacturaButton;
        private System.Windows.Forms.Button CerrarFormularioButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BorrarFacturaButton;
    }
}