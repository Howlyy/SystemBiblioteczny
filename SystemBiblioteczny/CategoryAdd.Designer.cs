namespace SystemBiblioteczny
{
    partial class CategoryAddForm
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
            this.CategoryAddLabel = new System.Windows.Forms.Label();
            this.CategoryAddButton = new System.Windows.Forms.Button();
            this.CategoryAddTB = new System.Windows.Forms.TextBox();
            this.CategoryDeleteLabel = new System.Windows.Forms.Label();
            this.CategoryDeleteTB = new System.Windows.Forms.TextBox();
            this.CategoryDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryAddLabel
            // 
            this.CategoryAddLabel.AutoSize = true;
            this.CategoryAddLabel.Location = new System.Drawing.Point(24, 71);
            this.CategoryAddLabel.Name = "CategoryAddLabel";
            this.CategoryAddLabel.Size = new System.Drawing.Size(135, 13);
            this.CategoryAddLabel.TabIndex = 0;
            this.CategoryAddLabel.Text = "Dodawanie nowej kategorii";
            // 
            // CategoryAddButton
            // 
            this.CategoryAddButton.Location = new System.Drawing.Point(108, 132);
            this.CategoryAddButton.Name = "CategoryAddButton";
            this.CategoryAddButton.Size = new System.Drawing.Size(128, 41);
            this.CategoryAddButton.TabIndex = 1;
            this.CategoryAddButton.Text = "Dodaj kategorie";
            this.CategoryAddButton.UseVisualStyleBackColor = true;
            this.CategoryAddButton.Click += new System.EventHandler(this.CategoryAddButton_Click);
            // 
            // CategoryAddTB
            // 
            this.CategoryAddTB.Location = new System.Drawing.Point(177, 68);
            this.CategoryAddTB.Name = "CategoryAddTB";
            this.CategoryAddTB.Size = new System.Drawing.Size(185, 20);
            this.CategoryAddTB.TabIndex = 2;
            // 
            // CategoryDeleteLabel
            // 
            this.CategoryDeleteLabel.AutoSize = true;
            this.CategoryDeleteLabel.Location = new System.Drawing.Point(24, 250);
            this.CategoryDeleteLabel.Name = "CategoryDeleteLabel";
            this.CategoryDeleteLabel.Size = new System.Drawing.Size(97, 13);
            this.CategoryDeleteLabel.TabIndex = 0;
            this.CategoryDeleteLabel.Text = "Usuwanie kategorii";
            // 
            // CategoryDeleteTB
            // 
            this.CategoryDeleteTB.Location = new System.Drawing.Point(177, 247);
            this.CategoryDeleteTB.Name = "CategoryDeleteTB";
            this.CategoryDeleteTB.Size = new System.Drawing.Size(185, 20);
            this.CategoryDeleteTB.TabIndex = 2;
            // 
            // CategoryDeleteButton
            // 
            this.CategoryDeleteButton.Location = new System.Drawing.Point(108, 323);
            this.CategoryDeleteButton.Name = "CategoryDeleteButton";
            this.CategoryDeleteButton.Size = new System.Drawing.Size(128, 41);
            this.CategoryDeleteButton.TabIndex = 1;
            this.CategoryDeleteButton.Text = "Usuń kategorie";
            this.CategoryDeleteButton.UseVisualStyleBackColor = true;
            this.CategoryDeleteButton.Click += new System.EventHandler(this.CategoryDeleteButton_Click);
            // 
            // CategoryAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 390);
            this.Controls.Add(this.CategoryDeleteTB);
            this.Controls.Add(this.CategoryAddTB);
            this.Controls.Add(this.CategoryDeleteButton);
            this.Controls.Add(this.CategoryAddButton);
            this.Controls.Add(this.CategoryDeleteLabel);
            this.Controls.Add(this.CategoryAddLabel);
            this.Name = "CategoryAddForm";
            this.Text = "Dodawanie kategorii";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategoryAddLabel;
        private System.Windows.Forms.Button CategoryAddButton;
        private System.Windows.Forms.TextBox CategoryAddTB;
        private System.Windows.Forms.Label CategoryDeleteLabel;
        private System.Windows.Forms.TextBox CategoryDeleteTB;
        private System.Windows.Forms.Button CategoryDeleteButton;
    }
}