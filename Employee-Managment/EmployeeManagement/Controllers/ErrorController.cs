using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> _logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            _logger = logger;
        }

        [Route("Error/{StatusCode}")]
        public IActionResult HttpStatusCodeHandler(int statuscode)
        {
            var statusCodeResults = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            
            switch (statuscode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, the resource you requested cannot be found.";

                    _logger.LogWarning($"404 Error occurred. Path = {statusCodeResults.OriginalPath}" + $"and QuerySting ={statusCodeResults.OriginalQueryString}");
                    //ViewBag.Path = statusCodeResults.OriginalPath;
                    //ViewBag.QS = statusCodeResults.OriginalQueryString;
                    break;
            }

            return View("NotFound");
        }
        [Route("Error")]
        [AllowAnonymous]
        public IActionResult Error()
        {
            var exceptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            _logger.LogError($"The path {exceptionDetails!.Path} threw an exception error {exceptionDetails.Error}");
            //ViewBag.ExceptionPath = exceptionDetails.Path;
            //ViewBag.ExceptionMessage = exceptionDetails.Error.Message;
            //ViewBag.StackTrace = exceptionDetails.Error.StackTrace;

            return View("Error");
        }
    }
}
