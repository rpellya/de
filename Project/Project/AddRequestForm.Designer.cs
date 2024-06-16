namespace Project
{
    partial class AddRequestForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAddRequest = new System.Windows.Forms.Button();
            this.labelTechType = new System.Windows.Forms.Label();
            this.comboBoxTechType = new System.Windows.Forms.ComboBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(12, 23);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(227, 24);
            this.Title.TabIndex = 1;
            this.Title.Text = "Форма создания заявки";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(10, 592);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(161, 39);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Назад";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAddRequest
            // 
            this.buttonAddRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddRequest.Location = new System.Drawing.Point(417, 592);
            this.buttonAddRequest.Name = "buttonAddRequest";
            this.buttonAddRequest.Size = new System.Drawing.Size(161, 39);
            this.buttonAddRequest.TabIndex = 7;
            this.buttonAddRequest.Text = "Создать";
            this.buttonAddRequest.UseVisualStyleBackColor = true;
            this.buttonAddRequest.Click += new System.EventHandler(this.buttonAddRequest_Click);
            // 
            // labelTechType
            // 
            this.labelTechType.AutoSize = true;
            this.labelTechType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTechType.Location = new System.Drawing.Point(12, 89);
            this.labelTechType.Name = "labelTechType";
            this.labelTechType.Size = new System.Drawing.Size(122, 24);
            this.labelTechType.TabIndex = 8;
            this.labelTechType.Text = "Тип техники";
            // 
            // comboBoxTechType
            // 
            this.comboBoxTechType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTechType.FormattingEnabled = true;
            this.comboBoxTechType.Location = new System.Drawing.Point(12, 125);
            this.comboBoxTechType.Name = "comboBoxTechType";
            this.comboBoxTechType.Size = new System.Drawing.Size(566, 32);
            this.comboBoxTechType.TabIndex = 9;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(12, 287);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(566, 32);
            this.comboBoxClient.TabIndex = 11;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModel.Location = new System.Drawing.Point(12, 177);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(159, 24);
            this.labelModel.TabIndex = 10;
            this.labelModel.Text = "Модель техники";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxModel.Location = new System.Drawing.Point(12, 214);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(566, 29);
            this.textBoxModel.TabIndex = 12;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClient.Location = new System.Drawing.Point(12, 260);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(75, 24);
            this.labelClient.TabIndex = 13;
            this.labelClient.Text = "Клиент";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(16, 396);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(562, 96);
            this.richTextBoxDescription.TabIndex = 14;
            this.richTextBoxDescription.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(12, 369);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(196, 24);
            this.labelDescription.TabIndex = 15;
            this.labelDescription.Text = "Описание проблемы";
            // 
            // AddRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 643);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.comboBoxTechType);
            this.Controls.Add(this.labelTechType);
            this.Controls.Add(this.buttonAddRequest);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.Title);
            this.Name = "AddRequestForm";
            this.Text = "Форма создания заявки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAddRequest;
        private System.Windows.Forms.Label labelTechType;
        private System.Windows.Forms.ComboBox comboBoxTechType;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelDescription;
    }
}