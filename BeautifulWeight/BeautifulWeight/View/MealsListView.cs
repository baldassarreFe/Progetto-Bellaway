using BeautifulWeight.Presenter;
using Telerik.WinControls.UI;

namespace BeautifulWeight.View
{
    internal class MealsListView : RadListView
    {
        public MealsListView()
        {
            this.AllowColumnReorder = false;
            this.AllowColumnResize = false;
            this.AllowEdit = false;
            this.AllowRemove = false;
            this.AutoScroll = true;
            this.FullRowSelect = false;
            this.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AutoHide;
            this.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.ItemSize = new System.Drawing.Size(300,100);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowColumnHeaders = false;
            this.VisualItemCreating += MealsListView_VisualItemCreating;
            this.VisualItemFormatting += MealsListView_VisualItemFormatting;
            this.CurrentItemChanged += MealsListView_CurrentItemChanged;
            this.ViewType = ListViewType.IconsView;
        }

        private void MealsListView_CurrentItemChanged(object sender, ListViewItemEventArgs e)
        {
        }

        private void MealsListView_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
        }

        private void MealsListView_VisualItemCreating(object sender, ListViewVisualItemCreatingEventArgs e)
        {
            e.VisualItem = new MealVisualItem();
        }
    }
}