using Telerik.WinControls.UI;

namespace BeautifulWeight
{
    partial class LoginForm
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
            Telerik.WinControls.UI.CarouselEllipsePath carouselEllipsePath1 = new Telerik.WinControls.UI.CarouselEllipsePath();
            this.radCarousel1 = new Telerik.WinControls.UI.RadCarousel();
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radCarousel1
            // 
            CarouselBezierPath path = new CarouselBezierPath();
            path.CtrlPoint1 = new Telerik.WinControls.UI.Point3D(86, 76, 70);
            path.CtrlPoint2 = new Telerik.WinControls.UI.Point3D(10, 20, 0);
            path.FirstPoint = new Telerik.WinControls.UI.Point3D(14, 77, 70);
            path.LastPoint = new Telerik.WinControls.UI.Point3D(90, 20, 0);
            path.ZScale = 500;
            this.radCarousel1.CarouselPath = path;
            this.radCarousel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radCarousel1.Location = new System.Drawing.Point(0, 0);
            this.radCarousel1.Name = "radCarousel1";
            this.radCarousel1.Size = new System.Drawing.Size(528, 467);
            this.radCarousel1.TabIndex = 0;
            this.radCarousel1.Text = "radCarousel1";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 467);
            this.Controls.Add(this.radCarousel1);
            this.Name = "LoginForm";
            this.Text = "Beautiful Weight";
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCarousel radCarousel1;
    }
}

