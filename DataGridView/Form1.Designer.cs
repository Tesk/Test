namespace DataGridView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Navn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post_Distrikt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontigent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIndlæs = new System.Windows.Forms.Button();
            this.btnOpret = new System.Windows.Forms.Button();
            this.btnNyDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Navn,
            this.Adresse,
            this.PostNr,
            this.Post_Distrikt,
            this.Kontigent});
            this.dataGridView1.Location = new System.Drawing.Point(25, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 461);
            this.dataGridView1.TabIndex = 0;
            // 
            // Navn
            // 
            this.Navn.HeaderText = "Navn";
            this.Navn.Name = "Navn";
            this.Navn.ReadOnly = true;
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            this.Adresse.ReadOnly = true;
            // 
            // PostNr
            // 
            this.PostNr.HeaderText = "PostNr";
            this.PostNr.Name = "PostNr";
            this.PostNr.ReadOnly = true;
            // 
            // Post_Distrikt
            // 
            this.Post_Distrikt.HeaderText = "Post Distrikt";
            this.Post_Distrikt.Name = "Post_Distrikt";
            this.Post_Distrikt.ReadOnly = true;
            // 
            // Kontigent
            // 
            this.Kontigent.HeaderText = "Kontigent";
            this.Kontigent.Name = "Kontigent";
            this.Kontigent.ReadOnly = true;
            // 
            // btnIndlæs
            // 
            this.btnIndlæs.Location = new System.Drawing.Point(25, 508);
            this.btnIndlæs.Name = "btnIndlæs";
            this.btnIndlæs.Size = new System.Drawing.Size(75, 23);
            this.btnIndlæs.TabIndex = 1;
            this.btnIndlæs.Text = "Indlæs";
            this.btnIndlæs.UseVisualStyleBackColor = true;
            this.btnIndlæs.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpret
            // 
            this.btnOpret.Location = new System.Drawing.Point(494, 508);
            this.btnOpret.Name = "btnOpret";
            this.btnOpret.Size = new System.Drawing.Size(75, 23);
            this.btnOpret.TabIndex = 2;
            this.btnOpret.Text = "Opret";
            this.btnOpret.UseVisualStyleBackColor = true;
            this.btnOpret.Click += new System.EventHandler(this.btnOpret_Click);
            // 
            // btnNyDatabase
            // 
            this.btnNyDatabase.Location = new System.Drawing.Point(25, 13);
            this.btnNyDatabase.Name = "btnNyDatabase";
            this.btnNyDatabase.Size = new System.Drawing.Size(75, 23);
            this.btnNyDatabase.TabIndex = 3;
            this.btnNyDatabase.Text = "Ny database";
            this.btnNyDatabase.UseVisualStyleBackColor = true;
            this.btnNyDatabase.Click += new System.EventHandler(this.btnNyDatabase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 543);
            this.Controls.Add(this.btnNyDatabase);
            this.Controls.Add(this.btnOpret);
            this.Controls.Add(this.btnIndlæs);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIndlæs;
        private System.Windows.Forms.Button btnOpret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Navn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post_Distrikt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontigent;
        private System.Windows.Forms.Button btnNyDatabase;
    }
}

