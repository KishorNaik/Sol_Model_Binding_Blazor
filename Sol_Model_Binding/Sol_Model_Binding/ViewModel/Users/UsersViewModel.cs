using Microsoft.AspNetCore.Components;
using Sol_Model_Binding.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Model_Binding.ViewModel.Users
{
    public class UsersViewModel
    {

        public UsersViewModel()
        {
            Users = new UsersModel();
        }

        public UsersModel Users { get; set; }

        public void OnSubmit()
        {
            Users.FirstName = "Eshaan";
            Users.LastName = "Naik";
        }
    }
}
