using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Client.Services;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

namespace CognitativeCrmVision.Services
{
    public class CrmService
    {
        public static void CreateConnection()
        {
            var connectionString = "Url=http://alcerri60316/CommunityPortal; Domain=alcerri60316Dom; Username=administrator; Password=T!T@n1130;";

            //CrmConnection con = new CrmConnection();
            CrmConnection con = CrmConnection.Parse(connectionString);
            var service = new OrganizationService(con);
            var context = new CrmOrganizationServiceContext(con);
            var response = service.Execute(new WhoAmIRequest());
            return;
        }
    }
}
