using MPSGF.wpf.Common;

namespace MPSGF.wpf.Model
{
    public class Worker : User
    {
        public Specialization Specialization { get; set; }
        public Worker(string name, Specialization specialization, Gender gender) 
            : base(name, UserPosition.Worker, gender)
        {
            Specialization = specialization;
        }
    }
}
