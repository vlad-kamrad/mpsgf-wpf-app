using GalaSoft.MvvmLight;
using MPSGF.wpf.Common;
using MPSGF.wpf.Model;
using System.Collections.Generic;

namespace MPSGF.wpf.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IList<User> users;
        private User selectedUser;

        public User SelectedUser
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                RaisePropertyChanged(() => SelectedUser);
            }
        }
        public IEnumerable<User> Users { get { return users; } }

        public MainViewModel()
        {
            // Flat seed data
            users = new List<User>
            {
                new Worker("Jason", Specialization.Locksmith, Gender.Male),
                new Worker("Rabotyaga", Specialization.Plumber, Gender.Male),
                new Worker("Bob", Specialization.Electrician, Gender.Male),
                new Worker("TJ", Specialization.Locksmith, Gender.Female),
                new Manager("Sara", 12, Gender.Female),
                new Manager("Kostya", 25, Gender.Male)
            };
        }
    }
}
