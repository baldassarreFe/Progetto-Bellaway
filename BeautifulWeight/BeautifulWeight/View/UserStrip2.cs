using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BeautifulWeight.Users;

namespace BeautifulWeight.View
{
    public partial class UserStrip2: UserControl
    {
        // TODO serve questo campo??
        private UserProfile _userProfile;

        public UserProfile UserProfile
        {
            get
            {
                return _userProfile;
            }

            set
            {
                _userProfile = value;
                _nomeLabel.Text = _userProfile.Details.Name;
                _cognomeLabel.Text = _userProfile.Details.Surname;
            }
        }

        public UserStrip2()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _profileImage.Image = Image.FromFile("Resources/user.png");
        }
    }
}
