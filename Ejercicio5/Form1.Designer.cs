namespace Ejercicio5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAnhadir = new System.Windows.Forms.Button();
            this.txtAnhadir = new System.Windows.Forms.TextBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnTraspasarIzq = new System.Windows.Forms.Button();
            this.btnTraspasarDer = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblIndices = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(51, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(261, 204);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.seleccionDeElementos);
            // 
            // btnAnhadir
            // 
            this.btnAnhadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAnhadir.Location = new System.Drawing.Point(12, 288);
            this.btnAnhadir.Name = "btnAnhadir";
            this.btnAnhadir.Size = new System.Drawing.Size(120, 43);
            this.btnAnhadir.TabIndex = 2;
            this.btnAnhadir.Text = "Añadir";
            this.btnAnhadir.UseVisualStyleBackColor = true;
            this.btnAnhadir.Click += new System.EventHandler(this.btnAnhadir_Click);
            // 
            // txtAnhadir
            // 
            this.txtAnhadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAnhadir.Location = new System.Drawing.Point(138, 297);
            this.txtAnhadir.Name = "txtAnhadir";
            this.txtAnhadir.Size = new System.Drawing.Size(181, 26);
            this.txtAnhadir.TabIndex = 3;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTamanho.Location = new System.Drawing.Point(391, 258);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(80, 24);
            this.lblTamanho.TabIndex = 4;
            this.lblTamanho.Text = "Tamaño";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnQuitar.Location = new System.Drawing.Point(12, 239);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(120, 43);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnTraspasarIzq
            // 
            this.btnTraspasarIzq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnTraspasarIzq.Location = new System.Drawing.Point(318, 124);
            this.btnTraspasarIzq.Name = "btnTraspasarIzq";
            this.btnTraspasarIzq.Size = new System.Drawing.Size(124, 43);
            this.btnTraspasarIzq.TabIndex = 6;
            this.btnTraspasarIzq.Text = "Traspasar >";
            this.btnTraspasarIzq.UseVisualStyleBackColor = true;
            this.btnTraspasarIzq.Click += new System.EventHandler(this.traspasar);
            // 
            // btnTraspasarDer
            // 
            this.btnTraspasarDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnTraspasarDer.Location = new System.Drawing.Point(350, 47);
            this.btnTraspasarDer.Name = "btnTraspasarDer";
            this.btnTraspasarDer.Size = new System.Drawing.Size(124, 43);
            this.btnTraspasarDer.TabIndex = 7;
            this.btnTraspasarDer.Text = "< Traspasar";
            this.btnTraspasarDer.UseVisualStyleBackColor = true;
            this.btnTraspasarDer.Click += new System.EventHandler(this.traspasar);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(480, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(261, 204);
            this.listBox2.TabIndex = 8;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.seleccionDeElementos);
            // 
            // lblIndices
            // 
            this.lblIndices.AutoSize = true;
            this.lblIndices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblIndices.Location = new System.Drawing.Point(391, 299);
            this.lblIndices.Name = "lblIndices";
            this.lblIndices.Size = new System.Drawing.Size(70, 24);
            this.lblIndices.TabIndex = 9;
            this.lblIndices.Text = "Índices";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAnhadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 343);
            this.Controls.Add(this.lblIndices);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnTraspasarDer);
            this.Controls.Add(this.btnTraspasarIzq);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.txtAnhadir);
            this.Controls.Add(this.btnAnhadir);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAnhadir;
        private System.Windows.Forms.TextBox txtAnhadir;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnTraspasarIzq;
        private System.Windows.Forms.Button btnTraspasarDer;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblIndices;
    }
}

