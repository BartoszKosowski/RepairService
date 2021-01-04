namespace Proejkt_BD.Control.Worker
{
    partial class WorkerPanel
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
            this.components = new System.ComponentModel.Container();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idactivityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateregDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefncnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpersonelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actdictDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sequencenbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTIVITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rSSDataSet = new Proejkt_BD.RSSDataSet();
            this.aCTIVITYTableAdapter = new Proejkt_BD.RSSDataSetTableAdapters.ACTIVITYTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVITYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSSDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checkBox1.Location = new System.Drawing.Point(400, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 23);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Activity list";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button1.Location = new System.Drawing.Point(456, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(188, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Status";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button5.Location = new System.Drawing.Point(881, 11);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 26);
            this.button5.TabIndex = 26;
            this.button5.Text = "Log out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(263, 66);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(119, 24);
            this.dateTimePicker2.TabIndex = 28;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ALL",
            "OPN",
            "CAN",
            "ACT",
            "XXX"});
            this.comboBox1.Location = new System.Drawing.Point(88, 64);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 25);
            this.comboBox1.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 1);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(319, 49);
            this.label5.TabIndex = 30;
            this.label5.Text = "WORKER PANEL";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idactivityDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dateregDataGridViewTextBoxColumn,
            this.datefncnDataGridViewTextBoxColumn,
            this.idrequestDataGridViewTextBoxColumn,
            this.idpersonelDataGridViewTextBoxColumn,
            this.actdictDataGridViewTextBoxColumn,
            this.sequencenbDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aCTIVITYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 132);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 295);
            this.dataGridView1.TabIndex = 31;
            // 
            // idactivityDataGridViewTextBoxColumn
            // 
            this.idactivityDataGridViewTextBoxColumn.DataPropertyName = "id_activity";
            this.idactivityDataGridViewTextBoxColumn.HeaderText = "id_activity";
            this.idactivityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idactivityDataGridViewTextBoxColumn.Name = "idactivityDataGridViewTextBoxColumn";
            this.idactivityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "result";
            this.resultDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateregDataGridViewTextBoxColumn
            // 
            this.dateregDataGridViewTextBoxColumn.DataPropertyName = "date_reg";
            this.dateregDataGridViewTextBoxColumn.HeaderText = "date_reg";
            this.dateregDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateregDataGridViewTextBoxColumn.Name = "dateregDataGridViewTextBoxColumn";
            this.dateregDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datefncnDataGridViewTextBoxColumn
            // 
            this.datefncnDataGridViewTextBoxColumn.DataPropertyName = "date_fn_cn";
            this.datefncnDataGridViewTextBoxColumn.HeaderText = "date_fn_cn";
            this.datefncnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datefncnDataGridViewTextBoxColumn.Name = "datefncnDataGridViewTextBoxColumn";
            this.datefncnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idrequestDataGridViewTextBoxColumn
            // 
            this.idrequestDataGridViewTextBoxColumn.DataPropertyName = "id_request";
            this.idrequestDataGridViewTextBoxColumn.HeaderText = "id_request";
            this.idrequestDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idrequestDataGridViewTextBoxColumn.Name = "idrequestDataGridViewTextBoxColumn";
            this.idrequestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpersonelDataGridViewTextBoxColumn
            // 
            this.idpersonelDataGridViewTextBoxColumn.DataPropertyName = "id_personel";
            this.idpersonelDataGridViewTextBoxColumn.HeaderText = "id_personel";
            this.idpersonelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpersonelDataGridViewTextBoxColumn.Name = "idpersonelDataGridViewTextBoxColumn";
            this.idpersonelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actdictDataGridViewTextBoxColumn
            // 
            this.actdictDataGridViewTextBoxColumn.DataPropertyName = "act_dict";
            this.actdictDataGridViewTextBoxColumn.HeaderText = "act_dict";
            this.actdictDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.actdictDataGridViewTextBoxColumn.Name = "actdictDataGridViewTextBoxColumn";
            this.actdictDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sequencenbDataGridViewTextBoxColumn
            // 
            this.sequencenbDataGridViewTextBoxColumn.DataPropertyName = "sequence_nb";
            this.sequencenbDataGridViewTextBoxColumn.HeaderText = "sequence_nb";
            this.sequencenbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sequencenbDataGridViewTextBoxColumn.Name = "sequencenbDataGridViewTextBoxColumn";
            this.sequencenbDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aCTIVITYBindingSource
            // 
            this.aCTIVITYBindingSource.DataMember = "ACTIVITY";
            this.aCTIVITYBindingSource.DataSource = this.rSSDataSet;
            // 
            // rSSDataSet
            // 
            this.rSSDataSet.DataSetName = "RSSDataSet";
            this.rSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCTIVITYTableAdapter
            // 
            this.aCTIVITYTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBox1.Location = new System.Drawing.Point(814, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(56, 24);
            this.textBox1.TabIndex = 32;
            this.textBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button2.Location = new System.Drawing.Point(10, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(490, 41);
            this.button2.TabIndex = 33;
            this.button2.Text = "Show Activity Details";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button3.Location = new System.Drawing.Point(506, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(505, 41);
            this.button3.TabIndex = 34;
            this.button3.Text = "Edit Activity";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 50);
            this.panel1.TabIndex = 35;
            // 
            // WorkerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WorkerPanel";
            this.Text = "WorkerPanel";
            this.Load += new System.EventHandler(this.WorkerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVITYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSSDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RSSDataSet rSSDataSet;
        private System.Windows.Forms.BindingSource aCTIVITYBindingSource;
        private RSSDataSetTableAdapters.ACTIVITYTableAdapter aCTIVITYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idactivityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateregDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefncnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actdictDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequencenbDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
    }
}