using Blaze.Services.Interface;
using BlazeShared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blaze.ComponentBaseClass
{
    public class AddConferenceRoomBookingComponentBase : ComponentBase
    {
        #region Services
        [Inject]
        public IConferenceDataServices ConferenceDataServices { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        [Parameter]
        public string ConferenceId { get; set; }

        #endregion

        #region Properties
        public ConferenceRoomBooking ConferenceRoomBooking { get; set; } = new ConferenceRoomBooking();
        public List<DepartmentModel> Departments { get; set; } = new List<DepartmentModel>();
        public List<PurposeModel> BookingPurpose { get; set; } = new List<PurposeModel>();
        public List<ProjectModel> Projects { get; set; } = new List<ProjectModel>();
        public List<UserModel> Users { get; set; } = new List<UserModel>();
        public ConferenceRoomModel ConferenceRoomModel { get; set; } = new ConferenceRoomModel();
        public List<ConferenceDetail> allConferences { get; set; } = new List<ConferenceDetail>();
        public DateTime DatePickerValue { get; set; }

        #endregion

        #region Fields
        public IEnumerable<string> multipleValues = null;
        protected string purposeID = string.Empty;
        protected string userID = string.Empty;
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;
        protected string empIdValidationError = string.Empty;
        protected string deptIdValidationError = string.Empty;
        protected string attendeesValidationError = string.Empty;
        protected string endtimeValidationError = string.Empty;
        protected static string startTimepicker = string.Empty;
        protected static string endTimepicker = string.Empty;
        protected object selectedDepartments = string.Empty;
        private static string departmentId = string.Empty;
        private static string attendees = string.Empty;


        #endregion


        #region LifeCycleMethods
        protected override async Task OnInitializedAsync()
        {
            ConferenceRoomBooking.BookedDate = DateTime.Now;
            ConferenceRoomBooking.StartTime = DateTime.Now;
            ConferenceRoomBooking.EndTime = DateTime.Now;
            await LoadAllDropDownList();
            ConferenceRoomModel = await ConferenceDataServices.GetAllConference();
            allConferences = (await ConferenceDataServices.GetAllConferences()).ToList();
            }
        protected override void OnParametersSet()
        {
            //the param will be set now

            var temp = ConferenceId;
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeVoidAsync("SetDropDown");
                StateHasChanged();
            }
           
        }
        public void HandleValidSubmit()
        {
            var result = ConferenceRoomBooking;
            //ConferenceRoomBooking.Attendees = ConferenceRoomBooking.EmpID;

            if ((!ValidationCheck(ConferenceRoomBooking)))
            {
                var addedBooking = ConferenceDataServices.AddConferenceRoomBooking(result);
                if (addedBooking != null)
                {
                    StatusClass = "alert-success";
                    Message = "New Conference Booking added successfully.";
                    Saved = true;
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Something went wrong adding the new Booking. Please try again.";
                    Saved = false;
                }
            }
        }
        public void HandleInvalidSubmit()
        {
            var result = ConferenceRoomBooking;
        }

        #endregion
        public async Task LoadAllDropDownList()
        {
            Departments = (await ConferenceDataServices.GetDepartments()).ToList();
            BookingPurpose = (await ConferenceDataServices.GetPurpose()).ToList();
            Users = (await ConferenceDataServices.GetUsers()).ToList();
            Projects = (await ConferenceDataServices.GetProjects()).ToList();
        }
        public void OnProjectSelected()
        {
            int selectedProjectId = Convert.ToInt32(ConferenceRoomBooking.ProjectId);
        }
        public bool ValidationCheck(ConferenceRoomBooking conferenceRoomBooking)
        {
            if( CheckEmpIdExist(conferenceRoomBooking.EmployeeId) || CheckDepartIdSelected() || 
                CheckAttendeesSelected() || CheckDateTimeValidation(conferenceRoomBooking) || CheckAnyBookingClashing(conferenceRoomBooking))
            {
                return true;
            }
            return false;
        }
        public bool CheckAnyBookingClashing(ConferenceRoomBooking conferenceRoomBooking)
        {
            bool flag = false;
             DateTime date = ConferenceRoomBooking.BookedDate.Date;
            var dayConfernce = allConferences.Where(x => x.BookedDate.Date >= date && x.BookedDate.Date < date.AddDays(1)).Select(x=>x).ToList();
            var dayConfernce1 = allConferences.Where(x => x.BookedDate.Date == date ).Select(x=>x).ToList();
            if (dayConfernce.Count > 0)
            {

                var datalist = dayConfernce.OrderBy(x => x.BookForm).ToList();
                //var datalist = ConferenceRoomModel.ConferenceDetail.OrderBy(x => x.BookForm).ToList();

                if (datalist.Count(x => (x.BookForm >= conferenceRoomBooking.StartTime && x.BookTo <= conferenceRoomBooking.EndTime)) > 0)
                {
                    flag = true;
                    endtimeValidationError = "Your selected start and end time clashed with other booking or Booking time is lesser than current time.";
                }
               
                else
                {
                    for (int i = 0; i < datalist.Count; i++)
                    {
                        var startTime = datalist[i].BookForm;
                        var endTime = datalist[i].BookTo;

                        if (((conferenceRoomBooking.StartTime > startTime) && (ConferenceRoomBooking.StartTime < endTime)) ||
                            ((conferenceRoomBooking.EndTime > startTime) && (conferenceRoomBooking.EndTime < endTime)))
                        {
                            flag = true;
                            endtimeValidationError = "Your selected start and end time clashed with other booking or Booking time is lesser than current time.";
                        }
                    }
                }
                if(ConferenceRoomModel.CurrentConference!=null)
                {
               if (ConferenceRoomModel.CurrentConference.BookForm >= conferenceRoomBooking.StartTime &&
                    ConferenceRoomModel.CurrentConference.BookTo <= conferenceRoomBooking.EndTime)
                {
                    flag = true;
                    endtimeValidationError = "Your selected start and end time clashed with other booking or Booking time is lesser than current time.";
                }
                }
            }
            return flag;
        }
        public bool CheckEmpIdExist(string empId)
        {
            string appendedEmpId = "0" + empId;
            var userId = Users.Where(x => x.EmpId == appendedEmpId).Select(x => x.UserId).FirstOrDefault();
            if (userId == 0)
            {
                empIdValidationError = "Employee Id is not Correct";
                StateHasChanged();
                return true;
            }
            else
            {
                ConferenceRoomBooking.Id = userId;
            }
            return false;
        }
        public bool CheckDepartIdSelected()
        {
           if(string.IsNullOrWhiteSpace(departmentId))
            {
                deptIdValidationError = "Department is required field";
                return true;
            }
            else
            {
                ConferenceRoomBooking.DepartmentId = departmentId;
            }
            return false;
        }
        public bool CheckAttendeesSelected()
        {
            if (string.IsNullOrWhiteSpace(attendees))
            {
                attendeesValidationError = "Attendees is required field";
                return true;
            }
            else
            {
                ConferenceRoomBooking.Attendees = attendees;
            }
            return false;
        }

        public bool CheckDateTimeValidation(ConferenceRoomBooking conferenceRoomBooking)
        {
            
            if(startTimepicker =="" || endTimepicker=="")
            {
                endtimeValidationError = "Time is required field";
                return true;
            }
            conferenceRoomBooking.StartTime = Convert.ToDateTime(startTimepicker);
            conferenceRoomBooking.EndTime = Convert.ToDateTime(endTimepicker);
            var res = DateTime.Compare(conferenceRoomBooking.StartTime, conferenceRoomBooking.EndTime);
            if (res >= 0)
            {
                endtimeValidationError = "EndTime Should not be less than StartTime";
                return true;
            }
            return false;
        }
        protected void GoBackToTablePage()
        {
            NavigationManager.NavigateTo("/timetable");
        }

        #region JSInvokableMethods

        [JSInvokable]
        public static void GetDepartmentsSelected(string[] getSelectDepartment)
        {
            departmentId = string.Join(",", getSelectDepartment);
        }
        [JSInvokable]
        public static void GetAttendeesSelected(string[] getSelectAttendees)
        {
            attendees = string.Join(",", getSelectAttendees);
        }
        [JSInvokable]
        public static void GetStartTime(string selectedTime)
        {
            startTimepicker = selectedTime;
        }
        [JSInvokable]
        public static void GetEndTime(string selectedTime)
        {
            endTimepicker = selectedTime;
        }



        #endregion
    }
}
