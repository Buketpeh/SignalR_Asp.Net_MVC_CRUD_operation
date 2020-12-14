using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudCase.Hubs
{
    [HubName("NotifyClients")]
    public class HubVehicle : Hub
    {
        public static void NotifyCurrentVehicleInformationToAllClients()
        {
            try
            {
                IHubContext context = GlobalHost.ConnectionManager.GetHubContext<HubVehicle>();
                context.Clients.All.updatedClients();
            }
            catch(Exception w)
            {
                Console.Write(w.Message);
            }
          
   
        }
       
    }
}