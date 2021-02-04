﻿using System.Collections.Generic;
using WebAPI.Models.Attributes;
using WebAPI.Models.DTO;
using WebAPI.Models.Interfaces.DAO;

namespace WebAPI.Models.DAO
{
    [AutoInject]
    public class Student_DAO: IStudent_DAO
    {

        private readonly List<Student> _StudentList;

        public Student_DAO()
        {
            _StudentList = new List<Student>();
        }

        public List<Student> GetAll()
        {
            List<Student> StudentList = new List<Student>();

            StudentList.Add( new Student{ID=1,Name="張三",Age=19 });

            StudentList.Add( new Student{ID=2,Name="李四",Age=20 });

            return StudentList;
        }

        public void Create(Student item)
        {
            _StudentList.Add(item);
        }

    }
}
