using BeautifulWeight.DietCalculators;
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
            if (Model.CurrentUser != null && Model.CurrentUser.Diet != null)
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
            if (Model.CurrentUser != null)
            {
                bool flag = (Model.CurrentUser.Diet != null);
                ButtonsPanel.Controls[0].Controls.OfType<RadButton>().Where(o => o.Name == "_deleteDietButton").Single().Enabled = flag;
                ButtonsPanel.Controls[0].Controls.OfType<RadButton>().Where(o => o.Name == "_newDietButton").Single().Enabled = true;
            }
        }

        private void PaintUpperPanel(WeeklyMenu diet)
        {
            UpperPanel.Controls.Clear();
            RadLabel radLabel = new RadLabel();
            radLabel.Text = diet.DietCalculator.Description;
            radLabel.Font = new Font("Arial", 18, FontStyle.Bold);
            radLabel.TextAlignment = ContentAlignment.MiddleCenter;
            radLabel.Dock = DockStyle.Fill;
            radLabel.BackColor = Color.Transparent;
            UpperPanel.Controls.Add(radLabel);
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
            UpperPanel.Controls.Clear();
            PaintLowerPanel();
        }


        private void NewDietClickHandler(object sender, EventArgs e)
        {
            DeleteDietClickHandler(this, EventArgs.Empty);
            ComboBox dietcalculators = new ComboBox();
            dietcalculators.DataSource = DietCalculatorLoader.LoadedDietCalculators.ToList();
            dietcalculators.Size = new Size(320, 100);
            dietcalculators.DisplayMember = "Description";
            dietcalculators.Dock = DockStyle.Left;

            RadButton confirm = new RadButton();
            confirm.Click += ConfirmNewDietClick;
            confirm.Tag = dietcalculators;
            confirm.Text = "Conferma";
            confirm.Size = new Size(150, 100);
            confirm.Dock = DockStyle.Right;

            UpperPanel.Controls.Clear();
            UpperPanel.Controls.Add(dietcalculators);
            UpperPanel.Controls.Add(confirm);
        }

        private void ConfirmNewDietClick(object sender, EventArgs e)
        {
            ComboBox dietcalculators = (ComboBox)((RadButton)sender).Tag;
            Model.CurrentUser.Diet = ((DietCalculator)dietcalculators.SelectedItem).NewMenu();
            PaintDiet(Model.CurrentUser.Diet);
            PaintUpperPanel(Model.CurrentUser.Diet);
            PaintLowerPanel();
            Random r = new Random();
            if (r.Next(10) == 8)
                MessageBox.Show("Complimenti! Hai vinto un viaggio a Ibiza! Contattaci per ritirare il tuo premio.");
        }

        private void DeleteDietClickHandler(object sender, EventArgs e)
        {
            Model.CurrentUser.Diet = null;
            ClearDiet();
        }
    }
}
