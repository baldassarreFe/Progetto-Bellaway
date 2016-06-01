using BeautifulWeight.Model;
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
