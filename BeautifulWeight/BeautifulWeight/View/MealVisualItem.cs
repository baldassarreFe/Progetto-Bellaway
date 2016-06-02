using BeautifulWeight.Menu;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace BeautifulWeight.Presenter
{
    internal class MealVisualItem : SimpleListViewVisualItem
    {
        private LightVisualElement _descrLabel;
        private RadListView _servingsListView;

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            _descrLabel = new LightVisualElement();
            _servingsListView = new RadListView();
            this.Container.Add(_descrLabel);
            this.Container.Add(_servingsListView);
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
            DateTime time = (DateTime) Data["Time"];
            this._descrLabel.Text = "<html>" + Data["Name"] +" "+ time.Hour+":"+time.Minute + "</html>";
            this._servingsListView.DisplayMember = "Dish";
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