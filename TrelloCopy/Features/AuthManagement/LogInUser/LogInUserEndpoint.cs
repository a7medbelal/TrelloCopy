using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrelloCopy.Common.BaseEndpoints;
using TrelloCopy.Common.Views;
using TrelloCopy.Features.Common.Users.DTOs;
using TrelloCopy.Features.AuthManagement.LogInUser.Commands;
using TrelloCopy.Features.AuthManagement.RegisterUser.Commands;
using TrelloCopy.Features.AuthManagement.ReSendRegistrationEmail.Commands;

namespace TrelloCopy.Features.AuthManagement.LogInUser;

public class LogInUserEndpoint : BaseEndpoint<LogInUserRequestViewModel, LoginResponeViewModel>
{
   public LogInUserEndpoint(BaseEndpointParameters<LogInUserRequestViewModel> parameters) : base(parameters)
   {
   }

   [HttpPost]
   public async Task<EndpointResponse<LoginResponeViewModel>> LogInUser(LogInUserRequestViewModel viewmodel)
   {
      var validationResult =  ValidateRequest(viewmodel);
      if (!validationResult.isSuccess)
         return validationResult;
      
      var loginCommand = new LogInUserCommand(viewmodel.Email, viewmodel.Password);
      var logInToken = await _mediator.Send(loginCommand);
      if (!logInToken.isSuccess)
         return EndpointResponse<LoginResponeViewModel>.Failure(logInToken.errorCode, logInToken.message);
      
      return EndpointResponse<LoginResponeViewModel>.Success(new LoginResponeViewModel(Token: logInToken.data.LogInToken, TokenWith2FA: logInToken.data.TokenWith2FA));
   }
}
