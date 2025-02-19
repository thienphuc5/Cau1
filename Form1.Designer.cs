namespace WindowsFormsApp6
{
    partial class Form1
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
            this.lbten = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbclass = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(66, 57);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(31, 16);
            this.lbten.TabIndex = 0;
            this.lbten.Text = "Tên";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(256, 57);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(32, 16);
            this.lbAge.TabIndex = 1;
            this.lbAge.Text = "Age";
            // 
            // lbclass
            // 
            this.lbclass.AutoSize = true;
            this.lbclass.Location = new System.Drawing.Point(476, 60);
            this.lbclass.Name = "lbclass";
            this.lbclass.Size = new System.Drawing.Size(41, 16);
            this.lbclass.TabIndex = 2;
            this.lbclass.Text = "Class";
            this.lbclass.Click += new System.EventHandler(this.lbclass_Click);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(114, 54);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 22);
            this.txtten.TabIndex = 3;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(312, 54);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 22);
            this.txtage.TabIndex = 4;
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(534, 54);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(100, 22);
            this.txtclass.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(564, 298);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(637, 151);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.Button1_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.lbclass);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbclass;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
    }
}

