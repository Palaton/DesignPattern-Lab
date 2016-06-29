using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVP.Example.WinForm.Model.Entity;

namespace MVP.Example.WinForm.Presenter
{
    public interface IUserAddListener<TPresenter> where TPresenter:IPresenter
    {
        void OnAddUserFinish(TPresenter sender,User user);
    }

    public interface IUserAddPresenter : IPresenter, IUserAddListener<IUserAddPresenter>
    {
        void AddUser(User user);
    }
}
