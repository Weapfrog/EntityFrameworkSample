﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSample.Core.Model.Entity
{
    public class Grade
    {
        public int GradeID { get; set; }
        public int StudentID { get; set; }
        public int LectureID { get; set; }
        public int Grade1 { get; set; }
        public int Grade2 { get; set; }
        public int Average { get; set; }
        public bool StudentState { get; set; }
    }
}
