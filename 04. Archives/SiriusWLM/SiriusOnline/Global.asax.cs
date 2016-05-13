using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Sirius.SiriusOnline
{
    public class Global : System.Web.HttpApplication
    {
        public static string SQLServer = "SRVRADAN2\\RADAN";
        public static string SQLDatabase = "Sirius";
        public static string SQLUsername = "sa";
        public static string SQLPassword = "Csf?nnata";
        public static string SQLConnectionString = CreateSQLConnectionString(SQLServer, SQLUsername, SQLPassword, SQLDatabase);

        public static string CreateSQLConnectionString(string server, string username, string password, string database)
        {
            return ("metadata=res://*/EntityModelSirius.csdl|res://*/EntityModelSirius.ssdl|res://*/EntityModelSirius.msl;provider=System.Data.SqlClient;provider connection string=\"Data Source=" + server + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password + ";MultipleActiveResultSets=True\"");
        }

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup

        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

    }
}
