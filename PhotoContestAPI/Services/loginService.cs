using PhotoContestAPI.Model;

namespace PhotoContestAPI.Services
{
    public interface IloginService
    {
        bool IsAuthenticated(LoginUserModel loginUserModel);
    }
    public class loginService : IloginService
    {
        private PhotoContestDBContext _context;

        IUserService _userService;
        public loginService(PhotoContestDBContext context, IUserService service)
        {
            _context = context;
            _userService = service;
        }
        public bool IsAuthenticated(LoginUserModel loginUserModel)
        {
            UserModel user = _userService.GetUserDetailsById(loginUserModel.UserName);
            if(user == null) return false;
            if (user.Password.Equals(loginUserModel.Password)) return true;
            return false;  
        }
    }
}
