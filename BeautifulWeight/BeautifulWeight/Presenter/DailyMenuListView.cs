using BeautifulWeight.Menu;
using BeautifulWeight.View;
using System.Collections.Generic;
using Telerik.WinControls.UI;

namespace BeautifulWeight.Presenter
{
    internal class DailyMenusListView : RadListView
    {
        public DailyMenusListView()
        {
            this.AllowColumnReorder = false;
            this.AllowColumnResize = false;
            this.AllowEdit = false;
            this.AllowRemove = false;
            this.AutoScroll = true;
            //this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullRowSelect = false;
            this.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AutoHide;
            this.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.ItemSize = new System.Drawing.Size(80, 120);
            //this.Location = new System.Drawing.Point(0, 0);
            //this.Name = "_usersListView";
            this.ShowColumnHeaders = false;
            //this.Size = new System.Drawing.Size(116, 415);
            //this.TabIndex = 1;
            //this.Text = "_usersListView";
            this.VisualItemCreating += DailyMenuListView_VisualItemCreating;
            this.VisualItemFormatting += DailyMenuListView_VisualItemFormatting;
            this.CurrentItemChanged += DailyMenuListView_CurrentItemChanged;

            this.DataMember = "Meals"; // ????
        }

        private void DailyMenuListView_CurrentItemChanged(object sender, ListViewItemEventArgs e)
        {
            DailyMenu dm = (DailyMenu) e.Item.DataBoundItem;
        }

        private void DailyMenuListView_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            
        }

        private void DailyMenuListView_VisualItemCreating(object sender, ListViewVisualItemCreatingEventArgs e)
        {
            e.VisualItem = new DailyMenuVisualItem();
        }
    }
}