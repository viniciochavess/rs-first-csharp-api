using communications;
using communications.Request;

namespace api_client.UseCases.Clients
{
    public class RegisterClientUseCase
    {
        public ResponseClientJson Execute( RequestClientJson request)
        { 
            var validator = new RegisterClientValidator();
            var validationResult = validator.Validate(request);
            var responseClientJson = new ResponseClientJson
            {
                id = Guid.NewGuid(),
                name = "New Client"
            };
            return responseClientJson;
        }
    }
}
