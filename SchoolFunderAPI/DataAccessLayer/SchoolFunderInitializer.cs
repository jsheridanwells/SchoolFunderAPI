using SchoolFunderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;

namespace SchoolFunderAPI.DataAccessLayer
{
    public class SchoolFunderInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolFunderContext>
    {
        
        protected override void Seed(SchoolFunderContext context)
        {

        }
    }
}
