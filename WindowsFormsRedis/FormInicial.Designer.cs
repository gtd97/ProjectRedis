namespace WindowsFormsRedis
{
    partial class FormInicial
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
            this.bt_añadir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.tb_id_eliminar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_añadir
            // 
            this.bt_añadir.Location = new System.Drawing.Point(244, 230);
            this.bt_añadir.Name = "bt_añadir";
            this.bt_añadir.Size = new System.Drawing.Size(75, 23);
            this.bt_añadir.TabIndex = 0;
            this.bt_añadir.Text = "Añadir";
            this.bt_añadir.UseVisualStyleBackColor = true;
            this.bt_añadir.Click += new System.EventHandler(this.click_añadir);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "Listado de Alumno";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 157);
            this.dataGridView1.TabIndex = 4;
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(325, 230);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 23);
            this.bt_editar.TabIndex = 0;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.click_editar);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Location = new System.Drawing.Point(96, 230);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 23);
            this.bt_eliminar.TabIndex = 0;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.click_eliminar);
            // 
            // tb_id_eliminar
            // 
            this.tb_id_eliminar.Location = new System.Drawing.Point(30, 232);
            this.tb_id_eliminar.Name = "tb_id_eliminar";
            this.tb_id_eliminar.Size = new System.Drawing.Size(60, 20);
            this.tb_id_eliminar.TabIndex = 5;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 265);
            this.Controls.Add(this.tb_id_eliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_añadir);
            this.Name = "FormInicial";
            this.Text = "FormInicial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_añadir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.TextBox tb_id_eliminar;
    }
}