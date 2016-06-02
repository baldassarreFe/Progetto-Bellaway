using BeautifulWeight.Menu;
using BeautifulWeight.Model;
using BeautifulWeight.Users;
using BeautifulWeight.Versions;
using BeautifulWeight.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace BeautifulWeight.Presenter
{
    class MenuPresenter : Presenter
    {
        private readonly RadPanel _upperPanel;
        private readonly RadPanel _dietPanel;
        private readonly RadPanel _buttonsPanel;

        public RadPanel DietPanel
        {
            get
            {
                return _dietPanel;
            }
        }

        public RadPanel ButtonsPanel
        {
            get
            {
                return _buttonsPanel;
            }
        }

        public RadPanel UpperPanel
        {
            get
            {
                return _upperPanel;
            }
        }

        public MenuPresenter(RadPanel upperPanel, RadPanel dietPanel, RadPanel buttonsPanel, SingleProfileModel model) : base(model)
        {
            if (dietPanel == null || buttonsPanel == null)
                throw new ArgumentNullException("control");
            _upperPanel = upperPanel;
            _dietPanel = dietPanel;
            _buttonsPanel = buttonsPanel;
            Model.CurrentUserChanged += CurrentUserChangedHandler;
            ButtonsPanel.Controls[0].Controls.OfType<RadButton>().Where(o => o.Name == "_deleteDietButton").Single().Click += DeleteDietClickHandler;
            ButtonsPanel.Controls[0].Controls.OfType<RadButton>().Where(o => o.Name == "_newDietButton").Single().Click += NewDietClickHandler;
        }


        public void CurrentUserChangedHandler(Object sender, EventArgs e)
        {
            if (Model.CurrentUser != null && Model.CurrentUser.Diet!=null)
            {
                PaintDiet(Model.CurrentUser.Diet);
                PaintUpperPanel(Model.CurrentUser.Diet);
                PaintLowerPanel();
            }
            else
            {
                ClearDiet();
            }
        }

        private void PaintLowerPanel()
        {
            if (Model.CurrentUser.Diet == null)
            {
                ButtonsPanel.Controls[0].Controls.OfType<RadButton>().Where(o => o.Name == "_deleteDietButton").Single().Enabled = false;
            }
            if (!(ManagerProvider.getModelManager<VersionManager>()).Allows(Versions.Feature.ADD_USER))
            {
                ButtonsPanel.Controls[0].Controls.OfType<RadButton>().Where(o => o.Name == "_newDietButton").Single().Enabled = false;
            }
        }

        private void PaintUpperPanel(WeeklyMenu diet)
        {
            UpperPanel.Controls.Clear();
            RadLabel radLabel = new RadLabel();
            radLabel.Text = diet.DietCalculator.Description;
            radLabel.Font = new Font("Arial", 22, FontStyle.Bold);
            radLabel.TextAlignment = ContentAlignment.MiddleCenter;
            UpperPanel.Controls.Add(radLabel);
            radLabel.Dock = DockStyle.Fill;
        }

        private void PaintDiet(WeeklyMenu diet)
        {
            ((System.ComponentModel.ISupportInitialize)DietPanel).BeginInit();
            DietPanel.SuspendLayout();
            DietPanel.Controls.Clear();

            RadListView dailyMenusListView = new DailyMenusListView();
            dailyMenusListView.DataSource = diet.DailyMenus;
            DietPanel.Controls.Add(dailyMenusListView);

            ((System.ComponentModel.ISupportInitialize)DietPanel).EndInit();
            DietPanel.ResumeLayout(true);
        }
        
        private void ClearDiet()
        {
            DietPanel.Controls.Clear();
        }


        private void NewDietClickHandler(object sender, EventArgs e)
        {
            DeleteDietClickHandler(this, EventArgs.Empty);
        }

        private void DeleteDietClickHandler(object sender, EventArgs e)
        { 
        }
    }
}
