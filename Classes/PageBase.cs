using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace TourManagementSystem.Classes
{
    public class PageBase:Page
    {
        protected static void ExecuteJavascript(Control page, string Javasript)
        {
            ScriptManager.RegisterStartupScript(page, page.GetType(), Guid.NewGuid().ToString(), Javasript, true);
        }

        protected void ShowMessageForSweetAlert(string message, bool isSuccess)
        {
            ExecuteJavascript(this, $"showMessage('Information','{message}',{(isSuccess ? "true" : "false")});");
        }
        protected override void Render(HtmlTextWriter writer)
        {
            foreach (var key in ViewState.Keys)
            {
                if (!(key is string))
                {
                    continue;
                }
                var key_ = key as string;
                if (!key_.StartsWith("modal_"))
                {
                    continue;
                }

                var id = key_.Replace("modal_", string.Empty);
                var size = (int)ViewState[key_];
                ExecuteJavascript(this, $"showPopUp('{id}', {size});");
            }
            base.Render(writer);
        }

        public void ShowModal(string modalId, int size)
        {
            ViewState[$"modal_{modalId}"] = size;
        }

        public void CloseModal(string modalId)
        {
            ViewState.Remove($"modal_{modalId}");
        }
    }
}