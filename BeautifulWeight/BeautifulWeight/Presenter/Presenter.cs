using BeautifulWeight.Model;
using BeautifulWeight.Versions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWeight.Presenter
{
    public abstract class Presenter
    {
        private readonly SingleProfileModel _model;

        public Presenter(SingleProfileModel model)
        {
            this._model = model;
            ManagerProvider.getManager<VersionManager>().VersionChanged += Presenter_VersionChanged;
        }

        protected virtual void Presenter_VersionChanged(object sender, EventArgs e)
        {

        }

        public SingleProfileModel Model
        {
            get
            {
                return _model;
            }
        }
    }
}
