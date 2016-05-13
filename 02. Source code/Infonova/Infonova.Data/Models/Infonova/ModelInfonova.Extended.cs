using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infonova.Data.Models.Infonova
{
    public partial class ModelInfonova
    {
        public ModelInfonova(string connectionString) : base(connectionString)
        {
        }

        public static ModelInfonova GetNewModel()
        {
            //return new ModelInfonova("data source=25.93.112.153\\SQLEXPRESS;initial catalog=Infonova;persist security info=True;user id=sa;password=123456;MultipleActiveResultSets=True;App=EntityFramework");
            return new ModelInfonova("metadata = res://*/Models.Infonova.ModelInfonova.csdl|res://*/Models.Infonova.ModelInfonova.ssdl|res://*/Models.Infonova.ModelInfonova.msl;provider=System.Data.SqlClient;provider connection string=\"data source=25.93.112.153\\SQLEXPRESS;initial catalog=Infonova;persist security info=True;user id=sa;password=123456;MultipleActiveResultSets=True;App=EntityFramework\"");
        }
        //metadata=res://*/Models.Infonova.ModelInfonova.csdl|res://*/Models.Infonova.ModelInfonova.ssdl|res://*/Models.Infonova.ModelInfonova.msl;provider=System.Data.SqlClient;provider connection string="data source=25.93.112.153\SQLEXPRESS;initial catalog=Infonova;persist security info=True;user id=sa;password=***********;MultipleActiveResultSets=True;App=EntityFramework"
    }
}
