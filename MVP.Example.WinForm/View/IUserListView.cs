using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVP.Example.WinForm.Model.Entity;
using MVP.Example.WinForm.Presenter;

namespace MVP.Example.WinForm.View
{
    public interface IUserListView : IView<IUserListPresenter>
    {
        void ShowUsers(List<User> users);

        void ShowUser(User user);
    }
}