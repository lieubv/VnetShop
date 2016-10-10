using AutoMapper;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VnetShop.Model.Models;
using VnetShop.Service;
using VnetShop.Web.Infrastructure.Core;
using VnetShop.Web.Models;
using VnetShop.Web.Infrastructure.Extensions;

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
        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, UserViewModel userVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    User newUser = new User();
                    newUser.UpdateUser(userVm);

                    var result = _userService.Add(newUser);
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
        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, UserViewModel userVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    var userDb = _userService.GetById(userVm.UserID);
                    userDb.UpdateUser(userVm);

                    _userService.Update(userDb);
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

                    var listUserVm = Mapper.Map<List<UserViewModel>>(listUser);

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