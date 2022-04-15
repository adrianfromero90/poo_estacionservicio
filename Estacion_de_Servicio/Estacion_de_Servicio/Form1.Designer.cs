namespace Estacion_de_Servicio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lblsurtidor1 = new System.Windows.Forms.Label();
            this.lblsurtidor2 = new System.Windows.Forms.Label();
            this.lblsurtidor3 = new System.Windows.Forms.Label();
            this.btnCargarSurtidor = new System.Windows.Forms.Button();
            this.cbNaftas = new System.Windows.Forms.ComboBox();
            this.lstSurtidores = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblsurtidor3);
            this.groupBox1.Controls.Add(this.lblsurtidor2);
            this.groupBox1.Controls.Add(this.lblsurtidor1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(17, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Surtidores";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Surtidor 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Surtidor 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Surtidor 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // lblsurtidor1
            // 
            this.lblsurtidor1.AutoSize = true;
            this.lblsurtidor1.Location = new System.Drawing.Point(77, 20);
            this.lblsurtidor1.Name = "lblsurtidor1";
            this.lblsurtidor1.Size = new System.Drawing.Size(13, 13);
            this.lblsurtidor1.TabIndex = 3;
            this.lblsurtidor1.Text = "1";
            // 
            // lblsurtidor2
            // 
            this.lblsurtidor2.AutoSize = true;
            this.lblsurtidor2.Location = new System.Drawing.Point(77, 45);
            this.lblsurtidor2.Name = "lblsurtidor2";
            this.lblsurtidor2.Size = new System.Drawing.Size(13, 13);
            this.lblsurtidor2.TabIndex = 4;
            this.lblsurtidor2.Text = "2";
            // 
            // lblsurtidor3
            // 
            this.lblsurtidor3.AutoSize = true;
            this.lblsurtidor3.Location = new System.Drawing.Point(77, 68);
            this.lblsurtidor3.Name = "lblsurtidor3";
            this.lblsurtidor3.Size = new System.Drawing.Size(13, 13);
            this.lblsurtidor3.TabIndex = 5;
            this.lblsurtidor3.Text = "3";
            // 
            // btnCargarSurtidor
            // 
            this.btnCargarSurtidor.Location = new System.Drawing.Point(175, 68);
            this.btnCargarSurtidor.Name = "btnCargarSurtidor";
            this.btnCargarSurtidor.Size = new System.Drawing.Size(110, 46);
            this.btnCargarSurtidor.TabIndex = 1;
            this.btnCargarSurtidor.Text = "&Cargar Surtidor";
            this.btnCargarSurtidor.UseVisualStyleBackColor = true;
            // 
            // cbNaftas
            // 
            this.cbNaftas.FormattingEnabled = true;
            this.cbNaftas.Location = new System.Drawing.Point(175, 42);
            this.cbNaftas.Name = "cbNaftas";
            this.cbNaftas.Size = new System.Drawing.Size(110, 21);
            this.cbNaftas.TabIndex = 2;
            // 
            // lstSurtidores
            // 
            this.lstSurtidores.FormattingEnabled = true;
            this.lstSurtidores.Location = new System.Drawing.Point(19, 125);
            this.lstSurtidores.Name = "lstSurtidores";
            this.lstSurtidores.Size = new System.Drawing.Size(138, 95);
            this.lstSurtidores.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSurtidores);
            this.Controls.Add(this.cbNaftas);
            this.Controls.Add(this.btnCargarSurtidor);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblsurtidor3;
        private System.Windows.Forms.Label lblsurtidor2;
        private System.Windows.Forms.Label lblsurtidor1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnCargarSurtidor;
        private System.Windows.Forms.ComboBox cbNaftas;
        private System.Windows.Forms.ListBox lstSurtidores;
    }
}

