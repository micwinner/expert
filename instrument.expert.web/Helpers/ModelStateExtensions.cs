using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace instrument.expert.web.Helpers
{
    public static class ModelStateExtensions
    {
        public static string ExpendErrors(this Controller controller)
        {
            var sbErrors = new StringBuilder();
            foreach (var item in controller.ModelState.Values.Where(item => item.Errors.Count > 0))
            {
                for (var i = item.Errors.Count - 1; i >= 0; i--)
                {
                    sbErrors.Append("● ");
                    sbErrors.Append(item.Errors[i].ErrorMessage);
                    sbErrors.Append("<br/>");
                }
            }
            return sbErrors.ToString();
        }
    }
}