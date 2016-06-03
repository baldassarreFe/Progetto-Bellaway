using BeautifulWeight.Kitchen;
using BeautifulWeight.Model;
using BeautifulWeight.Users;
using BeautifulWeight.Versions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BeautifulWeight.View
{
    static class TableLayoutExtension
    {
        public static void CreatePropertyRow(this TableLayoutPanel panel, PropertyInfo pi)
        {
            Control value = PropertyControl.CreateControlFor(pi);
            if (value != null)
            {
                Label description = new DescriptionLabel(pi.Name);
                panel.Controls.Add(description);
                panel.Controls.Add(value);
                panel.RowCount++;
            }
        }
        public static void BindPropertyRows(this TableLayoutPanel panel, UserProfile profile)
        {
            foreach (Control control in panel.Controls)
            {
                if (control.Tag != null && control.Tag is PropertyControl.PropertyAndObject)
                {
                    PropertyControl.PropertyAndObject pao = (PropertyControl.PropertyAndObject)control.Tag;
                    if (pao.PropertyInfo.DeclaringType.IsAssignableFrom(profile.GetType()))
                        pao.Object = profile;
                    else if (pao.PropertyInfo.DeclaringType.IsAssignableFrom(profile.Details.GetType()))
                        pao.Object = profile.Details;
                }
            }
            panel.RefreshPropertyRows();
        }
        public static void RefreshPropertyRows(this TableLayoutPanel panel)
        {
            foreach (Control control in panel.Controls)
                PropertyControl.FillControl(control);
        }
        public static void EnablePropertyRows(this TableLayoutPanel panel)
        {
            foreach (Control control in panel.Controls)
                PropertyControl.SetEnabledStatus(control,true);
        }
        public static void DisablePropertyRows(this TableLayoutPanel panel)
        {
            foreach (Control control in panel.Controls)
                PropertyControl.SetEnabledStatus(control, false);
        }
        public static void CreatePropertyRows(this TableLayoutPanel panel, UserProfile profile)
        {
            foreach (PropertyInfo pi in profile.Details.GetType().GetProperties())
                panel.CreatePropertyRow(pi);
            foreach (PropertyInfo pi in profile.GetType().GetProperties())
                panel.CreatePropertyRow(pi);
        }
    }

    internal class DescriptionLabel : Label
    {
        public DescriptionLabel(string text)
        {
            this.Text = text;
            this.Dock = DockStyle.Fill;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.BorderStyle = BorderStyle.Fixed3D;
        }
    }

    internal delegate void PropertyControLostFocusHandler(Control control);

    internal class PropertyControl
    {
        internal static event PropertyControLostFocusHandler PropertyControLostFocus;

        internal static void FirePropertyControlLostFocus(object sender, EventArgs e)
        {
            if (PropertyControLostFocus != null)
                PropertyControLostFocus((Control) sender);
        }

        internal class PropertyAndObject
        {
            PropertyInfo _propertyInfo;
            object _object;

            public object Object
            {
                get
                {
                    return _object;
                }

                set
                {
                    _object = value;
                }
            }

            public PropertyInfo PropertyInfo
            {
                get
                {
                    return _propertyInfo;
                }

                set
                {
                    _propertyInfo = value;
                }
            }

            public PropertyAndObject(PropertyInfo propertyInfo, object obj)
            {
                PropertyInfo = propertyInfo;
                Object = obj;
            }
        }

        internal static Control CreateControlFor(PropertyInfo pi)
        {
            if (pi.PropertyType == typeof(Load))
            {
                RadRating control = new RadRating();
                for (int i = 0; i < 5; i++)
                    control.Items.Add(new RatingHeartVisualElement());
                control.SelectionMode = RatingSelectionMode.FullItem;
                control.Minimum = 0;
                control.Maximum = 5;
                control.AutoSize = true;
                control.ReadOnly = true;
                control.Dock = DockStyle.Fill;
                control.Anchor = AnchorStyles.None;
                control.Tag = new PropertyAndObject(pi, null);
                control.LostFocus += FirePropertyControlLostFocus;
                return control;
            }
            else if (pi.PropertyType == typeof(DateTime))
            {
                DateTimePicker control = new DateTimePicker();
                control.Enabled = false;
                control.Format = DateTimePickerFormat.Short;
                control.Dock = DockStyle.Fill;
                control.DropDownAlign = LeftRightAlignment.Right;
                control.Tag = new PropertyAndObject(pi, null);
                control.Leave += FirePropertyControlLostFocus;
                return control;
            }

            else if (pi.PropertyType == typeof(int))
            {
                NumericUpDown control = new NumericUpDown();
                control.Minimum = 0;
                control.Maximum = 1000;
                control.Enabled = false;
                control.Dock = DockStyle.Fill;
                control.TextAlign = HorizontalAlignment.Center;
                control.Tag = new PropertyAndObject(pi, null);
                control.Leave += FirePropertyControlLostFocus;
                return control;
            }

            else if (pi.PropertyType.IsEnum)
            {
                GroupBox control = new GroupBox();
                int y = 0;
                foreach (object o in Enum.GetValues(pi.PropertyType))
                {
                    RadioButton r = new RadioButton();
                    r.Tag = o;
                    r.Text = o.ToString();
                    r.Enabled = false;
                    r.Location = new Point(0, y);
                    y += r.Size.Height;
                    control.Leave += FirePropertyControlLostFocus;
                    control.Controls.Add(r);
                }
                control.Tag = new PropertyAndObject(pi, null);
                control.Dock = DockStyle.Fill;
                control.AutoSize = true;
                return control;
            }
            else if (pi.PropertyType == typeof(string))
            {
                TextBox control = new TextBox();
                control.Dock = DockStyle.Fill;
                control.TextAlign = HorizontalAlignment.Center;
                control.Enabled = false;
                control.BorderStyle = BorderStyle.Fixed3D;
                control.Tag = new PropertyAndObject(pi, null);
                control.Leave += FirePropertyControlLostFocus;
                return control;
            } else if (pi.PropertyType.GetInterfaces().Contains(typeof(IList)) && pi.PropertyType.IsGenericType)
            {
                TextBox control = new TextBox();
                control.Dock = DockStyle.Fill;
                control.TextAlign = HorizontalAlignment.Center;
                control.Enabled = false;
                control.BorderStyle = BorderStyle.Fixed3D;
                control.Tag = new PropertyAndObject(pi, null);
                return control;
            }
            else return null;
        }

        internal static void FillControl(Control control)
        {
            if (control.Tag == null || !(control.Tag is PropertyAndObject))
                return;

            PropertyInfo pi = ((PropertyAndObject) control.Tag).PropertyInfo;
            object obj = ((PropertyAndObject)control.Tag).Object;
            if (pi.PropertyType == typeof(Load))
            {
                ((RadRating)control).Value = (int)pi.GetValue(obj);
            }
            else if (pi.PropertyType == typeof(DateTime))
            {
                ((DateTimePicker)control).Value = (DateTime)pi.GetValue(obj);
            }

            else if (pi.PropertyType == typeof(int))
            {
                ((NumericUpDown)control).Value = (int)pi.GetValue(obj);
            }
            else if (pi.PropertyType.IsEnum)
            {
                foreach (RadioButton r in ((GroupBox)control).Controls)
                {
                    if (r.Tag == pi.GetValue(obj))
                    {
                        r.Checked = true;
                        break;
                    }
                }
            }
            else if (pi.PropertyType == typeof(string))
            {
                ((TextBox)control).Text = (string) pi.GetValue(obj);
            }
            else if (pi.PropertyType.GetInterfaces().Contains(typeof(IList)) && pi.PropertyType.IsGenericType)
            {
                string pref = "";
                if (((IList<Ingredient>) pi.GetValue(obj)).Any())
                    pref = (from p in ((IList<Ingredient>)pi.GetValue(obj)) select p.Name).Aggregate((x, y) => x + ", " + y);
                ((TextBox)control).Text = pref;
            }
        }

        internal static void SetEnabledStatus(Control control, bool enabled)
        {
            if (control.Tag == null || !(control.Tag is PropertyAndObject))
                return;

            PropertyInfo pi = ((PropertyAndObject)control.Tag).PropertyInfo;
            object obj = ((PropertyAndObject)control.Tag).Object;
            if (pi.PropertyType == typeof(Load))
            {
                ((RadRating)control).ReadOnly = !enabled;
            }
            else if (new Type[] { typeof(DateTime), typeof(string), typeof(int) }.Contains(pi.PropertyType))
            {
                control.Enabled = enabled;
            }
            else if (pi.PropertyType.IsEnum)
            {
                foreach (RadioButton r in ((GroupBox)control).Controls)
                {
                    r.Enabled = enabled;
                }
            }
            else if (pi.PropertyType.GetInterfaces().Contains(typeof(IList)) && pi.PropertyType.IsGenericType)
            {
                if (ManagerProvider.getManager<VersionManager>().Allows(Feature.CHANGE_PREFERENCES))
                {
                    control.Click += ModificaPreferenzeClickHandler;
                    control.BackColor = Color.White;
                }
                string pref = "";
                if (((IList<Ingredient>)pi.GetValue(obj)).Any())
                    pref = (from p in ((IList<Ingredient>)pi.GetValue(obj)) select p.Name).Aggregate((x, y) => x + ", " + y);
                ((TextBox)control).Text = pref;
            }
        }

        private static void ModificaPreferenzeClickHandler(object sender, EventArgs e)
        {
            PropertyInfo pi = ((PropertyAndObject)((Control)sender).Tag).PropertyInfo;
            object obj = ((PropertyAndObject)((Control)sender).Tag).Object;
            IList<Ingredient> preferences = (IList<Ingredient>) pi.GetValue(obj);
            PreferencesDialog dialog = new PreferencesDialog();
            dialog.PreferencesList.DataSource = ManagerProvider.getManager<KitchenManager>().Ingredients;
            dialog.PreferencesList.AllowColumnReorder = false;
            dialog.PreferencesList.FullRowSelect = false;

            foreach (Ingredient i in preferences)
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
                pi.SetValue(obj, newPrefs);
            }
        }
    }
}


