using Hackerspace.Shared.Interfaces;
using Hackerspace.Shared.Models;

namespace RussComp5.Data.Mocks
{
    public class BadgesPageServiceMock : IBadgesPageDataService
    {
        private List<Badge> _badges = new List<Badge>()
        {
            new Badge
            {
                Id = Guid.NewGuid(),
                Title = "Beginner Hacker",
                Description = "Awarded for completing the beginner hacking course.",
                TurnInInstructions = "Submit your course completion certificate.",
                IsVisible = true
            },
            new Badge
            {
                Id = Guid.NewGuid(),
                Title = "Security Expert",
                Description = "Awarded for demonstrating advanced security skills.",
                TurnInInstructions = "Submit a report on your security project.",
                IsVisible = false
            },
            new Badge
            {
                Id = Guid.NewGuid(),
                Title = "Code Contributor",
                Description = "Awarded for contributing to open-source projects.",
                TurnInInstructions = "Submit your GitHub profile link.",
                IsVisible = true
            },
            new Badge
            {
                Id = Guid.NewGuid(),
                Title = "Bug Hunter",
                Description = "Awarded for finding and reporting bugs.",
                TurnInInstructions = "Submit your bug report.",
                IsVisible = false
            },
            new Badge
            {
                Id = Guid.NewGuid(),
                Title = "Community Helper",
                Description = "Awarded for helping others in the community.",
                TurnInInstructions = "Submit testimonials from community members.",
                IsVisible = true
            }
        };


        public Task<List<Badge>> GetAllAsync()
        {
            return Task.FromResult(_badges);
        }
    }
}