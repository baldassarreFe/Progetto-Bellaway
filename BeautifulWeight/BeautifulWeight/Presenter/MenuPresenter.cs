using BeautifulWeight.Menu;
using BeautifulWeight.Model;
using BeautifulWeight.Users;
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

        public MenuPresenter(RadPanel dietPanel, RadPanel buttonsPanel, SingleProfileModel model) : base(model)
        {
            if (dietPanel == null || buttonsPanel == null)
                throw new ArgumentNullException("control");
            _dietPanel = dietPanel;
            _buttonsPanel = buttonsPanel;
            Model.CurrentUserChanged += CurrentUserChangedHandler;
        }


        public void CurrentUserChangedHandler(Object sender, EventArgs e)
        {
            if (Model.CurrentUser != null && Model.CurrentUser.Diet!=null)
            {
                PaintDiet(Model.CurrentUser.Diet);
            }
            else
            {
                ClearDiet();
            }
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
            DietPanel.ResumeLayout(false);

            TableLayoutPanel buttonPanel = new TableLayoutPanel();
            buttonPanel.RowCount = 1;
            buttonPanel.ColumnCount = 2;
            RadButton modifica = new RadButton();
            modifica.Text = "Modifica";
            modifica.Click += ModifyClickHandler;
            RadButton elimina = new RadButton();
            elimina.Text = "Elimina";
            elimina.Click += DeleteClickHandler;

            modifica.Dock = DockStyle.Fill;
            elimina.Dock = DockStyle.Fill;
            buttonPanel.Controls.Add(modifica, 0, 0);
            buttonPanel.Controls.Add(elimina, 1, 0);
            buttonPanel.Dock = DockStyle.Fill;

            for (int j = 0; j < buttonPanel.ColumnCount; j++)
            {
                buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            }
            ButtonsPanel.Controls.Clear();
            ButtonsPanel.Controls.Add(buttonPanel);
        }

        private void ResetBackColorHandler(object sender, EventArgs e)
        {
            RadButton salva = ButtonsPanel.Controls[0].Controls.OfType<RadButton>().Where(o => o.Text == "Salva").Single();
            ((Control)sender).BackColor = Color.White;
        }

        private void FieldChangedHandler(object sender, EventArgs e)
        {
            RadButton salva = ButtonsPanel.Controls[0].Controls.OfType<RadButton>().First(b => b.Text == "Salva");
            Control field = (Control)sender;
            salva.Enabled = true;
            PropertyInfo pi = (PropertyInfo)field.Tag;
            object o;
            if (field.GetType() == typeof(GroupBox))
                o = System.Enum.Parse(pi.PropertyType, field.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked).Text);

            else if (field.GetType() == typeof(RadRating))
                o = (int)((RadRating)field).Value;

            else
                o = Convert.ChangeType(field.Text, pi.PropertyType);
            try
            {
                pi.SetValue(Model.CurrentUser.Details, o);
            }
            catch (Exception)
            {
                salva.Enabled = false;
                field.BackColor = Color.Red;
            }
        }

        private void DeleteClickHandler(object sender, EventArgs e)
        {
            Model.DeleteUser();
        }


        private void ClearDiet()
        {
            DietPanel.Controls.Clear();
            DietPanel.Controls.Clear();
        }

        private void ModifyClickHandler(Object sender, EventArgs e)
        {
            TableLayoutPanel detailsPanel = (TableLayoutPanel)DietPanel.Controls[0];
            for (int i = 0; i < detailsPanel.RowCount; i++)
            {
                Control control = detailsPanel.GetControlFromPosition(1, i);
                if (control.GetType() == typeof(RadRating))
                {
                    ((RadRating)control).ReadOnly = false;
                }
                else if (control.GetType() == typeof(GroupBox))
                {
                    (control.Controls.OfType<RadioButton>()).ToList<RadioButton>().ForEach(o => o.Enabled = true);
                }
                else
                {
                    control.Enabled = true;
                }

            }

            TableLayoutPanel buttonPanel = new TableLayoutPanel();
            buttonPanel.RowCount = 1;
            buttonPanel.ColumnCount = 2;
            RadButton salva = new RadButton();
            salva.Text = "Salva";
            salva.Click += SaveClickHandler;
            RadButton annulla = new RadButton();
            annulla.Text = "Annulla";
            annulla.Click += CancelClickHandler;

            salva.Dock = DockStyle.Fill;
            annulla.Dock = DockStyle.Fill;
            buttonPanel.Controls.Add(salva, 0, 0);
            buttonPanel.Controls.Add(annulla, 1, 0);
            buttonPanel.Dock = DockStyle.Fill;

            for (int j = 0; j < buttonPanel.ColumnCount; j++)
            {
                buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            }
            ButtonsPanel.Controls.Clear();
            ButtonsPanel.Controls.Add(buttonPanel);

            Model.StartModify();
        }

        private void SaveClickHandler(object sender, EventArgs e)
        {
            Model.StopModify(true);
        }

        private void CancelClickHandler(object sender, EventArgs e)
        {
            Model.StopModify(false);
        }
    }
}
