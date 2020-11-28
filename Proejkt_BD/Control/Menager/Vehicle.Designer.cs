namespace Proejkt_BD.Control.Menager
{
    partial class Vehicle
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oBJECTBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.rSSDataSet = new Proejkt_BD.RSSDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.addButton1 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.oBJECTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oBJECTTableAdapter = new Proejkt_BD.RSSDataSetTableAdapters.OBJECTTableAdapter();
            this.oBJECTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.objectFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nrobjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBJECTBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBJECTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBJECTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectFullBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrobjectDataGridViewTextBoxColumn,
            this.client_name,
            this.Type_name,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.objectFullBindingSource;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(10, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(786, 282);
            this.dataGridView1.TabIndex = 44;
            // 
            // oBJECTBindingSource2
            // 
            this.oBJECTBindingSource2.DataMember = "OBJECT";
            this.oBJECTBindingSource2.DataSource = this.rSSDataSet;
            // 
            // rSSDataSet
            // 
            this.rSSDataSet.DataSetName = "RSSDataSet";
            this.rSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(418, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 54);
            this.button1.TabIndex = 39;
            this.button1.Text = "Vehicle Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addButton1
            // 
            this.addButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addButton1.Location = new System.Drawing.Point(10, 332);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(403, 54);
            this.addButton1.TabIndex = 38;
            this.addButton1.Text = "Add New Vehicle";
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(668, 11);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(128, 27);
            this.searchBox.TabIndex = 37;
            this.searchBox.Text = "Search";
            this.searchBox.UseVisualStyleBackColor = true;
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(550, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(474, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Object type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(307, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(125, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Nr vehicle";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(352, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 46;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(194, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(7, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Vehicle details";
            // 
            // oBJECTBindingSource
            // 
            this.oBJECTBindingSource.DataMember = "OBJECT";
            this.oBJECTBindingSource.DataSource = this.rSSDataSet;
            // 
            // oBJECTTableAdapter
            // 
            this.oBJECTTableAdapter.ClearBeforeFill = true;
            // 
            // oBJECTBindingSource1
            // 
            this.oBJECTBindingSource1.DataMember = "OBJECT";
            this.oBJECTBindingSource1.DataSource = this.rSSDataSet;
            // 
            // objectFullBindingSource
            // 
            this.objectFullBindingSource.DataSource = typeof(Proejkt_BD.Control.Baza.Modele.ObjectFull);
            // 
            // nrobjectDataGridViewTextBoxColumn
            // 
            this.nrobjectDataGridViewTextBoxColumn.DataPropertyName = "nr_object";
            this.nrobjectDataGridViewTextBoxColumn.HeaderText = "nr_object";
            this.nrobjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrobjectDataGridViewTextBoxColumn.Name = "nrobjectDataGridViewTextBoxColumn";
            this.nrobjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrobjectDataGridViewTextBoxColumn.Width = 125;
            // 
            // client_name
            // 
            this.client_name.DataPropertyName = "client_name";
            this.client_name.HeaderText = "client_name";
            this.client_name.Name = "client_name";
            this.client_name.ReadOnly = true;
            // 
            // Type_name
            // 
            this.Type_name.DataPropertyName = "type_name";
            this.Type_name.HeaderText = "Type_name";
            this.Type_name.Name = "Type_name";
            this.Type_name.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.searchBox);
            this.Name = "Vehicle";
            this.Size = new System.Drawing.Size(802, 392);
            this.Load += new System.EventHandler(this.Vehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBJECTBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBJECTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBJECTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectFullBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.Button searchBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource oBJECTBindingSource;
        private RSSDataSet rSSDataSet;
        private RSSDataSetTableAdapters.OBJECTTableAdapter oBJECTTableAdapter;
        private System.Windows.Forms.BindingSource oBJECTBindingSource2;
        private System.Windows.Forms.BindingSource oBJECTBindingSource1;
        private System.Windows.Forms.BindingSource objectFullBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrobjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}
