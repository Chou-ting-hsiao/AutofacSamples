﻿using System.Collections.Generic;
using System.Linq;
using WebAPI.Core.Attributes;
using WebAPI.Core.DTO;
using WebAPI.Core.Interfaces.BLO;
using WebAPI.Core.Interfaces.DAO;

namespace WebAPI.Core.DAO
{
    [AutoInject]
    public class CourseSelect_BLO : ICourseSelect_BLO
    {

        private readonly ICourse_DAO _Course_DAO;
        private readonly IStudent_DAO _Student_DAO;

        public CourseSelect_BLO(ICourse_DAO Course_DAO,
                                IStudent_DAO Student_DAO)
        {
            _Course_DAO = Course_DAO;
            _Student_DAO = Student_DAO;
        }

        public List<Course> GetAllCourse()
        {
            return _Course_DAO.GetAll();
        }

        public List<Student> GetAllStudent()
        {
            return _Student_DAO.GetAll();
        }
        
        public string Select(Course item)
        {
            List<Course> Course_Select = _Course_DAO.GetAll().Where(x => x.StudentID == item.StudentID).ToList();

            if (Course_Select.Any(x => x.CourseID == item.CourseID))
            {
                return "Course Cant Select Twice";
            }

            _Course_DAO.Create(item);

            return "Course Select Success";
        }

    }
}
