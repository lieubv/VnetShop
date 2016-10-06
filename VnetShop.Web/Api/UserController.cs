using System.Net;
using System.Net.Http;
using System.Web.Http;
using VnetShop.Model.Models;
using VnetShop.Service;
using VnetShop.Web.Infrastructure.Core;

namespace VnetShop.Web.Api
{
    [RoutePrefix("api/user")]
    public class UserController : ApiControllerBase
    {
        private IUserService _userService;

        public UserController(IErrorService errorService, IUserService userService)
            : base(errorService)
        {
            this._userService = userService;
        }

        // Create
        public HttpResponseMessage Post(HttpRequestMessage request, User user)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    var result = _userService.Add(user);
                    _userService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.Created, result);
                }
                else
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }

                return response;
            });
        }

        // Update
        public HttpResponseMessage Put(HttpRequestMessage request, User user)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    _userService.Update(user);
                    _userService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }

                return response;
            });
        }

        // Delete
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    var result = _userService.Delete(id);
                    _userService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.Created, result);
                }
                else
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }

                return response;
            });
        }

        // Get
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    var listUser = _userService.GetAll();

                    response = request.CreateResponse(HttpStatusCode.OK, listUser);
                }
                else
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }

                return response;
            });
        }
    }
}