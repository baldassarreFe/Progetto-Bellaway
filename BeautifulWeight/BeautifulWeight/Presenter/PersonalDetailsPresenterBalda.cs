using BeautifulWeight.DietCalculators;
using BeautifulWeight.Kitchen;
using BeautifulWeight.Model;
using BeautifulWeight.Users;
using BeautifulWeight.Versions;
using BeautifulWeight.View;
using System;
using System.Collections;
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
    class PersonalDetailsPresenterBalda : Presenter
    {
        private readonly TableLayoutPanel _panel;
        private readonly RadPanel _menuPanel;
        private readonly RadLabel _targetWeightLabel;

        public TableLayoutPanel ProfilePanel
        {
            get
            {
                return _panel;
            }
        }

        public RadPanel MenuPanel
        {
            get
            {
                return _menuPanel;
            }
        }

        public RadLabel TargetWeightLabel
        {
            get
            {
                return _targetWeightLabel;
            }

        }

        public PersonalDetailsPresenterBalda(TableLayoutPanel profilePanel, RadPanel profileMenuPanel, RadLabel targetWeightLabel, SingleProfileModel model) : base(model)
        {
            if (profilePanel == null || profileMenuPanel == null)
                throw new ArgumentNullException("control");
            _panel = profilePanel;
            _menuPanel = profileMenuPanel;
            _targetWeightLabel = targetWeightLabel;
            Model.CurrentUserChanged += CurrentUserChangedHandler;
        }


        public void CurrentUserChangedHandler(Object sender, EventArgs e)
        {
            UserProfile current = Model.CurrentUser;
            if (current == null)
            {
                ClearUser();
            }
            else
            {
                PaintUser(current);
            }
        }

        private void PaintUser(UserProfile up)
        {
            PersonalDetails personalDetails = up.Details;
            ProfilePanel.Controls.Clear();

            ProfilePanel.CreatePropertyRows(up);
            ProfilePanel.BindPropertyRows(up);

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
            buttonPanel.Controls.Add(modifica);
            buttonPanel.Controls.Add(elimina);
            buttonPanel.Dock = DockStyle.Fill;

            MenuPanel.Controls.Clear();
            MenuPanel.Controls.Add(buttonPanel);

            RecalculateTargetWeight();
        }


        private void FieldChangedHandler(Control control)
        {
            RadButton salva = MenuPanel.Controls[0].Controls.OfType<RadButton>().First(b => b.Text == "Salva");
            salva.Enabled = true;
            PropertyInfo pi = (PropertyInfo)control.Tag;
            object o;
            if (control.GetType() == typeof(GroupBox))
                o = System.Enum.Parse(pi.PropertyType, control.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked).Text);

            else if (control.GetType() == typeof(RadRating))
                o = (int)((RadRating)control).Value;

            else
                o = Convert.ChangeType(control.Text, pi.PropertyType);
            try
            {
                if (typeof(PersonalDetails).GetProperties().Contains(pi))
                {
                    pi.SetValue(Model.CurrentUser.Details, o);
                    RecalculateTargetWeight();
                }
                else
                    pi.SetValue(Model.CurrentUser, o);
            }
            catch (Exception)
            {
                salva.Enabled = false;
                control.BackColor = Color.Orange;
            }
        }

        private void DeleteClickHandler(object sender, EventArgs e)
        {
            Model.DeleteUser();
        }

        private void RecalculateTargetWeight()
        {
            try { 
                TargetWeightLabel.Text = "Il tuo peso forma è: " + ManagerProvider.getManager<TargetWeightFormulaManager>().Formula.Calculate(Model.CurrentUser.Details);
            } catch (Exception)
            {
                //ignore
            }
        }

        private void ClearUser()
        {
            ProfilePanel.Controls.Clear();
            TargetWeightLabel.Text = "";
        }

        private void ModifyClickHandler(Object sender, EventArgs e)
        {
            ProfilePanel.EnablePropertyRows();

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
            MenuPanel.Controls.Clear();
            MenuPanel.Controls.Add(buttonPanel);

            Model.StartModify();
        }

        private void ModificaPreferenzeClickHandler(object sender, EventArgs e)
        {
            PreferencesDialog dialog = new PreferencesDialog();
            dialog.PreferencesList.DataSource = ManagerProvider.getManager<KitchenManager>().Ingredients;
            dialog.PreferencesList.AllowColumnReorder = true;
            dialog.PreferencesList.FullRowSelect = false;

            foreach (Ingredient i in Model.CurrentUser.Preferences)
            {
                dialog.PreferencesList.Items.Where(el => el.DataBoundItem == i).Single().CheckState = Telerik.WinControls.Enumerations.ToggleState.On;
            }
            dialog.PreferencesList.SelectedItem = null;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                List<Ingredient> newPrefs = new List<Ingredient>();
                foreach (ListViewDataItem element in dialog.PreferencesList.CheckedItems)
                {
                    Ingredient i = (Ingredient)element.DataBoundItem;
                    newPrefs.Add(i);
                }
                Model.CurrentUser.Preferences = newPrefs;
            }
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
