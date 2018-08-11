﻿using LifeSim.Establishments.Education.University.Contracts;

namespace LifeSim.Establishments.Education.University
{
    public class University : EducationalInstitute, IUniversity
    {
        public University(string name, int startYear, int graduateYear) : base(name, startYear, graduateYear)
        {
        }
    }
}