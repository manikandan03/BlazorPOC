using BlazeAPI.Context;
using BlazeAPI.IRepository;
using BlazeShared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazeAPI.Repository
{
    public class ConferenceRoomRepository : Repository<ConferenceRoom>, IConferenceRoomRepository
    {
        public new HRMS_TestingContext Context { get; }

        /// <summary>
        /// user repo
        /// </summary>
        /// <param name="context"></param>
        public ConferenceRoomRepository(HRMS_TestingContext context) : base(context)
        {
            Context = context;
        }
        public ConferenceRoomModel GetConferenceRooms()
        {

            List<ConferenceDetail> ConferenceDetailModels = new List<ConferenceDetail>();
            DateTime today = DateTime.Today;
            var result = GetConferenceRooms(today);
            foreach (var item in result)
            {
                ConferenceDetail ConferenceDetailModel = new ConferenceDetail()
                {
                    ConferenceID = item.ConferenceId,
                    Description = item.Description,
                    Time = item.StartTime + " - " + item.EndTime,
                    ProjectName = Context.Projects.Where(x => x.ProjectId == item.ProjectNameId).Select(x => x.ProjectName).FirstOrDefault(),
                    BookedBy = Context.Users.Where(x => x.UserId == item.FkUserId).Select(x => (x.FirstName + " " + x.LastName)).FirstOrDefault(),
                    BookForm = DateTime.ParseExact(item.StartTime, "H:mm", null, System.Globalization.DateTimeStyles.None),
                    BookTo = DateTime.ParseExact(item.EndTime, "H:mm", null, System.Globalization.DateTimeStyles.None),
                    UserId = item.FkUserId,
                    IsBooked = item.IsBooked != null ? Convert.ToInt32(item.IsBooked) : 0,
                    PurposeId = item.PurposeId,
                    Duration = GetDifferenceBtwTwoDates(item.StartTime, item.EndTime)
                };
                ConferenceDetailModels.Add(ConferenceDetailModel);
            }
            DateTime CurrentTime = DateTime.Now;
            ConferenceDetail conferencecurrentDetail = null;
            var currentMetting = ConferenceDetailModels.Where(x => x.BookForm < CurrentTime).OrderByDescending(x => x.BookForm).FirstOrDefault();
            if (currentMetting != null && (currentMetting.BookForm <= CurrentTime && currentMetting.BookTo >= CurrentTime))
            {
                conferencecurrentDetail = currentMetting;
                ConferenceDetailModels = ConferenceDetailModels.Where(x => x.ConferenceID != conferencecurrentDetail.ConferenceID && x.BookForm >= CurrentTime).ToList();
            }
            ConferenceRoomModel ConferenceRoomModels = new ConferenceRoomModel()
            {
                ConferenceDetail = ConferenceDetailModels.Where(x => x.BookForm >= CurrentTime).OrderBy(x => x.BookForm).Take(3).ToList(),
                CurrentConference = conferencecurrentDetail
            };

            return ConferenceRoomModels;
        }
        public List<ConferenceDetail> GetAllConferences()
        {
            List<ConferenceDetail> ConferenceDetailModels = new List<ConferenceDetail>();
            var result = Context.ConferenceRoom.Where(x => x.IsActive == true).ToList();
            foreach (var item in result)
            {
                ConferenceDetail ConferenceDetailModel = new ConferenceDetail()
                {
                    ConferenceID = item.ConferenceId,
                    Description = item.Description,
                    Time = item.StartTime + " - " + item.EndTime,
                    ProjectName = Context.Projects.Where(x => x.ProjectId == item.ProjectNameId).Select(x => x.ProjectName).FirstOrDefault(),
                    BookedBy = Context.Users.Where(x => x.UserId == item.FkUserId).Select(x => (x.FirstName + " " + x.LastName)).FirstOrDefault(),
                    BookForm = DateTime.ParseExact(item.StartTime, "H:mm", null, System.Globalization.DateTimeStyles.None),
                    BookTo = DateTime.ParseExact(item.EndTime, "H:mm", null, System.Globalization.DateTimeStyles.None),
                    UserId = item.FkUserId,
                    IsBooked = item.IsBooked != null ? Convert.ToInt32(item.IsBooked) : 0,
                    PurposeId = item.PurposeId,
                    Duration = GetDifferenceBtwTwoDates(item.StartTime, item.EndTime),
                    BookedDate = item.BookingDate
                };
                ConferenceDetailModels.Add(ConferenceDetailModel);
            }
            return ConferenceDetailModels;
        }
        public string GetDifferenceBtwTwoDates(string startTime, string endTime)
        {
            DateTime startTimes = Convert.ToDateTime(startTime);
            DateTime endTimes = Convert.ToDateTime(endTime);
            TimeSpan timeSpan = endTimes.Subtract(startTimes);
            return timeSpan.ToString("hh':'mm");
        }
        public IEnumerable<ConferenceDetail> GetConferenceRoomsByDate(DateTime dateTime)
        {
            List<ConferenceDetail> ConferenceDetailModels = new List<ConferenceDetail>();
            var result = GetConferenceRooms(dateTime.Date);
            foreach (var item in result)
            {
                ConferenceDetail ConferenceDetailModel = new ConferenceDetail()
                {
                    ConferenceID = item.ConferenceId,
                    Description = item.Description,
                    Time = item.StartTime + " - " + item.EndTime,
                    ProjectName = GetProjectNameById(item.ProjectNameId),
                    BookedBy = GetUserNameById(item.FkUserId),
                    BookForm = FormateDateTime(item.StartTime),
                    BookTo = FormateDateTime(item.EndTime),
                    BookedDate = item.BookingDate,
                    IsBooked = item.IsBooked != null ? Convert.ToInt32(item.IsBooked) : 0,
                    PurposeId = item.PurposeId,
                    Duration = GetDifferenceBtwTwoDates(item.StartTime, item.EndTime)

                };
                ConferenceDetailModels.Add(ConferenceDetailModel);
            }
            return ConferenceDetailModels;
        }
        public IEnumerable<DepartmentModel> GetDepartments()
        {
            var departments = Context.Department.Where(x => x.IsActive == true).Select(x => new DepartmentModel()
            {
                DepartmentID = x.DepartmentId.ToString(),
                DepartmentName = x.DepartmentName
            });
            return departments;
        }
        public IEnumerable<PurposeModel> GetPurpose()
        {
            var bookingPurpose = Context.BookingPurpose.Where(x => x.IsActive == true).Select(x => new PurposeModel()
            {
                PurposeID = x.PurposeId,
                PurposeName = x.PurposeName
            });
            return bookingPurpose;
        }
        public IEnumerable<UserModel> GetUsers()
        {
            var users = Context.Users.Where(x => x.IsActive == true).Select(x => new UserModel()
            {
                UserId = x.UserId,
                UserName = x.UserName,
                EmpId = x.EmpId,
                Password = x.Password

            });
            return users;
        }
        public IEnumerable<ProjectModel> GetProjects()
        {
            var projects = Context.Projects.Where(x => x.IsActive == true).Select(x => new ProjectModel()
            {
                ProjectID = x.ProjectId,
                ProjectName = x.ProjectName
            });
            return projects;
        }
        public List<ConferenceRoom> GetConferenceRooms(DateTime dateTime)
        {
            return Context.ConferenceRoom.Where(x => x.BookingDate >= dateTime && x.BookingDate < dateTime.AddDays(1) && x.IsActive == true).ToList();
        }
        public ConferenceRoom GetConferenceRoomById(int Id)
        {
            return Context.ConferenceRoom.Where(x => x.ConferenceId == Id).FirstOrDefault();
        }
        public ConferenceRoom AddConferenceBooking(ConferenceRoomBooking conferenceRoomBooking)
        {
            try
            {
                var newBook = new ConferenceRoom();
                newBook.BookingDate = conferenceRoomBooking.BookedDate.Date;
                newBook.StartTime = GetTimeForMateForTimepicker(conferenceRoomBooking.StartTime.ToString("H:mm"));
                newBook.EndTime = GetTimeForMateForTimepicker(conferenceRoomBooking.EndTime.ToString("H:mm"));
                newBook.Description = conferenceRoomBooking.Description;
                newBook.IsActive = true;
                newBook.PurposeId = Convert.ToInt32(conferenceRoomBooking.PurposeID);
                newBook.Attendees = conferenceRoomBooking.Attendees;
                newBook.ProjectNameId = Convert.ToInt32(conferenceRoomBooking.ProjectId);
                //newBook.NoOfAttendees = (conferenceRoomBooking.Attendees.Split(",")).Length;
                newBook.NoOfAttendees = 1;
                newBook.FkFloorId = 1;
                newBook.FkDepartmentId = conferenceRoomBooking.DepartmentId;
                //newBook.FkUserId = GetUserIdBasedOnEmployeeId( conferenceRoomBooking.EmployeeId);
                newBook.FkUserId = conferenceRoomBooking.Id;
                var addedEntity = Context.ConferenceRoom.Add(newBook);
                Context.SaveChanges();
                return addedEntity.Entity;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public void UpdateConferenceBooking(int conferenceId)
        {
            var conferenceRoom = Context.ConferenceRoom.Where(x => x.ConferenceId == conferenceId).FirstOrDefault();
            conferenceRoom.IsBooked = true;
            Context.ConferenceRoom.Update(conferenceRoom);
            Context.SaveChanges();
        }
        public void UpdateConferenceBookingToComplte(int conferenceId)
        {
            var conferenceRoom = Context.ConferenceRoom.Where(x => x.ConferenceId == conferenceId).FirstOrDefault();
            conferenceRoom.IsActive = false;
            //conferenceRoom.IsBooked = false;
            Context.ConferenceRoom.Update(conferenceRoom);
            Context.SaveChanges();
        }
        public string GetProjectNameById(int? projectID)
        {
            return Context.Projects.Where(x => x.ProjectId == projectID).Select(x => x.ProjectName).FirstOrDefault();
        }
        public string GetUserNameById(int? userID)
        {
            return Context.Users.Where(x => x.UserId == userID).Select(x => (x.FirstName + " " + x.LastName)).FirstOrDefault();
        }
        public DateTime FormateDateTime(string dateTime)
        {
            return DateTime.ParseExact(dateTime, "H:mm", null, System.Globalization.DateTimeStyles.None);
        }
        public string GetTimeForMateForTimepicker(string time)
        {
            var splitStrtTime = time.Split(':');
            var localAssign = splitStrtTime[0] + ":" + splitStrtTime[1];
            return localAssign;
        }

    }
}
