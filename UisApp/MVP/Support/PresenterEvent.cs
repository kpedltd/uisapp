using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UisApp.MVP.Support
{
    public delegate void PresenterEvent<TViewContract, TPresenterContract>(TPresenterContract sender, TViewContract view);
}
