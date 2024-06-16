namespace Project
{
    partial class EditRequestForm
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
            this.Title = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.comboBoxTechType = new System.Windows.Forms.ComboBox();
            this.labelTechType = new System.Windows.Forms.Label();
            this.buttonEditRequest = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStrart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMaster = new System.Windows.Forms.Label();
            this.comboBoxMaster = new System.Windows.Forms.ComboBox();
            this.numericUpDownRequestID = new System.Windows.Forms.NumericUpDown();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonLoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRequestID)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(12, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(291, 24);
            this.Title.TabIndex = 2;
            this.Title.Text = "Форма редактирования заявки";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(8, 361);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(196, 24);
            this.labelDescription.TabIndex = 23;
            this.labelDescription.Text = "Описание проблемы";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(12, 388);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(562, 96);
            this.richTextBoxDescription.TabIndex = 22;
            this.richTextBoxDescription.Text = "";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxModel.Location = new System.Drawing.Point(13, 315);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(566, 29);
            this.textBoxModel.TabIndex = 20;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModel.Location = new System.Drawing.Point(13, 278);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(159, 24);
            this.labelModel.TabIndex = 18;
            this.labelModel.Text = "Модель техники";
            // 
            // comboBoxTechType
            // 
            this.comboBoxTechType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTechType.FormattingEnabled = true;
            this.comboBoxTechType.Location = new System.Drawing.Point(13, 226);
            this.comboBoxTechType.Name = "comboBoxTechType";
            this.comboBoxTechType.Size = new System.Drawing.Size(566, 32);
            this.comboBoxTechType.TabIndex = 17;
            // 
            // labelTechType
            // 
            this.labelTechType.AutoSize = true;
            this.labelTechType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTechType.Location = new System.Drawing.Point(13, 190);
            this.labelTechType.Name = "labelTechType";
            this.labelTechType.Size = new System.Drawing.Size(122, 24);
            this.labelTechType.TabIndex = 16;
            this.labelTechType.Text = "Тип техники";
            // 
            // buttonEditRequest
            // 
            this.buttonEditRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditRequest.Location = new System.Drawing.Point(417, 655);
            this.buttonEditRequest.Name = "buttonEditRequest";
            this.buttonEditRequest.Size = new System.Drawing.Size(161, 39);
            this.buttonEditRequest.TabIndex = 25;
            this.buttonEditRequest.Text = "Редактировать";
            this.buttonEditRequest.UseVisualStyleBackColor = true;
            this.buttonEditRequest.Click += new System.EventHandler(this.buttonEditRequest_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(12, 655);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(161, 39);
            this.buttonClose.TabIndex = 24;
            this.buttonClose.Text = "Назад";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(12, 500);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(72, 24);
            this.labelStatus.TabIndex = 27;
            this.labelStatus.Text = "Статус";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(12, 527);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(566, 32);
            this.comboBoxStatus.TabIndex = 26;
            // 
            // dateTimePickerStrart
            // 
            this.dateTimePickerStrart.Location = new System.Drawing.Point(12, 156);
            this.dateTimePickerStrart.Name = "dateTimePickerStrart";
            this.dateTimePickerStrart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStrart.TabIndex = 28;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(379, 156);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Начало";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(375, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Конец";
            // 
            // labelMaster
            // 
            this.labelMaster.AutoSize = true;
            this.labelMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaster.Location = new System.Drawing.Point(10, 569);
            this.labelMaster.Name = "labelMaster";
            this.labelMaster.Size = new System.Drawing.Size(78, 24);
            this.labelMaster.TabIndex = 33;
            this.labelMaster.Text = "Мастер";
            // 
            // comboBoxMaster
            // 
            this.comboBoxMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMaster.FormattingEnabled = true;
            this.comboBoxMaster.Location = new System.Drawing.Point(10, 596);
            this.comboBoxMaster.Name = "comboBoxMaster";
            this.comboBoxMaster.Size = new System.Drawing.Size(566, 32);
            this.comboBoxMaster.TabIndex = 32;
            // 
            // numericUpDownRequestID
            // 
            this.numericUpDownRequestID.Location = new System.Drawing.Point(267, 83);
            this.numericUpDownRequestID.Name = "numericUpDownRequestID";
            this.numericUpDownRequestID.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRequestID.TabIndex = 34;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(93, 79);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(135, 24);
            this.labelID.TabIndex = 35;
            this.labelID.Text = "Номер заявки";
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadData.Location = new System.Drawing.Point(417, 56);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(161, 67);
            this.buttonLoadData.TabIndex = 36;
            this.buttonLoadData.Text = "Подгрузить данные";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // EditRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 709);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.numericUpDownRequestID);
            this.Controls.Add(this.labelMaster);
            this.Controls.Add(this.comboBoxMaster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStrart);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonEditRequest);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.comboBoxTechType);
            this.Controls.Add(this.labelTechType);
            this.Controls.Add(this.Title);
            this.Name = "EditRequestForm";
            this.Text = "Форма редактирования";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRequestID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ComboBox comboBoxTechType;
        private System.Windows.Forms.Label labelTechType;
        private System.Windows.Forms.Button buttonEditRequest;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerStrart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMaster;
        private System.Windows.Forms.ComboBox comboBoxMaster;
        private System.Windows.Forms.NumericUpDown numericUpDownRequestID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonLoadData;
    }
}