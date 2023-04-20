namespace Ejercicio_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.comboxoperaciones = new System.Windows.Forms.ComboBox();
            this.btngenerar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ListBox_Numeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROGRAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar Valor";
            // 
            // txtvalor
            // 
            this.txtvalor.BackColor = System.Drawing.Color.White;
            this.txtvalor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(249, 119);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 22);
            this.txtvalor.TabIndex = 2;
            // 
            // comboxoperaciones
            // 
            this.comboxoperaciones.BackColor = System.Drawing.Color.White;
            this.comboxoperaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboxoperaciones.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxoperaciones.FormattingEnabled = true;
            this.comboxoperaciones.Items.AddRange(new object[] {
            "Numeros Primos",
            "Numeros Perfectos",
            "Serie Fibonaci"});
            this.comboxoperaciones.Location = new System.Drawing.Point(384, 118);
            this.comboxoperaciones.Name = "comboxoperaciones";
            this.comboxoperaciones.Size = new System.Drawing.Size(121, 23);
            this.comboxoperaciones.TabIndex = 3;
            // 
            // btngenerar
            // 
            this.btngenerar.BackColor = System.Drawing.Color.DimGray;
            this.btngenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.Location = new System.Drawing.Point(537, 116);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(75, 23);
            this.btngenerar.TabIndex = 4;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = false;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Los números son:";
            // 
            // ListBox_Numeros
            // 
            this.ListBox_Numeros.BackColor = System.Drawing.Color.Gray;
            this.ListBox_Numeros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox_Numeros.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Numeros.ForeColor = System.Drawing.Color.Black;
            this.ListBox_Numeros.FormattingEnabled = true;
            this.ListBox_Numeros.ItemHeight = 15;
            this.ListBox_Numeros.Location = new System.Drawing.Point(259, 199);
            this.ListBox_Numeros.Name = "ListBox_Numeros";
            this.ListBox_Numeros.Size = new System.Drawing.Size(353, 182);
            this.ListBox_Numeros.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBox_Numeros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.comboxoperaciones);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Operación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.ComboBox comboxoperaciones;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListBox_Numeros;
    }
}

