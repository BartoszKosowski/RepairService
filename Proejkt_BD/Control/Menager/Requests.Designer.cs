﻿namespace Proejkt_BD.Control.Menager
{
    partial class Requests
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
            this.button2 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idrequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateregDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefncnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpersonelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrobjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEQUESTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rSSDataSet = new Proejkt_BD.RSSDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rEQUESTTableAdapter = new Proejkt_BD.RSSDataSetTableAdapters.REQUESTTableAdapter();
            this.objectBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(673, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 31);
            this.button2.TabIndex = 33;
            this.button2.Text = "Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchBox.Location = new System.Drawing.Point(673, 14);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(122, 25);
            this.searchBox.TabIndex = 28;
            this.searchBox.Text = "Search";
            this.searchBox.UseVisualStyleBackColor = true;
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrequestDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.dateregDataGridViewTextBoxColumn,
            this.datefncnDataGridViewTextBoxColumn,
            this.idpersonelDataGridViewTextBoxColumn,
            this.nrobjectDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rEQUESTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(786, 297);
            this.dataGridView1.TabIndex = 45;
            // 
            // idrequestDataGridViewTextBoxColumn
            // 
            this.idrequestDataGridViewTextBoxColumn.DataPropertyName = "id_request";
            this.idrequestDataGridViewTextBoxColumn.HeaderText = "id_request";
            this.idrequestDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idrequestDataGridViewTextBoxColumn.Name = "idrequestDataGridViewTextBoxColumn";
            this.idrequestDataGridViewTextBoxColumn.ReadOnly = true;
            this.idrequestDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "result";
            this.resultDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            this.resultDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateregDataGridViewTextBoxColumn
            // 
            this.dateregDataGridViewTextBoxColumn.DataPropertyName = "date_reg";
            this.dateregDataGridViewTextBoxColumn.HeaderText = "date_reg";
            this.dateregDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateregDataGridViewTextBoxColumn.Name = "dateregDataGridViewTextBoxColumn";
            this.dateregDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateregDataGridViewTextBoxColumn.Width = 125;
            // 
            // datefncnDataGridViewTextBoxColumn
            // 
            this.datefncnDataGridViewTextBoxColumn.DataPropertyName = "date_fn_cn";
            this.datefncnDataGridViewTextBoxColumn.HeaderText = "date_fn_cn";
            this.datefncnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datefncnDataGridViewTextBoxColumn.Name = "datefncnDataGridViewTextBoxColumn";
            this.datefncnDataGridViewTextBoxColumn.ReadOnly = true;
            this.datefncnDataGridViewTextBoxColumn.Width = 125;
            // 
            // idpersonelDataGridViewTextBoxColumn
            // 
            this.idpersonelDataGridViewTextBoxColumn.DataPropertyName = "id_personel";
            this.idpersonelDataGridViewTextBoxColumn.HeaderText = "id_personel";
            this.idpersonelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpersonelDataGridViewTextBoxColumn.Name = "idpersonelDataGridViewTextBoxColumn";
            this.idpersonelDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpersonelDataGridViewTextBoxColumn.Width = 125;
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
            // rEQUESTBindingSource
            // 
            this.rEQUESTBindingSource.DataMember = "REQUEST";
            this.rEQUESTBindingSource.DataSource = this.rSSDataSet;
            // 
            // rSSDataSet
            // 
            this.rSSDataSet.DataSetName = "RSSDataSet";
            this.rSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ALL",
            "OPN",
            "CAN",
            "ACT",
            "XXX"});
            this.comboBox1.Location = new System.Drawing.Point(54, 14);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 21);
            this.comboBox1.TabIndex = 49;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(188, 15);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker2.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(149, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Status";
            // 
            // rEQUESTTableAdapter
            // 
            this.rEQUESTTableAdapter.ClearBeforeFill = true;
            // 
            // objectBox
            // 
            this.objectBox.Location = new System.Drawing.Point(400, 15);
            this.objectBox.Name = "objectBox";
            this.objectBox.Size = new System.Drawing.Size(115, 20);
            this.objectBox.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(336, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Nr object";
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.objectBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Requests";
            this.Size = new System.Drawing.Size(802, 392);
            this.Load += new System.EventHandler(this.Requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button searchBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateregDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefncnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrobjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rEQUESTBindingSource;
        private RSSDataSet rSSDataSet;
        private RSSDataSetTableAdapters.REQUESTTableAdapter rEQUESTTableAdapter;
        private System.Windows.Forms.TextBox objectBox;
        private System.Windows.Forms.Label label3;
    }
}
