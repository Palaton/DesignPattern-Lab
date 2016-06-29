using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP.Example.WinForm.Presenter;

namespace MVP.Example.WinForm.View
{
    public interface IView<TPresenter> where TPresenter:IPresenter
    {
        TPresenter Presenter { get; set; }
    }
}
