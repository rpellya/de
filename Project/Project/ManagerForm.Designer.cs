namespace Project
{
    partial class ManagerForm
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
            this.buttonChangeMaster = new System.Windows.Forms.Button();
            this.buttonChangeEndDate = new System.Windows.Forms.Button();
            this.buttonСlose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(12, 26);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(180, 24);
            this.Title.TabIndex = 2;
            this.Title.Text = "Форма менеджера";
            // 
            // buttonChangeMaster
            // 
            this.buttonChangeMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeMaster.Location = new System.Drawing.Point(12, 75);
            this.buttonChangeMaster.Name = "buttonChangeMaster";
            this.buttonChangeMaster.Size = new System.Drawing.Size(352, 39);
            this.buttonChangeMaster.TabIndex = 6;
            this.buttonChangeMaster.Text = "Переназначить мастера";
            this.buttonChangeMaster.UseVisualStyleBackColor = true;
            this.buttonChangeMaster.Click += new System.EventHandler(this.buttonChangeMaster_Click);
            // 
            // buttonChangeEndDate
            // 
            this.buttonChangeEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeEndDate.Location = new System.Drawing.Point(12, 137);
            this.buttonChangeEndDate.Name = "buttonChangeEndDate";
            this.buttonChangeEndDate.Size = new System.Drawing.Size(352, 39);
            this.buttonChangeEndDate.TabIndex = 7;
            this.buttonChangeEndDate.Text = "Изменить время";
            this.buttonChangeEndDate.UseVisualStyleBackColor = true;
            this.buttonChangeEndDate.Click += new System.EventHandler(this.buttonChangeEndDate_Click);
            // 
            // buttonСlose
            // 
            this.buttonСlose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonСlose.Location = new System.Drawing.Point(12, 203);
            this.buttonСlose.Name = "buttonСlose";
            this.buttonСlose.Size = new System.Drawing.Size(352, 39);
            this.buttonСlose.TabIndex = 8;
            this.buttonСlose.Text = "Назад";
            this.buttonСlose.UseVisualStyleBackColor = true;
            this.buttonСlose.Click += new System.EventHandler(this.buttonСlose_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 258);
            this.Controls.Add(this.buttonСlose);
            this.Controls.Add(this.buttonChangeEndDate);
            this.Controls.Add(this.buttonChangeMaster);
            this.Controls.Add(this.Title);
            this.Name = "ManagerForm";
            this.Text = "Форма менеджера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button buttonChangeMaster;
        private System.Windows.Forms.Button buttonChangeEndDate;
        private System.Windows.Forms.Button buttonСlose;
    }
}