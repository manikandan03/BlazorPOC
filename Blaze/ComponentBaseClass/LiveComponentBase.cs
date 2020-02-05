using Blaze.Services.Interface;
using BlazeShared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.ComponentBaseClass
{
    public class LiveComponentBase : ComponentBase
    {
        #region Services
        [Inject]
        public IConferenceDataServices ConferenceDataServices { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        [Inject]
        public ILoginDataServices LoginDataServices { get; set; }

        #endregion

        #region Prooperties
        public ConferenceRoomModel ConferenceRoomModel { get; set; } = new ConferenceRoomModel();
        public List<UserModel> Users { get; set; } = new List<UserModel>();
        #endregion

        #region Field
        protected string IsBookedButtonText = string.Empty;
        public string employeeId = string.Empty;
        public string password = string.Empty;
        protected bool isBookedFlag = false;
        protected string yesImInDivShow = string.Empty;
        protected string empIdDivShow = string.Empty;
        protected string confirmationText = string.Empty;
        protected string SuccessfullMsg = string.Empty;
        #endregion
        protected override async Task OnInitializedAsync()
        {
            StateHasChanged();
            ConferenceRoomModel.CurrentConference = new ConferenceDetail();
            //ConferenceRoomModel.CurrentConference.IsBooked = 0;
            ///Check based on isBooked column if isBooked is 0 show I'm in
            ConferenceRoomModel = await ConferenceDataServices.GetAllConference();
            if(ConferenceRoomModel.CurrentConference !=null)
            {
            IsBookedButtonText = ConferenceRoomModel.CurrentConference.IsBooked == 0 ? "Yes I'm In" : "I'm Out";
            }
            Users = (await ConferenceDataServices.GetUsers()).ToList();
            empIdDivShow = "none";

        }

        protected void IsBooked(int isBooked)
        {
                StateHasChanged();
            if (isBooked == 0)
            {
                isBookedFlag = true;
                yesImInDivShow = "none";
                IsBookedButtonText = "I'm Out";
                empIdDivShow = string.Empty;
                //UpdateBookingStatus();
            }
            else
            {
                UpdateBookingStatusToComplete();
                yesImInDivShow = "none";
                SuccessfullMsg = "Booking has Completed Successfully";
            }
        }
        private int GetEmpIdOfConference(string empId)
        {
            var userId = Users.Where(x => x.EmpId == empId).Select(x => x.UserId).FirstOrDefault();
            return userId;
        }
        protected void CheckValidEmpId()
        {
            if (string.IsNullOrWhiteSpace(employeeId)|| string.IsNullOrWhiteSpace(password))
            {
                confirmationText = "Fields are required.";
            }
            else
            {
                employeeId = "0" + employeeId;
                
                int userId = GetEmpIdOfConference(employeeId);
                //if (ConferenceRoomModel.CurrentConference.UserId == userId)
                if (!ValidateUser())
                {
                    empIdDivShow = "none";
                    yesImInDivShow = string.Empty;
                    confirmationText = string.Empty;
                    ///Make IsBooked is 1 so that it will show meeting is going
                    UpdateBookingStatus();
                }
                else
                {
                    employeeId = string.Empty;
                    password = string.Empty;
                    confirmationText = "Not valid User";
                }

            }
        }
        public  bool ValidateUser()
        {
            var decryptPass = Create_SHA256(password);
            var getUserName= Users.Where(x => x.EmpId == employeeId && x.Password== decryptPass).Select(x => x.UserName).FirstOrDefault();
            return string.IsNullOrWhiteSpace(getUserName) ? true : false;
        }

        public static string Create_SHA256(String Password)
        {
            SHA256Managed crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(Password), 0, Encoding.UTF8.GetByteCount(Password));

            foreach (byte bit in crypto)
            {
                hash += bit.ToString("x2");
            }
            return hash;
        }
        private void UpdateBookingStatus()
        {
            ConferenceDataServices.UpdateConference(ConferenceRoomModel.CurrentConference.ConferenceID);
            ///update the isBooked column to 0
            ///and IsActive to 0;
        }
        private void UpdateBookingStatusToComplete()
        {
            ConferenceDataServices.UpdateConferenceToComplete(ConferenceRoomModel.CurrentConference.ConferenceID);
        }


    }
}
