namespace AplicacionTorres
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lista1 = new System.Windows.Forms.ListBox();
            this.lista2 = new System.Windows.Forms.ListBox();
            this.lista3 = new System.Windows.Forms.ListBox();
            this.cmbDiscos = new System.Windows.Forms.ComboBox();
            this.lbMov = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lista1
            // 
            this.lista1.AllowDrop = true;
            this.lista1.FormattingEnabled = true;
            this.lista1.Location = new System.Drawing.Point(35, 66);
            this.lista1.Name = "lista1";
            this.lista1.Size = new System.Drawing.Size(129, 212);
            this.lista1.TabIndex = 0;
            this.lista1.DragDrop += new System.Windows.Forms.DragEventHandler(this.lista1_DragDrop);
            this.lista1.DragOver += new System.Windows.Forms.DragEventHandler(this.lista1_DragOver);
            this.lista1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lista1_MouseDown);
            // 
            // lista2
            // 
            this.lista2.AllowDrop = true;
            this.lista2.FormattingEnabled = true;
            this.lista2.Location = new System.Drawing.Point(269, 66);
            this.lista2.Name = "lista2";
            this.lista2.Size = new System.Drawing.Size(130, 212);
            this.lista2.TabIndex = 1;
            this.lista2.DragDrop += new System.Windows.Forms.DragEventHandler(this.lista2_DragDrop);
            this.lista2.DragOver += new System.Windows.Forms.DragEventHandler(this.lista1_DragOver);
            this.lista2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lista2_MouseDown);
            // 
            // lista3
            // 
            this.lista3.AllowDrop = true;
            this.lista3.FormattingEnabled = true;
            this.lista3.Location = new System.Drawing.Point(497, 66);
            this.lista3.Name = "lista3";
            this.lista3.Size = new System.Drawing.Size(133, 212);
            this.lista3.TabIndex = 2;
            this.lista3.DragDrop += new System.Windows.Forms.DragEventHandler(this.lista3_DragDrop);
            this.lista3.DragOver += new System.Windows.Forms.DragEventHandler(this.lista1_DragOver);
            this.lista3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lista3_MouseDown);
            // 
            // cmbDiscos
            // 
            this.cmbDiscos.FormattingEnabled = true;
            this.cmbDiscos.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6"});
            this.cmbDiscos.Location = new System.Drawing.Point(83, 12);
            this.cmbDiscos.Name = "cmbDiscos";
            this.cmbDiscos.Size = new System.Drawing.Size(71, 21);
            this.cmbDiscos.TabIndex = 3;
            this.cmbDiscos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbMov
            // 
            this.lbMov.AutoSize = true;
            this.lbMov.Location = new System.Drawing.Point(564, 306);
            this.lbMov.Name = "lbMov";
            this.lbMov.Size = new System.Drawing.Size(66, 13);
            this.lbMov.TabIndex = 4;
            this.lbMov.Text = "Movimientos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Discos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMov);
            this.Controls.Add(this.cmbDiscos);
            this.Controls.Add(this.lista3);
            this.Controls.Add(this.lista2);
            this.Controls.Add(this.lista1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista1;
        private System.Windows.Forms.ListBox lista2;
        private System.Windows.Forms.ListBox lista3;
        private System.Windows.Forms.ComboBox cmbDiscos;
        private System.Windows.Forms.Label lbMov;
        private System.Windows.Forms.Label label2;
    }
}

