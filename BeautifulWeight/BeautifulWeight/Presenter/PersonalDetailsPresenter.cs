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
    class PersonalDetailsPresenter : Presenter
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

        public PersonalDetailsPresenter(TableLayoutPanel profilePanel, RadPanel profileMenuPanel, RadLabel targetWeightLabel, SingleProfileModel model) : base(model)
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
                if (string.IsNullOrEmpty(current.Details.Name))
                {
                    ModifyClickHandler(null, null);
                }
            }
        }

        private void PaintUser(UserProfile up)
        {
            PersonalDetails personalDetails = up.Details;
            ClearUser();


            Label name = null;
            foreach (PropertyInfo pi in personalDetails.GetType().GetProperties())
            {
                name = new Label();
                name.Text = pi.Name;
                name.Dock = DockStyle.Fill;
                name.TextAlign = ContentAlignment.MiddleCenter;
                name.BorderStyle = BorderStyle.Fixed3D;
                ProfilePanel.Controls.Add(name);

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
                    value.Tag = pi;
                    value.LostFocus += FormChangedHandler;
                    ProfilePanel.Controls.Add(value);
                }

                else if (pi.PropertyType == typeof(DateTime))
                {
                    DateTimePicker value = new DateTimePicker();
                    value.Value = (DateTime)pi.GetValue(personalDetails);
                    value.Enabled = false;
                    value.Format = DateTimePickerFormat.Short;
                    value.Dock = DockStyle.Fill;
                    value.DropDownAlign = LeftRightAlignment.Right;
                    value.Tag = pi;
                    value.Leave += FormChangedHandler;
                    ProfilePanel.Controls.Add(value);
                }

                else if (pi.PropertyType == typeof(int))
                {
                    NumericUpDown value = new NumericUpDown();
                    value.Minimum = 0;
                    value.Maximum = 1000;
                    value.Value = (int)pi.GetValue(personalDetails);
                    value.Enabled = false;
                    value.Dock = DockStyle.Fill;
                    value.TextAlign = HorizontalAlignment.Center;
                    value.Tag = pi;
                    value.Leave += FormChangedHandler;
                    ProfilePanel.Controls.Add(value);
                }

                else if (pi.PropertyType.IsEnum)
                {
                    GroupBox value = new GroupBox();
                    int y = 0;
                    foreach (object o in Enum.GetValues(pi.PropertyType))
                    {
                        RadioButton r = new RadioButton();
                        r.Text = o.ToString();
                        if (o.Equals(pi.GetValue(personalDetails)))
                            r.Checked = true;
                        r.Enabled = false;
                        r.Location = new Point(0, y);
                        y += r.Size.Height;
                        value.Tag = pi;
                        value.Leave += FormChangedHandler;
                        value.Controls.Add(r);
                    }
                    value.Dock = DockStyle.Fill;
                    value.AutoSize = true;
                    ProfilePanel.Controls.Add(value);
                }

                else {
                    TextBox value = new TextBox();
                    value.Text = "" + pi.GetValue(personalDetails);
                    value.Dock = DockStyle.Fill;
                    value.TextAlign = HorizontalAlignment.Center;
                    value.Enabled = false;
                    value.BorderStyle = BorderStyle.Fixed3D;
                    value.Tag = pi;
                    value.Leave += FormChangedHandler;
                    ProfilePanel.Controls.Add(value);
                }
                ProfilePanel.RowCount++;
            }


            Label goalLabel = new Label();
            goalLabel.Text = "Goal";
            goalLabel.Dock = DockStyle.Fill;
            goalLabel.TextAlign = ContentAlignment.MiddleCenter;
            goalLabel.BorderStyle = BorderStyle.Fixed3D;
            ProfilePanel.Controls.Add(goalLabel);

            GroupBox goal = new GroupBox();
            int k = 0;
            foreach (object o in Enum.GetValues(typeof(Goal)))
            {
                RadioButton r = new RadioButton();
                r.Text = o.ToString();
                if (o.Equals(up.Goal))
                    r.Checked = true;
                r.Enabled = false;
                r.Location = new Point(0, k);
                k += r.Size.Height;
                goal.Tag = typeof(Goal);
                goal.Leave += FormChangedHandler;
                goal.Controls.Add(r);
            }
            goal.Dock = DockStyle.Fill;
            goal.Tag = up.GetType().GetProperty("Goal");
            ProfilePanel.Controls.Add(goal);
            ProfilePanel.RowCount++;

            Label prefLabel = new Label();
            prefLabel.Text = "Preferences";
            prefLabel.Dock = DockStyle.Fill;
            prefLabel.TextAlign = ContentAlignment.MiddleCenter;
            prefLabel.BorderStyle = BorderStyle.Fixed3D;
            ProfilePanel.Controls.Add(prefLabel);

            Label preferences = new Label();
            string pref = "";
            if (up.Preferences.Any())
                pref = (from p in up.Preferences select p.Name).Aggregate((x, y) => x + ", " + y);
            preferences.Name = "Preferences";
            preferences.Text = pref;
            preferences.Dock = DockStyle.Fill;
            preferences.TextAlign = ContentAlignment.MiddleCenter;
            preferences.BorderStyle = BorderStyle.Fixed3D;
            preferences.Tag = up.GetType().GetProperty("Preferences");
            ProfilePanel.Controls.Add(preferences);
            ProfilePanel.RowCount++;

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


        private void FormChangedHandler(object sender, EventArgs e)
        {
            RadButton salva = MenuPanel.Controls[0].Controls.OfType<RadButton>().First(b => b.Text == "Salva");
            bool formValid = true;

            foreach (Control control in ProfilePanel.Controls)
            {
                if (!(control is Label))
                {
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
                        {
                            pi.SetValue(Model.CurrentUser, o);
                        }
                        control.BackColor = Color.White;
                    }
                    catch (Exception)
                    {
                        formValid = false;
                        control.BackColor = Color.Orange;
                    }
                }
            }
            salva.Enabled = formValid;
        }

        private void DeleteClickHandler(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Sei sicuro di voler cancellare l'utente?",
                                     "Cancella utente", MessageBoxButtons.YesNo))
                return;
            Model.DeleteUser();
        }

        private void RecalculateTargetWeight()
        {
            try
            {
                TargetWeightLabel.Text = "Il tuo peso forma è: " + ManagerProvider.getManager<TargetWeightFormulaManager>().Formula.Calculate(Model.CurrentUser.Details);
            }
            catch (Exception)
            {
                //ignore
            }
        }

        private void ClearUser()
        {
            ProfilePanel.Controls.Clear();
            ProfilePanel.RowCount = 0;
        }

        private void ModifyClickHandler(Object sender, EventArgs e)
        {
            for (int i = 0; i < ProfilePanel.RowCount; i++)
            {
                Control control = ProfilePanel.GetControlFromPosition(1, i);
                if (control.GetType() == typeof(RadRating))
                {
                    ((RadRating)control).ReadOnly = false;
                }
                else if (control.GetType() == typeof(GroupBox))
                {
                    if (((PropertyInfo)control.Tag).PropertyType == typeof(Goal))
                    {
                        if (ManagerProvider.getManager<VersionManager>().Allows(Feature.CHANGE_GOAL))
                            (control.Controls.OfType<RadioButton>()).ToList<RadioButton>().ForEach(o => o.Enabled = true);
                    }
                    else
                    {
                        (control.Controls.OfType<RadioButton>()).ToList<RadioButton>().ForEach(o => o.Enabled = true);
                    }
                }
                else if (control.Tag is PropertyInfo && ((PropertyInfo)control.Tag).PropertyType.GetInterfaces().Contains(typeof(IList)) && ((PropertyInfo)control.Tag).PropertyType.IsGenericType)
                {
                    if (ManagerProvider.getManager<VersionManager>().Allows(Feature.CHANGE_PREFERENCES))
                    {
                        control.Click += ModificaPreferenzeClickHandler;
                        control.BackColor = Color.White;
                    }
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
            salva.Enabled = false;
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

            FormChangedHandler(null, null);
            Model.StartModify();
        }

        private void ModificaPreferenzeClickHandler(object sender, EventArgs e)
        {
            PreferencesDialog dialog = new PreferencesDialog();
            dialog.PreferencesList.DataSource = ManagerProvider.getManager<KitchenManager>().Ingredients;
            dialog.PreferencesList.AllowColumnReorder = false;
            dialog.PreferencesList.AllowDragDrop = false;
            dialog.PreferencesList.AllowDrop = false;
            dialog.PreferencesList.FullRowSelect = false;
            dialog.PreferencesList.AllowEdit = false;
            dialog.PreferencesList.AllowRemove = false;
            dialog.PreferencesList.CheckOnClickMode = CheckOnClickMode.FirstClick;
            dialog.PreferencesList.HotTracking = true;


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
                string pref = "";
                if (newPrefs.Any())
                    pref = (from p in newPrefs select p.Name).Aggregate((x, y) => x + ", " + y);
                ProfilePanel.Controls.OfType<Label>().First(c => c.Name == "Preferences").Text = pref;
            }
        }

        private void SaveClickHandler(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Sei sicuro di voler salvare le modifiche?",
                                     "Conferma modifica", MessageBoxButtons.YesNo))
                return;
            Model.StopModify(true);
        }

        private void CancelClickHandler(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Sei sicuro di voler annullare la modifica?",
                                     "Annulla modifica", MessageBoxButtons.YesNo))
                return;
            Model.StopModify(false);
        }
    }
}
