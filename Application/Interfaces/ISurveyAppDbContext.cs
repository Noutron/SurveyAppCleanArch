using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces;

public interface ISurveyAppDbContext
{
     DbSet<Domain.Models.Survey> Surveys { get; set; }
     DbSet<Option> Options { get; set; }
     DbSet<Vote> Votes { get; set; }
     
     Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
}