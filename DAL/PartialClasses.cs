using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PartialClasses
    {
        public HMOEntities DB { get; set; } = HMOEntities.Instance;
    }

    public partial class User : PartialClasses
    {
        public override string ToString()
        {
            return this.FirstName_user+ " "+ this.LastName_user;
        }
        public void Add()
        {
            this.DB.User.Add(this);
            this.DB.SaveChanges();
        }

        public void Delete()
        {
            this.DB.User.Remove(this);
            this.DB.SaveChanges();
        }

        public void Update()
        {
            this.DB.SaveChanges();
        }
    }

    public partial class Vaccination : PartialClasses
    {
        public override string ToString()
        {
            return this.Description_vacc;
        }
        public void Add()
        {
            this.DB.Vaccination.Add(this);
            this.DB.SaveChanges();
        }
    }

    public partial class CoronaTest : PartialClasses
    {
        public override string ToString()
        {
            return this.Description_coronaTest;
        }
        public void Add()
        {
            this.DB.CoronaTest.Add(this);
            this.DB.SaveChanges();
        }
    }

    public partial class UserPerVaccination : PartialClasses
    {
        public void Add()
        {
            this.DB.UserPerVaccination.Add(this);
            this.DB.SaveChanges();
        }

        public override string ToString()
        {
            return this.Vaccination.Description_vacc.Trim() + " - "+ this.Date_userPerVacc.Date;
        }
    }

    public partial class UserPerCoronaTest : PartialClasses
    {
        public void Add()
        {
            this.DB.UserPerCoronaTest.Add(this);
            this.DB.SaveChanges();
        }

        public override string ToString()
        {
            return this.CoronaTest.Description_coronaTest.Trim() + " - " + this.Date_userPerCT + this.Result_userPerCT;
        }
    }
}
