using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using MVP.Example.WinForm.Model.Entity;

namespace MVP.Example.WinForm.Presenter
{
    public interface IUserListListener<TPresenter> where TPresenter : IPresenter
    {
        void OnListUserFinish(TPresenter sender, User user);

        void OnListUsersFinish(TPresenter sender, List<User> users);
    }

    public interface IUserListPresenter : IPresenter , IUserListListener<IUserListPresenter>
    {
        void ShowUsers(List<User> users);

        void ShowUser(User user);
    }
}
