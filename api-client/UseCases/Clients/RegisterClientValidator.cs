using communications.Request;
using FluentValidation;

namespace api_client.UseCases.Clients
{
    public class RegisterClientValidator : AbstractValidator<RequestClientJson>
    {
        public RegisterClientValidator() 
        { 
            RuleFor(client => client.name).NotEmpty().WithMessage("Name é requerido");
            RuleFor(client => client.email).EmailAddress().WithMessage("Email inválido");
        }
    }
}
