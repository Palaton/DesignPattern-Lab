using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVP.Example.WinForm.Model.Entity;
using MVP.Example.WinForm.Presenter;

namespace MVP.Example.WinForm.View
{
    public interface IUserAddView : IView<IUserAddPresenter>
    {
        void AddUser(User user);
    }
}
