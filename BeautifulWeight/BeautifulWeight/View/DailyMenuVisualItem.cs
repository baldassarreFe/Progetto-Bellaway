using BeautifulWeight.Menu;
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
    class DailyMenuVisualItem : SimpleListViewVisualItem
    {
        MealsListView _mealsListView;
        LightVisualElement _dayLabel;

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            StackLayoutPanel stackLayoutPanel = new StackLayoutPanel();
            _mealsListView = new MealsListView();
            _mealsListView.ItemSize = new Size(200, 150);
            _mealsListView.HotTracking = false;
            _dayLabel = new LightVisualElement();
            stackLayoutPanel.Children.Add(_dayLabel);
            stackLayoutPanel.Children.Add(_mealsListView.RootElement);
            this.Children.Add(stackLayoutPanel);
            this.Padding = new Padding(5);
            this.DrawFill = true;
            this.BackColor = Color.Aqua;
            this.GradientStyle = GradientStyles.Solid;
            this.BorderColor = Color.Aqua;
            this.BorderGradientStyle = GradientStyles.Solid;
            this.DrawBorder = true;
        }

        protected override void SynchronizeProperties()
        {
            base.SynchronizeProperties();
            this.Text = "";
            this._mealsListView.DataSource = (IEnumerable<Meal>)Data["Meals"];
            this._dayLabel.Text = ((DayOfWeek) Data["Day"]).ToString();
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
