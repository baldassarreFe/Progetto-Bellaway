namespace BeautifulWeight.View
{
    partial class MenuDayStrip
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
            this.DayZone = new System.Windows.Forms.Panel();
            this.MealZone = new System.Windows.Forms.Panel();
            this._dayLabel = new System.Windows.Forms.Label();
            this.TableDetails.SuspendLayout();
            this.DayZone.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableDetails
            // 
            this.TableDetails.ColumnCount = 1;
            this.TableDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableDetails.Controls.Add(this.DayZone, 0, 0);
            this.TableDetails.Controls.Add(this.MealZone, 0, 1);
            this.TableDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableDetails.Location = new System.Drawing.Point(0, 0);
            this.TableDetails.Name = "TableDetails";
            this.TableDetails.RowCount = 2;
            this.TableDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TableDetails.Size = new System.Drawing.Size(644, 328);
            this.TableDetails.TabIndex = 0;
            // 
            // DayZone
            // 
            this.DayZone.Controls.Add(this._dayLabel);
            this.DayZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DayZone.Location = new System.Drawing.Point(3, 3);
            this.DayZone.Name = "DayZone";
            this.DayZone.Size = new System.Drawing.Size(638, 59);
            this.DayZone.TabIndex = 0;
            // 
            // MealZone
            // 
            this.MealZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MealZone.Location = new System.Drawing.Point(3, 68);
            this.MealZone.Name = "MealZone";
            this.MealZone.Size = new System.Drawing.Size(638, 257);
            this.MealZone.TabIndex = 1;
            // 
            // _dayLabel
            // 
            this._dayLabel.AutoSize = true;
            this._dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dayLabel.Location = new System.Drawing.Point(267, 15);
            this._dayLabel.Name = "_dayLabel";
            this._dayLabel.Size = new System.Drawing.Size(92, 29);
            this._dayLabel.TabIndex = 0;
            this._dayLabel.Text = "Giorno";
            // 
            // MenuDayStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.TableDetails);
            this.Name = "MenuDayStrip";
            this.Size = new System.Drawing.Size(644, 328);
            this.TableDetails.ResumeLayout(false);
            this.DayZone.ResumeLayout(false);
            this.DayZone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableDetails;
        private System.Windows.Forms.Panel DayZone;
        private System.Windows.Forms.Panel MealZone;
        private System.Windows.Forms.Label _dayLabel;
    }
}
