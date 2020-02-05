using Blaze.Shared;
using Blaze.Services.Interface;
using BlazeShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Blaze.Services.Class
{
    public class ConferenceDataServices : IConferenceDataServices
    {
        private readonly HttpClient _httpClient;

        public ConferenceDataServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ConferenceRoomModel> GetAllConference()
        {
            return await JsonSerializer.DeserializeAsync<ConferenceRoomModel>
                 (await _httpClient.GetStreamAsync($"api/ConferenceRoom/ConferenceRoomDetails"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        public async Task<IEnumerable<ConferenceDetail>> GetAllConferences()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<ConferenceDetail>>
                 (await _httpClient.GetStreamAsync($"api/ConferenceRoom/GetAllConferences"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<IEnumerable<ConferenceDetail>> ConferenceRoomByDate(DateTime dateTime)
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<ConferenceDetail>>
                 (await _httpClient.GetStreamAsync($"api/ConferenceRoom/ConferenceRoomByDate?dateTime="+dateTime),
                 new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<IEnumerable<DepartmentModel>> GetDepartments()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<DepartmentModel>>
                 (await _httpClient.GetStreamAsync($"api/ConferenceRoom/GetDepartments"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        public async Task<IEnumerable<PurposeModel>> GetPurpose()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<PurposeModel>>
                 (await _httpClient.GetStreamAsync($"api/ConferenceRoom/GetPurpose"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        public async Task<IEnumerable<UserModel>> GetUsers()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<UserModel>>
                 (await _httpClient.GetStreamAsync($"api/ConferenceRoom/GetUsers"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        public async Task<IEnumerable<ProjectModel>> GetProjects()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<ProjectModel>>
                 (await _httpClient.GetStreamAsync($"api/ConferenceRoom/GetProjects"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<ConferenceRoomBooking> AddConferenceRoomBooking(ConferenceRoomBooking conferenceRoomBooking)
        {
            var conferenceBooking = new StringContent(JsonSerializer.Serialize(conferenceRoomBooking), Encoding.UTF8, "application/Json");
            var response = await _httpClient.PostAsync("api/ConferenceRoom/AddConferenceBooking", conferenceBooking);
            if(response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<ConferenceRoomBooking>(await response.Content.ReadAsStreamAsync());
                
            }
            return null;
        }

        public async Task UpdateConference(int conferenceId)
        {
            await _httpClient.GetStreamAsync("api/ConferenceRoom/UpdateConferenceBooking?conferenceId=" + conferenceId);
        }
        public async Task UpdateConferenceToComplete(int conferenceId)
        {
            await _httpClient.GetStreamAsync("api/ConferenceRoom/UpdateConferenceToComplete?conferenceId=" + conferenceId);
        }

    }
}
