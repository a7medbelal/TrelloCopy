using Microsoft.AspNetCore.Mvc;
using TrelloCopy.Common.BaseEndpoints;
using TrelloCopy.Common.Views;
using TrelloCopy.Features.AuthManagement.LogInUser;
using TrelloCopy.Features.AuthManagement.LogInUser.Commands;
using TrelloCopy.Features.UserManagement.GetAllUsers.Queries;

namespace TrelloCopy.Features.UserManagement.GetAllUsers;

public class GetAllUsersEndpoint : BaseEndpoint<PaginationRequestViewModel ,UserResponseViewModel>
{
   public GetAllUsersEndpoint(BaseEndpointParameters<PaginationRequestViewModel> parameters) : base(parameters)
   {
   }

   [HttpGet]
   public async Task<EndpointResponse<UserResponseViewModel>> GetAllUsers([FromQuery] PaginationRequestViewModel paginationRequest)
   {

        var validationResult = ValidateRequest(paginationRequest);
        if (!validationResult.isSuccess)
            return validationResult;

        var allUsers = await _mediator.Send(new GetAllUsersQuery(paginationRequest.PageNumber, paginationRequest.PageSize));

      if (!allUsers.isSuccess)
         return EndpointResponse<UserResponseViewModel>.Failure(allUsers.errorCode, allUsers.message);

      var paginatedResult = allUsers.data;

      var response = new UserResponseViewModel
      {
         Users = paginatedResult.Select(u => new UserDTO
         {
            Email = u.Email,
            Name = u.Name,
            PhoneNo = u.PhoneNo,
            IsActive = u.IsActive
         }).ToList(),
         TotalCount = paginatedResult.TotalCount,
         PageNumber = paginationRequest.PageNumber,
         PageSize = paginationRequest.PageSize
      };

      return EndpointResponse<UserResponseViewModel>.Success(response);
   }
}
