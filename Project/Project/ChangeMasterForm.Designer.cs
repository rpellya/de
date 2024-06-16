namespace Project
{
    partial class ChangeMasterForm
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.numericUpDownRequestID = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMaster = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonChangeRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRequestID)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(255, 24);
            this.Title.TabIndex = 4;
            this.Title.Text = "Форма изменения мастера";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(12, 61);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(135, 24);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "Номер заявки";
            // 
            // numericUpDownRequestID
            // 
            this.numericUpDownRequestID.Location = new System.Drawing.Point(16, 97);
            this.numericUpDownRequestID.Name = "numericUpDownRequestID";
            this.numericUpDownRequestID.Size = new System.Drawing.Size(247, 20);
            this.numericUpDownRequestID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Мастер";
            // 
            // comboBoxMaster
            // 
            this.comboBoxMaster.FormattingEnabled = true;
            this.comboBoxMaster.Location = new System.Drawing.Point(16, 172);
            this.comboBoxMaster.Name = "comboBoxMaster";
            this.comboBoxMaster.Size = new System.Drawing.Size(247, 21);
            this.comboBoxMaster.TabIndex = 8;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(12, 383);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(251, 39);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Назад";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonChangeRequest
            // 
            this.buttonChangeRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeRequest.Location = new System.Drawing.Point(16, 222);
            this.buttonChangeRequest.Name = "buttonChangeRequest";
            this.buttonChangeRequest.Size = new System.Drawing.Size(247, 39);
            this.buttonChangeRequest.TabIndex = 10;
            this.buttonChangeRequest.Text = "Изменить";
            this.buttonChangeRequest.UseVisualStyleBackColor = true;
            this.buttonChangeRequest.Click += new System.EventHandler(this.buttonChangeRequest_Click);
            // 
            // ChangeMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 450);
            this.Controls.Add(this.buttonChangeRequest);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.comboBoxMaster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownRequestID);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.Title);
            this.Name = "ChangeMasterForm";
            this.Text = "ChangeMasterForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRequestID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.NumericUpDown numericUpDownRequestID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMaster;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonChangeRequest;
    }
}