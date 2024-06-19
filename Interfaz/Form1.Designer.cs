
namespace Interfaz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.TextBoxPrecio = new System.Windows.Forms.TextBox();
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.tablaDeDatos = new System.Windows.Forms.DataGridView();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.BotonModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 38);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(19, 66);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 1;
            this.labelPrecio.Text = "Precio";
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(62, 35);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNombre.TabIndex = 2;
            // 
            // TextBoxPrecio
            // 
            this.TextBoxPrecio.Location = new System.Drawing.Point(62, 63);
            this.TextBoxPrecio.Name = "TextBoxPrecio";
            this.TextBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPrecio.TabIndex = 3;
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Location = new System.Drawing.Point(87, 89);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(75, 23);
            this.BotonGuardar.TabIndex = 4;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.UseVisualStyleBackColor = true;
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // tablaDeDatos
            // 
            this.tablaDeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDeDatos.Location = new System.Drawing.Point(193, 12);
            this.tablaDeDatos.Name = "tablaDeDatos";
            this.tablaDeDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDeDatos.Size = new System.Drawing.Size(240, 150);
            this.tablaDeDatos.TabIndex = 5;
            this.tablaDeDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDeDatos_CellContentClick);
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Location = new System.Drawing.Point(87, 147);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(75, 23);
            this.BotonEliminar.TabIndex = 6;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.UseVisualStyleBackColor = true;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // BotonModificar
            // 
            this.BotonModificar.Location = new System.Drawing.Point(87, 118);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.Size = new System.Drawing.Size(75, 23);
            this.BotonModificar.TabIndex = 7;
            this.BotonModificar.Text = "Modificar";
            this.BotonModificar.UseVisualStyleBackColor = true;
            this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 207);
            this.Controls.Add(this.BotonModificar);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.tablaDeDatos);
            this.Controls.Add(this.BotonGuardar);
            this.Controls.Add(this.TextBoxPrecio);
            this.Controls.Add(this.TextBoxNombre);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.TextBox TextBoxPrecio;
        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.DataGridView tablaDeDatos;
        private System.Windows.Forms.Button BotonEliminar;
        private System.Windows.Forms.Button BotonModificar;
    }
}

