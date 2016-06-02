using BeautifulWeight.Kitchen;
using BeautifulWeight.Menu;
using System;
using System.Drawing;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace BeautifulWeight.Presenter
{
    internal class ServingsListView : RadListView
    {
        public ServingsListView()
        {
            this.FullRowSelect = false;
            //this.ItemSize = new Size(200, 20);
            this.ViewType = ListViewType.ListView;
            this.HotTracking = false;
            this.SelectLastAddedItem = false;
            this.ShowItemToolTips = true;
            this.VisualItemCreating += ServingsListView_VisualItemCreating;
        }

        private void ServingsListView_VisualItemCreating(object sender, ListViewVisualItemCreatingEventArgs e)
        {
            e.VisualItem = new ServingVisualItem();
        }
    }

    internal class ServingVisualItem : SimpleListViewVisualItem
    {
        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            this.DrawFill = true;
            this.BackColor = Color.Aqua;
            this.GradientStyle = GradientStyles.Solid;
            this.BorderColor = Color.Aqua;
            this.BorderGradientStyle = GradientStyles.Solid;
            this.DrawBorder = true;
        }

        protected override void SynchronizeProperties()
        {
            //base.SynchronizeProperties();
            Serving serving = (Serving)Data.DataBoundItem;
            Dish dish = serving.Dish;
            string name = dish.Name;
            int quantity = serving.Quantity;
            this.ToolTipText = string.Format("Carbo: {0}\nProteine: {1}\nGrassi: {2}\nKcal: {3}\n", dish.Carbohydrates, dish.Proteins, dish.Fats, dish.Calories);
            this.Text = "<html>" + name + " (" + quantity + "g)</html>";
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