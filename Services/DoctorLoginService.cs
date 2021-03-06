using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using ClinicManagementProject.Models;

namespace ClinicManagementProject.Services
{
    public class DoctorLoginService : ILoginService<DoctorViewModel, string>
    {
        public DoctorLoginService()
        {
        }
        private IRepo<Doctor, string> _repoDoc;
        //private IRepo<DoctorSchedule, string> _repoSch;
        private IScheduleD<DoctorSchedule, string> _repoSch;

        public DoctorLoginService(IScheduleD<DoctorSchedule, string> doctorSchRepo, IRepo<Doctor, string> doctorRepo) //didnt add logger. ok?....dont need context, as its in adminrepo alr
        {
            _repoDoc = doctorRepo;
            _repoSch = doctorSchRepo;

        }

        public bool Login(DoctorViewModel t)
        {
            var doc = _repoDoc.Get(t.Username);//getting doc in admins table with username same as adminviewmodel t
            if (doc != null)
            {
                using var hmac = new HMACSHA512(doc.PasswordSalt); //using doc passwordsalt as salt for keyed in admin
                var checkPass = hmac.ComputeHash(Encoding.UTF8.GetBytes(t.EnteredPassword));//encrypting into byte[] for keyed in password in login field...
                //checking if the byte[] of doc is the same as the byte[] of admin
                for (int i = 0; i < checkPass.Length; i++)
                {
                    if (checkPass[i] != doc.Password[i])
                    {
                        return false; //password wrong


                    }
                }

                return true; //return to adminconsole

            }
            else
                //    ViewData["Message"] = "Invalid Username or Password";
                //return View();//remain to same login page, and display invalid username or password
                return false; //wrong username, not found
        }

        public bool Register(DoctorViewModel t)
        {
            if (t.EnteredPassword == t.RetypeEnteredPassword && t.Username != null)//checking if patientviewmodel is entered correctly (includes inherited class of patient too)...with all the validations.eg. making sure required fields are keyed in, also checking through if password matches or not, else it will give exceptions
            {
                Doctor myDoctor = t;
                ICollection<Doctor> doctors = _repoDoc.GetAll();
                //encrypting password
                using var hmac = new HMACSHA512();
                myDoctor.Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(t.EnteredPassword)); //encrypting keyed in password as password to myPatient.Password, with key
                myDoctor.PasswordSalt = hmac.Key;

                //checking if username taken or not in patients
                bool usertaken = false;
                foreach (var item in doctors)
                {
                    if (t.Username.ToLower() == item.Username.ToLower())//have to compare using lower as sql is case sensitive, will give fk error
                    {
                        usertaken = true;
                    }
                }
                if (usertaken == true)
                {
                    //ViewBag.Message = "Username taken, please use another";
                    //return View();
                    return false; //username taken
                }
                else
                {
                    _repoDoc.Add(myDoctor);  //with the password and passwordsalt added too
                    return true; //username ok, created
                }
            }
            //ViewBag.Message = "Please fill in all the fields accordingly";
            return false; //modelstate invalid, fill in properly
        }

        public bool AddSchedule(DoctorScheduleViewModel t)
        {
            DoctorSchedule sch = t;
            ICollection<DoctorSchedule> schedules = _repoSch.GetAll();
            bool timetaken = false;
            foreach (var item in schedules)
            {
                if (t.Time == item.Time)
                    timetaken = true;
            }
            if (timetaken == true)
                return false;
            else
            { 
                _repoSch.Add(sch);
                return true;
            }
        }


    }
}
