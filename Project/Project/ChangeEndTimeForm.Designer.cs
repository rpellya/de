namespace Project
{
    partial class ChangeEndTimeForm
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
            this.buttonChangeRequest = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.numericUpDownRequestID = new System.Windows.Forms.NumericUpDown();
            this.labelRequestID = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRequestID)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(424, 24);
            this.Title.TabIndex = 3;
            this.Title.Text = "Форма изменения времени окончания заявки";
            // 
            // buttonChangeRequest
            // 
            this.buttonChangeRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeRequest.Location = new System.Drawing.Point(16, 206);
            this.buttonChangeRequest.Name = "buttonChangeRequest";
            this.buttonChangeRequest.Size = new System.Drawing.Size(414, 39);
            this.buttonChangeRequest.TabIndex = 17;
            this.buttonChangeRequest.Text = "Изменить";
            this.buttonChangeRequest.UseVisualStyleBackColor = true;
            this.buttonChangeRequest.Click += new System.EventHandler(this.buttonChangeRequest_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(12, 388);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(418, 39);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Text = "Назад";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(12, 129);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(166, 24);
            this.labelDate.TabIndex = 14;
            this.labelDate.Text = "Время окончания";
            // 
            // numericUpDownRequestID
            // 
            this.numericUpDownRequestID.Location = new System.Drawing.Point(16, 81);
            this.numericUpDownRequestID.Name = "numericUpDownRequestID";
            this.numericUpDownRequestID.Size = new System.Drawing.Size(420, 20);
            this.numericUpDownRequestID.TabIndex = 13;
            // 
            // labelRequestID
            // 
            this.labelRequestID.AutoSize = true;
            this.labelRequestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRequestID.Location = new System.Drawing.Point(12, 45);
            this.labelRequestID.Name = "labelRequestID";
            this.labelRequestID.Size = new System.Drawing.Size(135, 24);
            this.labelRequestID.TabIndex = 12;
            this.labelRequestID.Text = "Номер заявки";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(16, 156);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(414, 20);
            this.dateTimePickerEndDate.TabIndex = 18;
            // 
            // ChangeEndTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.buttonChangeRequest);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.numericUpDownRequestID);
            this.Controls.Add(this.labelRequestID);
            this.Controls.Add(this.Title);
            this.Name = "ChangeEndTimeForm";
            this.Text = "ChangeEndTimeForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRequestID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button buttonChangeRequest;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.NumericUpDown numericUpDownRequestID;
        private System.Windows.Forms.Label labelRequestID;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
    }
}