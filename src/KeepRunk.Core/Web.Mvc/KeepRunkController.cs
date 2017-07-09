using System.Web.Mvc;
using KeepRunk.Core.Extensions;

namespace KeepRunk.Core.Web.Mvc
{
    public class KeepRunkController : Controller
    {

//        /// <summary>
//        /// 当前会话登录的用户信息
//        /// </summary>
//        public UserInfoDto CurrentUser
//        {
//            get { return EngineContext.Current.Resolve<IUserInfoService>().GetCurrentUser(); }
//        }
//
//        /// <summary>
//        /// 判断是否登录
//        /// </summary>
//        public bool IsLogin
//        {
//            get { return EngineContext.Current.Resolve<IUserInfoService>().IsLogin(); }
//        }

        public JsonResult Success()
        {
            return Success("");
        }

        public JsonResult Success(string msg)
        {
            return Success("", msg);
        }

        public JsonResult Success(object data, string msg = "")
        {
            return Json(new { C = ResultCode.Success.ToInt(), msg, data }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Fail(string msg="")
        {
            return Json(new { C = ResultCode.Fail.ToInt(), msg = msg, data = "" }, JsonRequestBehavior.AllowGet);
        }
    }
}
