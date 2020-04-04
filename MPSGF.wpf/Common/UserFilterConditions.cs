using MPSGF.wpf.Model;

namespace MPSGF.wpf.Common
{
    public static class UserFilterConditions
    {
        public static bool IsMale(object param) =>
            ((User)param).Gender == Gender.Male;

        public static bool IsFemale(object param) =>
            !IsMale(param);

        public static bool IsWorker(object param) =>
            CheckPosition(param, UserPosition.Worker);

        public static bool IsManager(object param) =>
            CheckPosition(param, UserPosition.Manager);

        public static bool IsDirector(object param) =>
            CheckPosition(param, UserPosition.Director);

        private static bool CheckPosition(object param, UserPosition position) =>
            ((User)param).Position == position;
    }
}
