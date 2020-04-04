using MPSGF.wpf.Common;

namespace MPSGF.wpf.Model
{
    public abstract class User
    {
        public string Name { get; set; }
        public UserPosition Position { get; set; }
        public Gender Gender { get; set; }

        protected User(string name, UserPosition position, Gender gender)
        {
            Name = name;
            Position = position;
            Gender = gender;
        }

    }
}
