using MediatR;
using TrelloCopy.Common;
using TrelloCopy.Common.Views;
using TrelloCopy.Features.UserManagement.ConfirmUserRegistration.Queries;
using TrelloCopy.Models;

namespace TrelloCopy.Features.UserManagement.ConfirmUserRegistration.Commands;

public record ConfirmEmailCommand(string email, string token) : IRequest<RequestResult<bool>>;

public class ConfirmEmailHandler : UserBaseRequestHandler<ConfirmEmailCommand, RequestResult<bool>>
{
    public ConfirmEmailHandler(UserBaseRequestHandlerParameters parameters) : base(parameters)
    {
    }

    public override async Task<RequestResult<bool>> Handle(ConfirmEmailCommand request,
        CancellationToken cancellationToken)
    {
        var isRegistered = await _mediator.Send(new IsUserRegisteredQuery(request.email, request.token));

        User user = new User();
        if (isRegistered.isSuccess)
        {
            user.ID = isRegistered.data;
            user.IsEmailConfirmed = true;
            user.ConfirmationToken = null;

            var result = await _userRepository.SaveIncludeAsync(user, nameof(User.IsEmailConfirmed),
                nameof(User.ConfirmationToken));

            await _userRepository.SaveChangesAsync();
            return RequestResult<bool>.Success(result);
        }

        return RequestResult<bool>.Failure(isRegistered.errorCode, isRegistered.message);
    }

    
}



