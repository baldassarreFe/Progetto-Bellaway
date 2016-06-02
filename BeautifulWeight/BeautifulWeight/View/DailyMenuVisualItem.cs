using BeautifulWeight.Users;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace BeautifulWeight.View
{
    class DailyMenuVisualItem : IconListViewVisualItem
    {
        MealsListView _mealsListView;

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            _mealsListView = new MealsListView();
            // this.Children.Add(_mealsListView);
        }

        protected override void SynchronizeProperties()
        {
            base.SynchronizeProperties();
            this.Padding = new Padding(5);
            Image img = Image.FromFile("../../Resources/user.png");
            img = img.GetThumbnailImage(80, 80, null, IntPtr.Zero);
            this.Image = img;
            this.Text = "<html>      " + ((PersonalDetails)Data["Details"]).Name +
                "<br/><br/>      " + ((PersonalDetails)Data["Details"]).Surname + "</html>";
            this.DrawFill = true;
            this.BackColor = Color.Aqua;
            this.GradientStyle = GradientStyles.Solid;
            this.BorderColor = Color.Aqua;
            this.BorderGradientStyle = GradientStyles.Solid;
            this.DrawBorder = true;
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(SimpleListViewVisualItem);
            }
        }
    }
}
