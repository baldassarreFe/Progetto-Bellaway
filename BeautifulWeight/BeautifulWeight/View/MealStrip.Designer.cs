namespace BeautifulWeight.View
{
    partial class MealStrip
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableDetails = new System.Windows.Forms.TableLayoutPanel();
            this.MealName = new System.Windows.Forms.Panel();
            this.MealDetails = new System.Windows.Forms.Panel();
            this._mealNameLabel = new System.Windows.Forms.Label();
            this.TableDetails.SuspendLayout();
            this.MealName.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableDetails
            // 
            this.TableDetails.ColumnCount = 1;
            this.TableDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableDetails.Controls.Add(this.MealName, 0, 0);
            this.TableDetails.Controls.Add(this.MealDetails, 0, 1);
            this.TableDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableDetails.Location = new System.Drawing.Point(0, 0);
            this.TableDetails.Name = "TableDetails";
            this.TableDetails.RowCount = 2;
            this.TableDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TableDetails.Size = new System.Drawing.Size(148, 219);
            this.TableDetails.TabIndex = 0;
            // 
            // MealName
            // 
            this.MealName.Controls.Add(this._mealNameLabel);
            this.MealName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MealName.Location = new System.Drawing.Point(3, 3);
            this.MealName.Name = "MealName";
            this.MealName.Size = new System.Drawing.Size(142, 37);
            this.MealName.TabIndex = 0;
            // 
            // MealDetails
            // 
            this.MealDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MealDetails.Location = new System.Drawing.Point(3, 46);
            this.MealDetails.Name = "MealDetails";
            this.MealDetails.Size = new System.Drawing.Size(142, 170);
            this.MealDetails.TabIndex = 1;
            // 
            // _mealNameLabel
            // 
            this._mealNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._mealNameLabel.AutoSize = true;
            this._mealNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mealNameLabel.Location = new System.Drawing.Point(53, 11);
            this._mealNameLabel.Name = "_mealNameLabel";
            this._mealNameLabel.Size = new System.Drawing.Size(39, 13);
            this._mealNameLabel.TabIndex = 0;
            this._mealNameLabel.Text = "Pasto";
            // 
            // MealStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.TableDetails);
            this.Name = "MealStrip";
            this.Size = new System.Drawing.Size(148, 219);
            this.TableDetails.ResumeLayout(false);
            this.MealName.ResumeLayout(false);
            this.MealName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableDetails;
        private System.Windows.Forms.Panel MealName;
        private System.Windows.Forms.Label _mealNameLabel;
        private System.Windows.Forms.Panel MealDetails;
    }
}
