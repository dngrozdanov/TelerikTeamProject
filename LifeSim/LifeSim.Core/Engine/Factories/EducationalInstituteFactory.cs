﻿using LifeSim.Core.Engine.Factories.Contracts;
using LifeSim.Establishments.Education.Models.HighSchool.Contracts;
using LifeSim.Establishments.Education.Models.HighSchool.Models;
using LifeSim.Establishments.Education.Models.KinderGarten.Contracts;
using LifeSim.Establishments.Education.Models.KinderGarten.Models;
using LifeSim.Establishments.Education.Models.PrimarySchool.Contracts;
using LifeSim.Establishments.Education.Models.PrimarySchool.Models;
using LifeSim.Establishments.Education.Models.University.Contracts;
using LifeSim.Establishments.Education.Models.University.Models;

namespace LifeSim.Core.Engine.Factories
{
    public class EducationalInstituteFactory : IEducationalInstituteFactory
    {
        public IHighSchool CreateHighSchool(string name, int startYear)
        {
            return new HighSchool(name, startYear);
        }

        public IKinderGarten CreateKinderGarten(string name, int startYear)
        {
            return new KinderGarten(name, startYear);
        }

        public IPrimarySchool CreatePrimarySchool(string name, int startYear)
        {
            return new PrimarySchool(name, startYear);
        }

        public IUniversity CreateUniversity(string name, int startYear)
        {
            return new University(name, startYear);
        }
    }
}