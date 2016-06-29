using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVP.Example.WinForm.View;

namespace MVP.Example.WinForm.Presenter
{
    public delegate void RefreshViewHandler(object sender, PresenterRereshViewEventArgument e);

    public class PresenterRereshViewEventArgument : EventArgs
    {
        public object Data { get; set; }
    }

    public interface IPresenter
    {
        event RefreshViewHandler RefreshViewEvent;

        void ResponseNotification(string message);
    }
}
