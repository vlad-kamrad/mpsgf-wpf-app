using MPSGF.wpf.Model;
using System.Collections;
using System.ComponentModel;

namespace MPSGF.wpf.Common
{
    public class UserComparer : IComparer
    {
        private readonly int direction;
        public UserComparer(ListSortDirection direction)
        {
            this.direction = direction == ListSortDirection.Ascending ? 1 : -1;
        }
        public int Compare(object first, object second) =>
            ((User)first).Name.Length.CompareTo(((User)second).Name.Length) * direction;
    }
}
