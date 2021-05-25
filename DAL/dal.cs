using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Models;

namespace DAL
{
    public class dal
    {
        private experianContext context { get; set; }
        public dal()
        {
            context = new experianContext();
        }

        public List<ExpDb> GetUserDetails()
        {
            List<ExpDb> userDetails;
            try
            {
                userDetails = (from user in context.ExpDbs select user).ToList();
            }
            catch (Exception)
            {
                return null;
            }
            return userDetails;
        }
    }
}
