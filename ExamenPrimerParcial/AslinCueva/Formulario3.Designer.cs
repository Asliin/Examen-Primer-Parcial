namespace AslinCueva
{
    partial class Formulario3
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
            this.NumerosListBox = new System.Windows.Forms.ListBox();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.CerrarFormularioButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumerosListBox
            // 
            this.NumerosListBox.FormattingEnabled = true;
            this.NumerosListBox.ItemHeight = 19;
            this.NumerosListBox.Location = new System.Drawing.Point(12, 12);
            this.NumerosListBox.Name = "NumerosListBox";
            this.NumerosListBox.Size = new System.Drawing.Size(256, 650);
            this.NumerosListBox.TabIndex = 0;
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Image = global::AslinCueva.Properties.Resources.planificacion;
            this.EjecutarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EjecutarButton.Location = new System.Drawing.Point(304, 244);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(158, 78);
            this.EjecutarButton.TabIndex = 1;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // CerrarFormularioButton
            // 
            this.CerrarFormularioButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CerrarFormularioButton.Image = global::AslinCueva.Properties.Resources.cerrar_sesion;
            this.CerrarFormularioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CerrarFormularioButton.Location = new System.Drawing.Point(482, 244);
            this.CerrarFormularioButton.Name = "CerrarFormularioButton";
            this.CerrarFormularioButton.Size = new System.Drawing.Size(158, 78);
            this.CerrarFormularioButton.TabIndex = 2;
            this.CerrarFormularioButton.Text = "Cerrar Formulario";
            this.CerrarFormularioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CerrarFormularioButton.UseVisualStyleBackColor = true;
            this.CerrarFormularioButton.Click += new System.EventHandler(this.CerrarFormularioButton_Click);
            // 
            // Formulario3
            // 
            this.AcceptButton = this.EjecutarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CerrarFormularioButton;
            this.ClientSize = new System.Drawing.Size(706, 677);
            this.Controls.Add(this.CerrarFormularioButton);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.NumerosListBox);
            this.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Formulario3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox NumerosListBox;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.Button CerrarFormularioButton;
    }
}