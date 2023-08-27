
namespace IUCafeteriaMiU
{
    partial class FrmCafeteriaMiU
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
            this.selecDia = new System.Windows.Forms.ComboBox();
            this.Mostrar = new System.Windows.Forms.GroupBox();
            this.Generar = new System.Windows.Forms.Button();
            this.Finalizar = new System.Windows.Forms.Button();
            this.msjError = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cantAdici = new System.Windows.Forms.TextBox();
            this.cantiTotal = new System.Windows.Forms.TextBox();
            this.tApagar = new System.Windows.Forms.TextBox();
            this.Mostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona un Dia";
            // 
            // selecDia
            // 
            this.selecDia.FormattingEnabled = true;
            this.selecDia.Location = new System.Drawing.Point(184, 49);
            this.selecDia.Name = "selecDia";
            this.selecDia.Size = new System.Drawing.Size(216, 21);
            this.selecDia.TabIndex = 1;
            // 
            // Mostrar
            // 
            this.Mostrar.Controls.Add(this.tApagar);
            this.Mostrar.Controls.Add(this.cantiTotal);
            this.Mostrar.Controls.Add(this.cantAdici);
            this.Mostrar.Controls.Add(this.label4);
            this.Mostrar.Controls.Add(this.label3);
            this.Mostrar.Controls.Add(this.label2);
            this.Mostrar.Location = new System.Drawing.Point(72, 111);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(314, 192);
            this.Mostrar.TabIndex = 4;
            this.Mostrar.TabStop = false;
            this.Mostrar.Text = "groupBox1";
            // 
            // Generar
            // 
            this.Generar.Location = new System.Drawing.Point(72, 382);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(151, 23);
            this.Generar.TabIndex = 5;
            this.Generar.Text = "Generar";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // Finalizar
            // 
            this.Finalizar.Location = new System.Drawing.Point(241, 382);
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Size = new System.Drawing.Size(145, 23);
            this.Finalizar.TabIndex = 6;
            this.Finalizar.Text = "Finalizar";
            this.Finalizar.UseVisualStyleBackColor = true;
            this.Finalizar.Click += new System.EventHandler(this.Finalizar_Click);
            // 
            // msjError
            // 
            this.msjError.Location = new System.Drawing.Point(72, 309);
            this.msjError.Multiline = true;
            this.msjError.Name = "msjError";
            this.msjError.Size = new System.Drawing.Size(314, 34);
            this.msjError.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Apagar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cantidad Total Apagar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cantidad Adicional";
            // 
            // cantAdici
            // 
            this.cantAdici.Location = new System.Drawing.Point(134, 56);
            this.cantAdici.Name = "cantAdici";
            this.cantAdici.Size = new System.Drawing.Size(154, 20);
            this.cantAdici.TabIndex = 3;
            // 
            // cantiTotal
            // 
            this.cantiTotal.Location = new System.Drawing.Point(132, 101);
            this.cantiTotal.Name = "cantiTotal";
            this.cantiTotal.Size = new System.Drawing.Size(154, 20);
            this.cantiTotal.TabIndex = 4;
            // 
            // tApagar
            // 
            this.tApagar.Location = new System.Drawing.Point(134, 139);
            this.tApagar.Name = "tApagar";
            this.tApagar.Size = new System.Drawing.Size(154, 20);
            this.tApagar.TabIndex = 5;
            // 
            // FrmCafeteriaMiU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.msjError);
            this.Controls.Add(this.Finalizar);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.selecDia);
            this.Controls.Add(this.label1);
            this.Name = "FrmCafeteriaMiU";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCafeteriaMiU_Load);
            this.Mostrar.ResumeLayout(false);
            this.Mostrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selecDia;
        private System.Windows.Forms.GroupBox Mostrar;
        private System.Windows.Forms.Button Generar;
        private System.Windows.Forms.Button Finalizar;
        private System.Windows.Forms.TextBox msjError;
        private System.Windows.Forms.TextBox tApagar;
        private System.Windows.Forms.TextBox cantiTotal;
        private System.Windows.Forms.TextBox cantAdici;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

