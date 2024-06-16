namespace Project
{
    partial class OperatorForm
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
            this.buttonAddRequest = new System.Windows.Forms.Button();
            this.buttonEditRequest = new System.Windows.Forms.Button();
            this.buttonGetStat = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(12, 24);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(172, 24);
            this.Title.TabIndex = 4;
            this.Title.Text = "Форма оператора";
            // 
            // buttonAddRequest
            // 
            this.buttonAddRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddRequest.Location = new System.Drawing.Point(12, 77);
            this.buttonAddRequest.Name = "buttonAddRequest";
            this.buttonAddRequest.Size = new System.Drawing.Size(258, 39);
            this.buttonAddRequest.TabIndex = 6;
            this.buttonAddRequest.Text = "Создать заявку";
            this.buttonAddRequest.UseVisualStyleBackColor = true;
            this.buttonAddRequest.Click += new System.EventHandler(this.buttonAddRequest_Click);
            // 
            // buttonEditRequest
            // 
            this.buttonEditRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditRequest.Location = new System.Drawing.Point(12, 146);
            this.buttonEditRequest.Name = "buttonEditRequest";
            this.buttonEditRequest.Size = new System.Drawing.Size(258, 39);
            this.buttonEditRequest.TabIndex = 7;
            this.buttonEditRequest.Text = "Отредактировать заявку";
            this.buttonEditRequest.UseVisualStyleBackColor = true;
            this.buttonEditRequest.Click += new System.EventHandler(this.buttonEditRequest_Click);
            // 
            // buttonGetStat
            // 
            this.buttonGetStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetStat.Location = new System.Drawing.Point(16, 218);
            this.buttonGetStat.Name = "buttonGetStat";
            this.buttonGetStat.Size = new System.Drawing.Size(254, 39);
            this.buttonGetStat.TabIndex = 8;
            this.buttonGetStat.Text = "Получить статистку";
            this.buttonGetStat.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(12, 399);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(258, 39);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Назад";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonGetStat);
            this.Controls.Add(this.buttonEditRequest);
            this.Controls.Add(this.buttonAddRequest);
            this.Controls.Add(this.Title);
            this.Name = "OperatorForm";
            this.Text = "Форма Оператора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button buttonAddRequest;
        private System.Windows.Forms.Button buttonEditRequest;
        private System.Windows.Forms.Button buttonGetStat;
        private System.Windows.Forms.Button buttonClose;
    }
}