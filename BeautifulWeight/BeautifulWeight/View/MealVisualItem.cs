using BeautifulWeight.Menu;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace BeautifulWeight.Presenter
{
    internal class MealVisualItem : IconListViewVisualItem
    {
        private LightVisualElement _descrLabel;
        private RadListView _servingsListView;

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            StackLayoutPanel stackLayoutPanel = new StackLayoutPanel();
            _descrLabel = new LightVisualElement();
            _servingsListView = new ServingsListView();
            

            stackLayoutPanel.Children.Add(_servingsListView.RootElement);
            stackLayoutPanel.Children.Add(_descrLabel);
            stackLayoutPanel.Orientation = Orientation.Vertical;
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
            DateTime time = (DateTime) Data["Time"];
            this._descrLabel.Text = "<html>" + Data["Name"] +" "+ time.Hour+":"+time.Minute + "</html>";
            this._servingsListView.DataSource = (IEnumerable<Serving>)Data["Servings"];
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