using BeautifulWeight.Model;
using BeautifulWeight.Versions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace BeautifulWeight.View
{
    public partial class VersionDialog : Form
    {
        public VersionDialog()
        {
            InitializeComponent();
            _versionsListView.VisualItemCreating += _preferencesList_VisualItemCreating;
            _versionsListView.CurrentItemChanged += _versionsListView_CurrentItemChanged;
            _versionsListView.DataSource = ManagerProvider.getModelManager<VersionManager>().AllVersions.Where(v => v.CompareTo(ManagerProvider.getModelManager<VersionManager>().CurrentVersion) > 0);
            _versionsListView.CurrentItem = null;
            _okButton.Click += _okButton_Click;
            foreach (RichTextBox codeBox in _buttonPanel.Controls.OfType<RichTextBox>())
            {
                codeBox.KeyUp += CodeBox_KeyUp;
            }
        }

        private void _versionsListView_CurrentItemChanged(object sender, ListViewItemEventArgs e)
        {
            ValidateForm();
        }

        private void ValidateForm()
        {
            bool attivare = true;
            foreach (RichTextBox codeBox in _buttonPanel.Controls.OfType<RichTextBox>())
            {
                attivare &= (codeBox.Text.Length == 4);
            }
            attivare &= (_versionsListView.CurrentItem != null);
            _okButton.Enabled = attivare;
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            Code code = new Code(_codeBox1.Text, _codeBox2.Text, _codeBox3.Text, _codeBox4.Text);
            Versions.Version attempt = (Versions.Version)_versionsListView.CurrentItem.DataBoundItem;
            if (ManagerProvider.getModelManager<VersionManager>().ChangeVersion(attempt, code))
            {
                MessageBox.Show("Upgrade riuscito, ora puoi provare le nuove features", "AGGIORNAMENTO RIUSCITO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                if (MessageBox.Show("E' IRRILEVANTE", "E' IRRILEVANTE", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    this.DialogResult = DialogResult.None;
                else
                    this.DialogResult = DialogResult.Cancel;
            }
        }

        private void CodeBox_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateForm();
        }

        public Panel ButtonPanel
        {
            get
            {
                return _buttonPanel;
            }
        }

        public RadListView PreferencesList
        {
            get
            {
                return _versionsListView;
            }
        }

        private void _preferencesList_VisualItemCreating(object sender, ListViewVisualItemCreatingEventArgs e)
        {
            e.VisualItem = new VersionVisualItem();
        }
    }

    internal class VersionVisualItem : SimpleListViewVisualItem
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
            base.SynchronizeProperties();
            this.Padding = new Padding(5);
            string name = ((Versions.Version)Data.DataBoundItem).Description;
            IEnumerable<Feature> feats = ((Versions.Version)Data.DataBoundItem).AllowedFeatures;
            string features = feats.Any() ? feats.Select(f => f.ToString()).Aggregate((x, y) => x + ", " + y) : "";
            this.Text = "<html>" + name + "    " + features + "</html>";
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
