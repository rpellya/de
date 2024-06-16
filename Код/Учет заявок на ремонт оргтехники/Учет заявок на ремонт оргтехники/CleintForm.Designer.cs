namespace Учет_заявок_на_ремонт_оргтехники
{
    partial class CleintForm
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
        #endregion

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.de_example_1DataSet = new Учет_заявок_на_ремонт_оргтехники.de_example_1DataSet();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestsTableAdapter = new Учет_заявок_на_ремонт_оргтехники.de_example_1DataSetTableAdapters.RequestsTableAdapter();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestStatusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairPartsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_example_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(281, 380);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(419, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Сломанное устройство:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 441);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Описание проблемы:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(36, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 64);
            this.button2.TabIndex = 7;
            this.button2.Text = "Создать заявку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.IndianRed;
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(1028, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 36);
            this.button7.TabIndex = 12;
            this.button7.Text = "Назад";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.problemDescriptionDataGridViewTextBoxColumn,
            this.requestStatusIDDataGridViewTextBoxColumn,
            this.completionDateDataGridViewTextBoxColumn,
            this.repairPartsDataGridViewTextBoxColumn,
            this.masterIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.requestsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 269);
            this.dataGridView1.TabIndex = 13;
            // 
            // de_example_1DataSet
            // 
            this.de_example_1DataSet.DataSetName = "de_example_1DataSet";
            this.de_example_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataMember = "Requests";
            this.requestsBindingSource.DataSource = this.de_example_1DataSet;
            // 
            // requestsTableAdapter
            // 
            this.requestsTableAdapter.ClearBeforeFill = true;
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "requestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "requestID";
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // problemDescriptionDataGridViewTextBoxColumn
            // 
            this.problemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "problemDescription";
            this.problemDescriptionDataGridViewTextBoxColumn.HeaderText = "problemDescription";
            this.problemDescriptionDataGridViewTextBoxColumn.Name = "problemDescriptionDataGridViewTextBoxColumn";
            // 
            // requestStatusIDDataGridViewTextBoxColumn
            // 
            this.requestStatusIDDataGridViewTextBoxColumn.DataPropertyName = "requestStatusID";
            this.requestStatusIDDataGridViewTextBoxColumn.HeaderText = "requestStatusID";
            this.requestStatusIDDataGridViewTextBoxColumn.Name = "requestStatusIDDataGridViewTextBoxColumn";
            // 
            // completionDateDataGridViewTextBoxColumn
            // 
            this.completionDateDataGridViewTextBoxColumn.DataPropertyName = "completionDate";
            this.completionDateDataGridViewTextBoxColumn.HeaderText = "completionDate";
            this.completionDateDataGridViewTextBoxColumn.Name = "completionDateDataGridViewTextBoxColumn";
            // 
            // repairPartsDataGridViewTextBoxColumn
            // 
            this.repairPartsDataGridViewTextBoxColumn.DataPropertyName = "repairParts";
            this.repairPartsDataGridViewTextBoxColumn.HeaderText = "repairParts";
            this.repairPartsDataGridViewTextBoxColumn.Name = "repairPartsDataGridViewTextBoxColumn";
            // 
            // masterIDDataGridViewTextBoxColumn
            // 
            this.masterIDDataGridViewTextBoxColumn.DataPropertyName = "masterID";
            this.masterIDDataGridViewTextBoxColumn.HeaderText = "masterID";
            this.masterIDDataGridViewTextBoxColumn.Name = "masterIDDataGridViewTextBoxColumn";
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "clientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "clientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(857, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(857, 529);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(238, 20);
            this.textBox3.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(857, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 64);
            this.button1.TabIndex = 16;
            this.button1.Text = "Сгенерировать ссылку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CleintForm
            // 
            this.ClientSize = new System.Drawing.Size(1107, 631);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "CleintForm";
            this.Text = "Создание заявки";
            this.Load += new System.EventHandler(this.CleintForm_Load);
            this.Leave += new System.EventHandler(this.CleintForm_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_example_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private de_example_1DataSet de_example_1DataSet;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private de_example_1DataSetTableAdapters.RequestsTableAdapter requestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestStatusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairPartsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}