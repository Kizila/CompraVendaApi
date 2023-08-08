using CompraVendaApi.Classes;
using CompraVendaApi.Models.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CompraVendaApi.Controllers
{
    public class BaseController : ControllerBase
    {
        internal async Task<IActionResult> FuncToCreated<T>(T modelCreate, long wtch) where T : class
        {
            return await Task.FromResult(Created("DefaultApi",
                new WrappingModel<T>()
                {
                    Subject = this.GetType().Name + "." + MethodBase.GetCurrentMethod().Name,
                    Time = wtch.ToString() + "ms",
                    StatusCode = (int)HttpStatusCode.Created,
                    TagCode = (int)Enums.TagCode.SuccessCreate,
                    Description = string.Empty,
                    Item = modelCreate
                }));
        }

        internal async Task<IActionResult> FuncToUpdate<T>(T modelUpdate, long wtch) where T : class
        {
            return await Task.FromResult(StatusCode((int)HttpStatusCode.OK,
                new WrappingModel<T>()
                {
                    Subject = this.GetType().Name + "." + MethodBase.GetCurrentMethod().Name,
                    Time = wtch.ToString() + "ms",
                    StatusCode = (int)HttpStatusCode.OK,
                    TagCode = (int)Enums.TagCode.SuccessUpdate,
                    Description = string.Empty,
                    Item = modelUpdate
                }));
        }

        internal IActionResult FormatedError<T>(string controller, Stopwatch watch, HttpStatusCode statusCode, Enums.TagCode tagCode,
                                                   string description = "", dynamic item = null, Dictionary<String, String> error = null, [CallerMemberName] string callerMethod = "") where T : class
        {
            //var SACWEBServerName = ConfigurationManager.AppSettings["SACWEBServerName"];

            //error = error ?? new Dictionary<String, String>();
            //var errorMsg = "";

            //errorMsg = errorMsg + "URL: " + HttpContext.Current.Request.Url.AbsoluteUri + "<br>";
            //errorMsg = errorMsg + "Subject: " + controller + "/" + callerMethod + "<br>";
            //errorMsg = errorMsg + "Time: " + (watch.ElapsedMilliseconds).ToString() + "ms" + "<br>";
            //errorMsg = errorMsg + "StatusCode: " + (int)statusCode + "<br>";
            //errorMsg = errorMsg + "TagCode: " + (int)tagCode + "<br>";
            //errorMsg = errorMsg + "Description: " + description + "<br>";
            //errorMsg = errorMsg + "Item: " + item + "<br>";
            //errorMsg = errorMsg + "User: " + UserNameForErrorEmail + "<br>";

            try
            {
                //string ToEmail, SubJect, Body, cc, Bcc;

                ////Reading values from form collection (Querystring) and assigning values to parameters
                //ToEmail = "sacweb.dev@ncr.local";
                //SubJect = SACWEBServerName + " - ERROR on SACWEB";
                //Body = errorMsg;
                //cc = "";
                ////cc = "ricardo.sousa@ncrangola.com";
                //Bcc = "";

                //var path = "";
                //var filesList = new string[] { };

                //if (path != "")
                //{
                //    filesList = new string[] {
                //        path
                //    };
                //}

                //var SACWEBType = ConfigurationManager.AppSettings["SACWEBType"];

                ////SACWEBSendEmail(string ToEmail, string cc, string Bcc, string Subject, string Body, string[] attach, bool canAlwaysSend, string SACWEBType, int? companyID)
                //XPBaseController.SACWEBSendEmail(ToEmail, cc, Bcc, SubJect, Body, filesList, true, SACWEBType, null);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ex: " + ex.ToString());
            }


            return StatusCode((int)HttpStatusCode.ExpectationFailed, new WrappingModel<T>()
            {
                Subject = controller + "/" + callerMethod,
                Time = (watch.ElapsedMilliseconds).ToString() + "ms",
                StatusCode = (int)statusCode,
                TagCode = (int)tagCode,
                //Description = description,
                Description = description.Replace(@"\r\n", "<br/>").Replace(Environment.NewLine, "<br/>"),
                Item = item,
                Error = error
            });
        }

    }
}
