namespace CsvToCsv
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAbrirArchivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRutReceptor = new System.Windows.Forms.TextBox();
            this.labelTipoLibro = new System.Windows.Forms.Label();
            this.textBoxTipoLibro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCodAutRec = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGeneraCsv = new System.Windows.Forms.Button();
            this.buttonGeneraAllTax = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.96791F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.60714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.39286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1139, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1133, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "...";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.07921F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.92079F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel2.Controls.Add(this.buttonAbrirArchivo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxRutReceptor, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelTipoLibro, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTipoLibro, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCodAutRec, 6, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1039, 36);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // buttonAbrirArchivo
            // 
            this.buttonAbrirArchivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAbrirArchivo.Location = new System.Drawing.Point(3, 6);
            this.buttonAbrirArchivo.Name = "buttonAbrirArchivo";
            this.buttonAbrirArchivo.Size = new System.Drawing.Size(75, 23);
            this.buttonAbrirArchivo.TabIndex = 1;
            this.buttonAbrirArchivo.Text = "Abrir Archivo";
            this.buttonAbrirArchivo.UseVisualStyleBackColor = true;
            this.buttonAbrirArchivo.Click += new System.EventHandler(this.buttonAbrirArchivo_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rut Receptor: ";
            // 
            // textBoxRutReceptor
            // 
            this.textBoxRutReceptor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRutReceptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRutReceptor.Location = new System.Drawing.Point(208, 7);
            this.textBoxRutReceptor.Name = "textBoxRutReceptor";
            this.textBoxRutReceptor.Size = new System.Drawing.Size(97, 22);
            this.textBoxRutReceptor.TabIndex = 3;
            this.textBoxRutReceptor.Text = "00000000-0";
            this.textBoxRutReceptor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTipoLibro
            // 
            this.labelTipoLibro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTipoLibro.AutoSize = true;
            this.labelTipoLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoLibro.Location = new System.Drawing.Point(327, 10);
            this.labelTipoLibro.Name = "labelTipoLibro";
            this.labelTipoLibro.Size = new System.Drawing.Size(83, 16);
            this.labelTipoLibro.TabIndex = 4;
            this.labelTipoLibro.Text = "Tipo Libro: ";
            // 
            // textBoxTipoLibro
            // 
            this.textBoxTipoLibro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTipoLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTipoLibro.Location = new System.Drawing.Point(419, 7);
            this.textBoxTipoLibro.Name = "textBoxTipoLibro";
            this.textBoxTipoLibro.Size = new System.Drawing.Size(99, 22);
            this.textBoxTipoLibro.TabIndex = 5;
            this.textBoxTipoLibro.Text = "MENSUAL";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cod. Aut. Rectifica: ";
            // 
            // textBoxCodAutRec
            // 
            this.textBoxCodAutRec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCodAutRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodAutRec.Location = new System.Drawing.Point(691, 7);
            this.textBoxCodAutRec.Name = "textBoxCodAutRec";
            this.textBoxCodAutRec.Size = new System.Drawing.Size(158, 22);
            this.textBoxCodAutRec.TabIndex = 7;
            this.textBoxCodAutRec.Text = "0";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.buttonGeneraCsv, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonGeneraAllTax, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 396);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(588, 69);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // buttonGeneraCsv
            // 
            this.buttonGeneraCsv.Location = new System.Drawing.Point(3, 3);
            this.buttonGeneraCsv.Name = "buttonGeneraCsv";
            this.buttonGeneraCsv.Size = new System.Drawing.Size(123, 23);
            this.buttonGeneraCsv.TabIndex = 3;
            this.buttonGeneraCsv.Text = "Genera solo con IVA";
            this.buttonGeneraCsv.UseVisualStyleBackColor = true;
            this.buttonGeneraCsv.Click += new System.EventHandler(this.buttonGeneraCsv_Click);
            // 
            // buttonGeneraAllTax
            // 
            this.buttonGeneraAllTax.Location = new System.Drawing.Point(139, 3);
            this.buttonGeneraAllTax.Name = "buttonGeneraAllTax";
            this.buttonGeneraAllTax.Size = new System.Drawing.Size(177, 36);
            this.buttonGeneraAllTax.TabIndex = 4;
            this.buttonGeneraAllTax.Text = "Genera con todos los impuestos(Transtecnia)";
            this.buttonGeneraAllTax.UseVisualStyleBackColor = true;
            this.buttonGeneraAllTax.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Genera con todos los impuestos(Dila)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonAbrirArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGeneraCsv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRutReceptor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonGeneraAllTax;
        private System.Windows.Forms.Label labelTipoLibro;
        private System.Windows.Forms.TextBox textBoxTipoLibro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCodAutRec;
        private System.Windows.Forms.Button button1;
    }
}

