using BAL;
using dallibrary;
using EndProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EndProject.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values

        // GET api/<controller>
        DAL obj = null;
        public ValuesController()
        {
            obj = new DAL();
        }

        //[Route("GetAllEmps")]
        [HttpGet]
        public List<empModel> Get()
        {
            //return new string[] { "value1", "value2" };

            List<EmpProfiles> empbal = new List<EmpProfiles>(); empbal = obj.GetCustomers();
            List<empModel> emps = new List<empModel>();
            foreach (var item in empbal)
            {
                //Employees emp = new Employees();
                emps.Add(new empModel
                {
                    EmpCode = item.EmpCode,
                    Email = item.Email,
                    EmpName = item.EmpName,
                    //    DateOfBirth = item.DateOfBirth,
                    DeptCode = item.DeptCode
                });
            }
            return emps;

        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] empModel empdata)
        {
            EmpProfiles empbal = new EmpProfiles();
            empbal.EmpCode = empdata.EmpCode;
            empbal.Email = empdata.Email;
            empbal.EmpName = empdata.EmpName;
            empbal.DeptCode = empdata.DeptCode;



            obj.Insertcustomer(empbal);


        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody] empModel empdata)
        {

            EmpProfiles empbal = new EmpProfiles();
            empbal.EmpCode = empdata.EmpCode;
            empbal.Email = empdata.Email;
            empbal.EmpName = empdata.EmpName;
            empbal.DeptCode = empdata.DeptCode;

            obj.UpdateCustomer(empbal);

        }


        // DELETE api/values/5
        public void Delete(int id)
        {

            obj.Remove(id);


        }
        [Route("FindById/{id:int?}")]
        public empModel GetMarkByID(int id)
        {
            EmpProfiles empbal = new EmpProfiles();
            empbal = obj.search(id);
            empModel emp = new empModel();

            emp.EmpCode = id;
            emp.EmpName = empbal.EmpName;
            emp.Email = empbal.Email;
            emp.DeptCode = empbal.DeptCode;


            return emp;

        }



    }
}
