﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Numerics;


namespace ClassAssignmentApp.Models
{
    [Keyless]
    public class WorkingDailySchedule
    {
        public int StudentClassSessionID { get; set; }
        public int ClassSessionID { get; set; }
        public int InstructorID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int BuildingNumber { get; set; }
        public int RoomNumber { get; set; }
        public string Title { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public string DayOfWeek { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
    }
}
