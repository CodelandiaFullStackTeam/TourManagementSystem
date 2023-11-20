using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TourManagementSystem.Business.Abstract;
using TourManagementSystem.Business.Concrete;
using TourManagementSystem.Classes;
using TourManagementSystem.Helpers;

namespace TourManagementSystem.Pages
{
    public partial class Countries : PageBase
    {
        private readonly ICountryService _countryService;
        public Countries()
        {
            _countryService = new CountryManager();
        }

        #region Properties

        public Mode PageMode
        {
            get
            {
                return (Mode)ViewState["mode"];
            }
            set
            {
                ViewState["mode"] = value;
            }
        }

        public int RowId
        {
            get
            {
                return (int)ViewState["id"];
            }
            set
            {
                ViewState["id"] = value;
            }
        }

        #endregion Properties

        #region BusinessActions

        private void LoadData()
        {
            var result = _countryService.GetAll();
            rptData.DataSource = result.Data.Where(x=>x.Deleted == 0).ToList();
            rptData.DataBind();
        }

        private void InsertData()
        {
            var model = new Country()
            {
                Name = txtName.Text
            };

            var result = _countryService.Add(model);

            if (!result.Success)
            {
                ShowMessageForSweetAlert(result.Message, result.Success);
            }
            else
            {
                // show success message
                ShowMessageForSweetAlert(result.Message, result.Success);
                LoadData();
            }
        }

        private void UpdateData()
        {
            var updatedModel = _countryService.GetById(RowId).Data;

            updatedModel.Name = txtName.Text;
            var result = _countryService.Update(updatedModel);
            if (!result.Success)
            {
                ShowMessageForSweetAlert(result.Message, result.Success);
            }
            else
            {
                ShowMessageForSweetAlert(result.Message, result.Success);
                LoadData();
                PageMode = Mode.Insert;
            }

        }

        private void DeleteData(int id)
        {
            var deletedModel = _countryService.GetById(id).Data;
            deletedModel.Deleted = deletedModel.ID;
            _countryService.Update(deletedModel);
            LoadData();
        }


        #endregion BusinessActions

        #region ControlActions
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PageMode == Mode.Insert)
                {
                    InsertData();
                }
                else
                {
                    UpdateData();
                }
            }
            catch (SqlException ex)
            {

                ShowMessageForSweetAlert(ex.InnerException.InnerException.Message, false);
            }
            catch (Exception ex)
            {
                ShowMessageForSweetAlert(ex.InnerException.Message, false);
                //ShowMessageForSweetAlert(ex.Message, false);
            }
        }

        protected void rptData_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Edit":
                    ShowModalForUpdate(int.Parse(e.CommandArgument.ToString()));
                    break;
                case "Delete":
                    DeleteData(int.Parse(e.CommandArgument.ToString()));
                    break;
                default:
                    break;
            }
        }

       

        protected void btnClose_Click(object sender, EventArgs e)
        {
            CloseModal(divCountryModal.ClientID);
        }

        protected void btnShowModal_Click(object sender, EventArgs e)
        {
            ShowModal(divCountryModal.ClientID,5);
        }

        #endregion ControlActions

        #region PageActions
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
                PageMode = Mode.Insert;
            }
        }





        #endregion PageActions

        #region CustomActions
        private void ShowModalForUpdate(int id)
        {
            hfRowId.Value = id.ToString();
            var result = _countryService.GetById(id);
            if (result.Success)
            {
                txtName.Text = result.Data.Name;
                PageMode = Mode.Edit;
                ShowModal(divCountryModal.ClientID, 5);
            }
            RowId = id;
        }


        #endregion CustomActions

        
    }
}