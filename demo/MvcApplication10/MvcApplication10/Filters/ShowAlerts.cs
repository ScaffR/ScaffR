namespace MvcApplication10.Filters
{
    using System.Web.Mvc;

    public class ShowAlerts : ActionFilterAttribute
    {
        private readonly bool _show;

        public ShowAlerts(bool show = true)
        {
            _show = show;
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.ShowAlerts = _show;

            base.OnActionExecuted(filterContext);
        }
    }
}