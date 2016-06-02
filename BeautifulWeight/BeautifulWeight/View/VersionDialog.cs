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
            _versionsListView.DataSource = ManagerProvider.getModelManager<VersionManager>().AllVersions;
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

    internal class VersionVisualItem : BaseListViewVisualItem
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
            IEnumerable<string> feats = from feature in ((IEnumerable<Feature>)Data["AllowedFeatures"])
                                        select feature.ToString();
            string features = feats.Any() ? feats.Aggregate((x, y) => x + ", " + y) : "";
            this.Text = "<html>" + name + "\t\t" + "</html>";
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
