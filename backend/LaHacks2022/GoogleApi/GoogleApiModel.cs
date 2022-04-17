

using RestSharp;
using RestSharp.Authenticators;

using Google.Apis.Auth;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace GoogleApi
{
    public class GoogleApiModel
    {
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };

        public async Task<string> ValidateToken(string token)
        {
            try
            {
                GoogleJsonWebSignature.Payload payload = await GoogleJsonWebSignature.ValidateAsync(token);
                return payload.Email;
            }
            catch (Exception ex)
            {
                throw new Exception("Bad Token!");
            }
        }

        private CalendarService GetCalendarService(string keyfilepath)
        {
            try
            {
                string[] Scopes = {
                   CalendarService.Scope.Calendar,
                   CalendarService.Scope.CalendarEvents,
                   CalendarService.Scope.CalendarEventsReadonly
                  };

                GoogleCredential credential;
                using (var stream = new FileStream(keyfilepath, FileMode.Open, FileAccess.Read))
                {
                    // As we are using admin SDK, we need to still impersonate user who has admin access    
                    //  https://developers.google.com/admin-sdk/directory/v1/guides/delegation    
                    credential = GoogleCredential.FromStream(stream)
                     .CreateScoped(Scopes).CreateWithUser("spidey@avengers.com");
                }

                // Create Calendar API service.    
                var service = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Calendar Sample",
                });
                return service;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void CreateEvent(CalendarService _service)
        {
            Event body = new Event();
            EventAttendee a = new EventAttendee();
            a.Email = "spidey@avengers.com";
            EventAttendee b = new EventAttendee();
            b.Email = "ironman@avengers.com";
            List<EventAttendee> attendes = new List<EventAttendee>();
            attendes.Add(a);
            attendes.Add(b);
            body.Attendees = attendes;
            EventDateTime start = new EventDateTime();
            //start.DateTime = Convert.ToDateTime("2019-08-28T09:00:00+0530");
            EventDateTime end = new EventDateTime();
            //end.DateTime = Convert.ToDateTime("2019-08-28T11:00:00+0530");
            body.Start = start;
            body.End = end;
            body.Location = "Avengers Mansion";
            body.Summary = "Discussion about new Spidey suit";
            EventsResource.InsertRequest request = new EventsResource.InsertRequest(_service, body, "nickfury@avengers.com");
            Event response = request.Execute();
        }


        private void GetEvents(CalendarService _service)
        {
            // Define parameters of request.    
            EventsResource.ListRequest request = _service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 30;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            string eventsValue = "";
            // List events.    
            Events events = request.Execute();
            eventsValue = "Upcoming events:\n";
            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {
                    string when = eventItem.Start.DateTime.ToString();
                    if (String.IsNullOrEmpty(when))
                    {
                        when = eventItem.Start.Date;
                    }
                    eventsValue += string.Format("{0} ({1})", eventItem.Summary, when) + "\n";
                }
                //MessageBox.Show(eventsValue);
            }
            else
            {
                //MessageBox.Show("No upcoming events found.");
            }
        }
    }
}