using MPSGF.wpf.Common;

namespace MPSGF.wpf.Model
{
    public class Manager : User
    {
        public int SuccessfulProjects { get; set; }
        public Manager(string name, int successfulProjects, Gender gender) 
            : base(name, UserPosition.Manager, gender)
        {
            SuccessfulProjects = successfulProjects;
        }
    }
}
