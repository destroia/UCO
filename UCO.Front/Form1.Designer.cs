
namespace UCO.Front
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCasa = new System.Windows.Forms.Label();
            this.txtArNombre = new System.Windows.Forms.TextBox();
            this.txtArPais = new System.Windows.Forms.TextBox();
            this.txtArCasa = new System.Windows.Forms.TextBox();
            this.btnSaveAr = new System.Windows.Forms.Button();
            this.txtFilAr = new System.Windows.Forms.TextBox();
            this.btnBusAr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtArNomUP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArPaisUp = new System.Windows.Forms.TextBox();
            this.txtARCasaUp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnArUp = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Artistas ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Listar Artistas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 127);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(176, 127);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(34, 20);
            this.lblPais.TabIndex = 3;
            this.lblPais.Text = "País";
            // 
            // lblCasa
            // 
            this.lblCasa.AutoSize = true;
            this.lblCasa.Location = new System.Drawing.Point(307, 127);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(103, 20);
            this.lblCasa.TabIndex = 4;
            this.lblCasa.Text = "Casa Disquera";
            // 
            // txtArNombre
            // 
            this.txtArNombre.Location = new System.Drawing.Point(41, 164);
            this.txtArNombre.MaxLength = 2;
            this.txtArNombre.Name = "txtArNombre";
            this.txtArNombre.Size = new System.Drawing.Size(125, 27);
            this.txtArNombre.TabIndex = 5;
            // 
            // txtArPais
            // 
            this.txtArPais.Location = new System.Drawing.Point(176, 164);
            this.txtArPais.MaxLength = 50;
            this.txtArPais.Name = "txtArPais";
            this.txtArPais.Size = new System.Drawing.Size(125, 27);
            this.txtArPais.TabIndex = 6;
            // 
            // txtArCasa
            // 
            this.txtArCasa.Location = new System.Drawing.Point(307, 164);
            this.txtArCasa.MaxLength = 50;
            this.txtArCasa.Name = "txtArCasa";
            this.txtArCasa.Size = new System.Drawing.Size(125, 27);
            this.txtArCasa.TabIndex = 7;
            // 
            // btnSaveAr
            // 
            this.btnSaveAr.Location = new System.Drawing.Point(476, 161);
            this.btnSaveAr.Name = "btnSaveAr";
            this.btnSaveAr.Size = new System.Drawing.Size(166, 29);
            this.btnSaveAr.TabIndex = 8;
            this.btnSaveAr.Text = "Guardar Artista";
            this.btnSaveAr.UseVisualStyleBackColor = true;
            this.btnSaveAr.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtFilAr
            // 
            this.txtFilAr.Location = new System.Drawing.Point(41, 163);
            this.txtFilAr.Name = "txtFilAr";
            this.txtFilAr.Size = new System.Drawing.Size(125, 27);
            this.txtFilAr.TabIndex = 10;
            // 
            // btnBusAr
            // 
            this.btnBusAr.Location = new System.Drawing.Point(476, 161);
            this.btnBusAr.Name = "btnBusAr";
            this.btnBusAr.Size = new System.Drawing.Size(94, 29);
            this.btnBusAr.TabIndex = 11;
            this.btnBusAr.Text = "Buscar";
            this.btnBusAr.UseVisualStyleBackColor = true;
            this.btnBusAr.Click += new System.EventHandler(this.btnBusAr_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(269, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(624, 285);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtArNomUP
            // 
            this.txtArNomUP.Location = new System.Drawing.Point(12, 253);
            this.txtArNomUP.MaxLength = 50;
            this.txtArNomUP.Name = "txtArNomUP";
            this.txtArNomUP.Size = new System.Drawing.Size(125, 27);
            this.txtArNomUP.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Artista seleccionado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "País";
            // 
            // txtArPaisUp
            // 
            this.txtArPaisUp.Location = new System.Drawing.Point(13, 311);
            this.txtArPaisUp.MaxLength = 50;
            this.txtArPaisUp.Name = "txtArPaisUp";
            this.txtArPaisUp.Size = new System.Drawing.Size(125, 27);
            this.txtArPaisUp.TabIndex = 17;
            // 
            // txtARCasaUp
            // 
            this.txtARCasaUp.Location = new System.Drawing.Point(13, 369);
            this.txtARCasaUp.MaxLength = 50;
            this.txtARCasaUp.Name = "txtARCasaUp";
            this.txtARCasaUp.Size = new System.Drawing.Size(125, 27);
            this.txtARCasaUp.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Casa Disquera";
            // 
            // btnArUp
            // 
            this.btnArUp.Location = new System.Drawing.Point(13, 418);
            this.btnArUp.Name = "btnArUp";
            this.btnArUp.Size = new System.Drawing.Size(94, 29);
            this.btnArUp.TabIndex = 20;
            this.btnArUp.Text = "Actualizar";
            this.btnArUp.UseVisualStyleBackColor = true;
            this.btnArUp.Click += new System.EventHandler(this.btnArUp_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 453);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 21;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(116, 418);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 29);
            this.button5.TabIndex = 22;
            this.button5.Text = "Agregar Cancion";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 527);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnArUp);
            this.Controls.Add(this.txtARCasaUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArPaisUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArNomUP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBusAr);
            this.Controls.Add(this.txtFilAr);
            this.Controls.Add(this.btnSaveAr);
            this.Controls.Add(this.txtArCasa);
            this.Controls.Add(this.txtArPais);
            this.Controls.Add(this.txtArNombre);
            this.Controls.Add(this.lblCasa);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCasa;
        private System.Windows.Forms.TextBox txtArNombre;
        private System.Windows.Forms.TextBox txtArPais;
        private System.Windows.Forms.TextBox txtArCasa;
        private System.Windows.Forms.Button btnSaveAr;
        private System.Windows.Forms.TextBox txtFilAr;
        private System.Windows.Forms.Button btnBusAr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtArNomUP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArPaisUp;
        private System.Windows.Forms.TextBox txtARCasaUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnArUp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

