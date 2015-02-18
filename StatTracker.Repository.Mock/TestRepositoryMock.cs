using System;
using System.Collections.Generic;
using StatTracker.Domain.Objects;
using StatTracker.Repository.Interfaces;

namespace StatTracker.Repository.Mock
{
    public class TestRepositoryMock : ITestRepository
    {
        public IEnumerable<Test> GetTestData()
        {
            return new List<Test>
            {
                new Test
                {
                    FirstName = "Curtis",
                    LastName = "Lofton",
                    Number = 50,
                    StartDate = new DateTime(2012, 1, 5)
                },
                new Test
                {
                    FirstName = "Ed",
                    LastName = "Reed",
                    Number = 38,
                    StartDate = new DateTime(2013, 4, 8)
                },
                new Test
                {
                    FirstName = "Ray",
                    LastName = "Lewis",
                    Number = 52,
                    StartDate = new DateTime(2001, 11, 18)
                },
                new Test
                {
                    FirstName = "Richard",
                    LastName = "Sherman",
                    Number = 19,
                    StartDate = new DateTime(2010, 10, 15)
                },
                new Test
                {
                    FirstName = "Tim",
                    LastName = "Jennings",
                    Number = 27,
                    StartDate = new DateTime(2004, 12, 10)
                },
                new Test
                {
                    FirstName = "J.J.",
                    LastName = "Watt",
                    Number = 78,
                    StartDate = new DateTime(2011, 5, 9)
                },
                new Test
                {
                    FirstName = "Barry",
                    LastName = "Church",
                    Number = 27,
                    StartDate = new DateTime(2013, 5, 14)
                },
                new Test
                {
                    FirstName = "Nick",
                    LastName = "Roach",
                    Number = 50,
                    StartDate = new DateTime(2006, 8, 22)
                }
            };
        }
    }
}