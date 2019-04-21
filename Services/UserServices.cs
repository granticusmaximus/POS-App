using pos_app.Models;

namespace pos_app.Services
{
    public class UserServices : IUserServices
    {
        private IValidationDictionary _validation;
        
        public UserServices(IValidationDictionary validation)
        {
            _validation = validation;
        }
    }
}