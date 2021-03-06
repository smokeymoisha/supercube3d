﻿using SuperCube3D_DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCube3D_DAL
{
    public class CustomInitializer : CreateDatabaseIfNotExists<SuperCubeContext>
    {
        protected override void Seed(SuperCubeContext context)
        {
            var achievements = new List<Achievement>
            {
                new Achievement
                {
                    Id = 1,
                    Title = "Regular Visitor",
                    Description = "Successfully login to your account 3 times."
                },
                new Achievement
                {
                    Id = 2,
                    Title = "SuperCube 3000",
                    Description = "Get 3000 points in a single SuperCube run."
                },
                new Achievement
                {
                    Id = 3,
                    Title = "The Best of the Best",
                    Description = "Reach the top spot on the leaderboard!"
                },
                new Achievement
                {
                    Id = 4,
                    Title = "SuperCube 5000",
                    Description = "Get 5000 points in a single SuperCube run."
                },
                new Achievement
                {
                    Id = 5,
                    Title = "Welcome!",
                    Description = "Play SuperCube for the first time."
                }
            };

            context.Achievements.AddRange(achievements);

            context.SaveChanges();
        }
    }
}
