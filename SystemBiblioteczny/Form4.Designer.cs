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
            this.SuspendLayout();
            // 
            // CategoryAddLabel
            // 
            this.CategoryAddLabel.AutoSize = true;
            this.CategoryAddLabel.Location = new System.Drawing.Point(36, 71);
            this.CategoryAddLabel.Name = "CategoryAddLabel";
            this.CategoryAddLabel.Size = new System.Drawing.Size(135, 13);
            this.CategoryAddLabel.TabIndex = 0;
            this.CategoryAddLabel.Text = "Dodawanie nowej kategorii";
            // 
            // CategoryAddButton
            // 
            this.CategoryAddButton.Location = new System.Drawing.Point(108, 132);
            this.CategoryAddButton.Name = "CategoryAddButton";
            this.CategoryAddButton.Size = new System.Drawing.Size(173, 83);
            this.CategoryAddButton.TabIndex = 1;
            this.CategoryAddButton.Text = "Dodaj kategorie";
            this.CategoryAddButton.UseVisualStyleBackColor = true;
            // 
            // CategoryAddTB
            // 
            this.CategoryAddTB.Location = new System.Drawing.Point(177, 68);
            this.CategoryAddTB.Name = "CategoryAddTB";
            this.CategoryAddTB.Size = new System.Drawing.Size(185, 20);
            this.CategoryAddTB.TabIndex = 2;
            // 
            // CategoryAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 256);
            this.Controls.Add(this.CategoryAddTB);
            this.Controls.Add(this.CategoryAddButton);
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
    }
}