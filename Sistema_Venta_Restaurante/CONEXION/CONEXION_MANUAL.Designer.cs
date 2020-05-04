namespace Sistema_Venta_Restaurante.CONEXION
{
    partial class CONEXION_MANUAL
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCnString = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cadena de conexion LOCAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(583, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Una vez que estes listo dale a \"Generar Cadena de Conexion, se creara un archivo " +
    "que contendra tu conexion encriptada";
            // 
            // txtCnString
            // 
            this.txtCnString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnString.Location = new System.Drawing.Point(56, 75);
            this.txtCnString.Multiline = true;
            this.txtCnString.Name = "txtCnString";
            this.txtCnString.Size = new System.Drawing.Size(683, 66);
            this.txtCnString.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(56, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generar Cadena de Conexion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CONEXION_MANUAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 228);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCnString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CONEXION_MANUAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexion Manual";
            this.Load += new System.EventHandler(this.CONEXION_MANUAL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCnString;
        private System.Windows.Forms.Button button1;
    }
}