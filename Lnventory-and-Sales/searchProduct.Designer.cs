namespace Lnventory_and_Sales
{
    partial class searchProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchProduct));
            this.dataGridsearch = new System.Windows.Forms.DataGridView();
            this.backmodify = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.name_search = new System.Windows.Forms.TextBox();
            this.namepro_delete = new System.Windows.Forms.Label();
            this.viewall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridsearch
            // 
            this.dataGridsearch.BackgroundColor = System.Drawing.Color.White;
            this.dataGridsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridsearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridsearch.Location = new System.Drawing.Point(0, 205);
            this.dataGridsearch.Name = "dataGridsearch";
            this.dataGridsearch.RowHeadersWidth = 51;
            this.dataGridsearch.RowTemplate.Height = 26;
            this.dataGridsearch.Size = new System.Drawing.Size(800, 204);
            this.dataGridsearch.TabIndex = 41;
            this.dataGridsearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridsearch_CellContentClick);
            // 
            // backmodify
            // 
            this.backmodify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backmodify.BackgroundImage")));
            this.backmodify.Location = new System.Drawing.Point(6, 6);
            this.backmodify.Name = "backmodify";
            this.backmodify.Size = new System.Drawing.Size(55, 59);
            this.backmodify.TabIndex = 40;
            this.backmodify.UseVisualStyleBackColor = true;
            this.backmodify.Click += new System.EventHandler(this.backmodify_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.search.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(341, 107);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(198, 43);
            this.search.TabIndex = 39;
            this.search.Text = "بحث";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // name_search
            // 
            this.name_search.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_search.Location = new System.Drawing.Point(438, 47);
            this.name_search.Multiline = true;
            this.name_search.Name = "name_search";
            this.name_search.Size = new System.Drawing.Size(200, 30);
            this.name_search.TabIndex = 36;
            // 
            // namepro_delete
            // 
            this.namepro_delete.AutoSize = true;
            this.namepro_delete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namepro_delete.Location = new System.Drawing.Point(160, 50);
            this.namepro_delete.Name = "namepro_delete";
            this.namepro_delete.Size = new System.Drawing.Size(261, 24);
            this.namepro_delete.TabIndex = 35;
            this.namepro_delete.Text = "ادخل اسم المنتج للبحث عنه :";
            // 
            // viewall
            // 
            this.viewall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.viewall.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewall.Location = new System.Drawing.Point(6, 161);
            this.viewall.Name = "viewall";
            this.viewall.Size = new System.Drawing.Size(174, 38);
            this.viewall.TabIndex = 42;
            this.viewall.Text = "عرض كل المنتجات";
            this.viewall.UseVisualStyleBackColor = false;
            this.viewall.Click += new System.EventHandler(this.viewall_Click);
            // 
            // searchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.viewall);
            this.Controls.Add(this.dataGridsearch);
            this.Controls.Add(this.backmodify);
            this.Controls.Add(this.search);
            this.Controls.Add(this.name_search);
            this.Controls.Add(this.namepro_delete);
            this.Name = "searchProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "البحث عن المنتج";
            this.Load += new System.EventHandler(this.searchProduct_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchProduct_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridsearch;
        private System.Windows.Forms.Button backmodify;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox name_search;
        private System.Windows.Forms.Label namepro_delete;
        private System.Windows.Forms.Button viewall;
    }
}