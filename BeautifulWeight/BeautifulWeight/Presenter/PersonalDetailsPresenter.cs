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
    class PersonalDetailsPresenter
    {
        private BeautifulUI _form;
        private BeautifulPresenter _bpresenter;

        public UserProfileManager UserProfileManager
        {
            get
            {
                return UserProfileManager.GetInstance();
            }
        }

        public PersonalDetailsPresenter(BeautifulUI ui, BeautifulPresenter pres)
        {
            if (ui == null)
                throw new ArgumentNullException("control");
            _form = ui;
            _bpresenter = pres;
            _bpresenter.UserChanged += UserChangedHandler;
            _bpresenter.UserRemoved += UserRemovedHandler;
        }


        public void UserChangedHandler(Object sender, EventArgs e)
        {
            paintUser(_bpresenter.CurrentUser.Details);
        }

        private void paintUser(PersonalDetails personalDetails)
        {
            _form.ProfilePanel.Controls.Clear();
            TableLayoutPanel detailsPanel = new TableLayoutPanel();
            detailsPanel.RowCount = personalDetails.GetType().GetProperties().Length;
            detailsPanel.ColumnCount = 2;
            detailsPanel.Dock = DockStyle.Fill;


            int i = 0;
            foreach (PropertyInfo pi in personalDetails.GetType().GetProperties())
            {
                Label name = new Label();
                name.Text = pi.Name;
                name.Dock = DockStyle.Fill;
                name.TextAlign = ContentAlignment.MiddleCenter;
                name.BorderStyle = BorderStyle.Fixed3D;
                detailsPanel.Controls.Add(name, 0, i);

                if (pi.PropertyType == typeof(Load))
                {
                    RadRating value = new RadRating();
                    value.Items.AddRange(new Telerik.WinControls.RadItem[] { new RatingHeartVisualElement(),
            new RatingHeartVisualElement(),
            new RatingHeartVisualElement(),
            new RatingHeartVisualElement(),
            new RatingHeartVisualElement()});

                    value.SelectionMode = RatingSelectionMode.FullItem;
                    value.Minimum = 0;
                    value.Maximum = 5;
                    value.Value = (int)pi.GetValue(personalDetails);
                    value.AutoSize = true;
                    value.ReadOnly = true;
                    value.Dock = DockStyle.Fill;
                    value.Anchor = AnchorStyles.None;
                    detailsPanel.Controls.Add(value, 1, i++);
                }

                else {
                    TextBox value = new TextBox();
                    value.Text = "" + pi.GetValue(personalDetails);
                    value.Dock = DockStyle.Fill;
                    value.TextAlign = HorizontalAlignment.Center;
                    value.Enabled = false;
                    value.BorderStyle = BorderStyle.Fixed3D;
                    detailsPanel.Controls.Add(value, 1, i++);
                }
            }

            float percent = 100F / detailsPanel.RowCount;
            for (int j = 0; j < detailsPanel.RowCount; j++) {
                detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, percent));
            }

            for (int j = 0; j < detailsPanel.ColumnCount; j++)
            {
                detailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            }

            _form.ProfilePanel.Controls.Add(detailsPanel);

            TableLayoutPanel buttonPanel = new TableLayoutPanel();
            buttonPanel.RowCount = 1;
            buttonPanel.ColumnCount = 2;
            RadButton modifica = new RadButton();
            modifica.Text = "Modifica";
            modifica.Click += ModifierHandler;
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
            _form.ProfileMenuPanel.Controls.Add(buttonPanel);
        }

        private void DeleteClickHandler(object sender, EventArgs e)
        {
            _bpresenter.CurrentUser = null;
        }

        private void UserRemovedHandler(object sender, EventArgs e)
        {
            _form.ProfileMenuPanel.Controls.Clear();
            _form.ProfilePanel.Controls.Clear();
        }

        private void ModifierHandler(Object sender, EventArgs e)
        {
            TableLayoutPanel detailsPanel = (TableLayoutPanel)_form.ProfilePanel.Controls[0];
            for (int i=0; i<detailsPanel.RowCount; i++)
            {
                Control control = detailsPanel.GetControlFromPosition(1, i);
                if (control.GetType() == typeof(Load))
                {
                }
                else
                {
                    control.Enabled = true;
                }
               
            }
        }
    }
}
