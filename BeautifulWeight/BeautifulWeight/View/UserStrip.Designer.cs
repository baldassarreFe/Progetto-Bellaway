using System.Windows.Forms;

namespace BeautifulWeight.View
{
    partial class UserStrip
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
            this._profileDetails = new System.Windows.Forms.Panel();
            this._cognomeLabel = new System.Windows.Forms.Label();
            this._nomeLabel = new System.Windows.Forms.Label();
            this._profileImg = new System.Windows.Forms.Panel();
            this.TableDetails.SuspendLayout();
            this._profileDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableDetails
            // 
            this.TableDetails.ColumnCount = 2;
            this.TableDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableDetails.Controls.Add(this._profileDetails, 1, 0);
            this.TableDetails.Controls.Add(this._profileImg, 0, 0);
            this.TableDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableDetails.Location = new System.Drawing.Point(0, 0);
            this.TableDetails.Name = "TableDetails";
            this.TableDetails.RowCount = 1;
            this.TableDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableDetails.Size = new System.Drawing.Size(353, 102);
            this.TableDetails.TabIndex = 0;
            // 
            // ProfileDetails
            // 
            this._profileDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._profileDetails.AutoSize = true;
            this._profileDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._profileDetails.Controls.Add(this._cognomeLabel);
            this._profileDetails.Controls.Add(this._nomeLabel);
            this._profileDetails.Location = new System.Drawing.Point(108, 3);
            this._profileDetails.Name = "ProfileDetails";
            this._profileDetails.Size = new System.Drawing.Size(242, 96);
            this._profileDetails.TabIndex = 0;
            // 
            // _cognomeLabel
            // 
            this._cognomeLabel.AutoSize = true;
            this._cognomeLabel.Location = new System.Drawing.Point(4, 37);
            this._cognomeLabel.Name = "_cognomeLabel";
            this._cognomeLabel.Size = new System.Drawing.Size(52, 13);
            this._cognomeLabel.TabIndex = 1;
            this._cognomeLabel.Text = "Cognome";
            // 
            // _nomeLabel
            // 
            this._nomeLabel.AutoSize = true;
            this._nomeLabel.Location = new System.Drawing.Point(4, 4);
            this._nomeLabel.Name = "_nomeLabel";
            this._nomeLabel.Size = new System.Drawing.Size(35, 13);
            this._nomeLabel.TabIndex = 0;
            this._nomeLabel.Text = "Nome";
            // 
            // ProfileImg
            // 
            this._profileImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._profileImg.AutoSize = true;
            this._profileImg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._profileImg.BackgroundImage = global::BeautifulWeight.Properties.Resources.user;
            this._profileImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._profileImg.Location = new System.Drawing.Point(3, 3);
            this._profileImg.Name = "ProfileImg";
            this._profileImg.Size = new System.Drawing.Size(99, 96);
            this._profileImg.TabIndex = 1;
            // 
            // UserStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.TableDetails);
            this.Name = "UserStrip";
            this.Size = new System.Drawing.Size(353, 102);
            this.TableDetails.ResumeLayout(false);
            this.TableDetails.PerformLayout();
            this._profileDetails.ResumeLayout(false);
            this._profileDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableDetails;
        private System.Windows.Forms.Panel _profileDetails;
        private System.Windows.Forms.Label _cognomeLabel;
        private System.Windows.Forms.Label _nomeLabel;
        private System.Windows.Forms.Panel _profileImg;
    }
}
