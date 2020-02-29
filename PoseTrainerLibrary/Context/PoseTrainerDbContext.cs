using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PoseTrainerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoseTrainerLibrary.Context
{
    public class PoseTrainerDbContext : IdentityDbContext<User>
    { 
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<History> Histories { get; set; }

        public PoseTrainerDbContext(DbContextOptions options) : base(options) { }

        public PoseTrainerDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(user => user.Id);
            });

            modelBuilder.Entity<Exercise>(entity =>
            {
                entity.HasKey(exercise => exercise.Id);
            });

            modelBuilder.Entity<Exercise>().HasData(
                new Exercise
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Extensii pentru biceps",
                    Difficulty = "Medium",
                    Script = "js/bicepCurl.js"
                },
                new Exercise
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Ridicări laterale cu greutăți",
                    Difficulty = "Medium",
                    Script = "js/lateralRaise.js"
                }
            );

            modelBuilder.Entity<History>(entity =>
            {
                entity.HasKey(history => new { history.UserId, history.ExerciseId });

                entity.HasOne(history => history.User)
                      .WithMany(user => user.Histories)
                      .HasForeignKey(history => history.UserId);

                entity.HasOne(history => history.Exercise)
                      .WithMany(user => user.Histories)
                      .HasForeignKey(history => history.ExerciseId);
            });
        }
    }
}
