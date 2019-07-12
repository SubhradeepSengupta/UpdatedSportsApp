using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsApplication.Models;
using SportsApplication.ViewModel;

namespace SportsApplication.Controllers
{
    public class SportsApplicationController : Controller
    {
        private readonly SportsDbContext _context;
        private static int TestID;

        public SportsApplicationController(SportsDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            var testType = _context.TestTypeMappers.Include(t=>t.Test.UserTestMappers).Include(t => t.Test).ThenInclude(t => t.TestTypeMapper.TestType);
            return View(testType);
        }

        public IActionResult CreateTest()
        {
            var TestType = _context.TestTypes.ToList();
            return View(TestType);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestAsync([FromForm] TestViewModel test)
        {
            TestType TestTypes = await _context.TestTypes.FirstOrDefaultAsync(t => t.Name == test.TestType);
            TestTypeMapper TestType = new TestTypeMapper();
            Test Tests = new Test();

            if (ModelState.IsValid)
            {
                Tests.Date = test.Date;
                _context.Tests.Add(Tests);
                TestType.TestID = Tests.ID;
                TestType.TestTypeID = TestTypes.ID;
                _context.TestTypeMappers.Add(TestType);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> TestDetails(int id)
        {
            TestID = id;
            var test = await _context.TestTypeMappers.Include(t => t.Test).ThenInclude(t => t.TestTypeMapper.TestType).Where(t => t.TestID == id).ToListAsync();
            var Athletes = await _context.UserTestMappers.Include(t=>t.User).Include(t => t.Test).ThenInclude(t => t.TestTypeMapper.TestType).Where(t => t.TestID == id).ToListAsync();

            return View(Tuple.Create(test,Athletes));
        }

        public async Task<IActionResult> DeleteTestAsync()
        {
            var tests = await _context.Tests.FindAsync(TestID);
            _context.Tests.Remove(tests);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> AddAthleteAsync()
        {
            var Users = await _context.Users.Where(u => u.Role.Equals(UserRole.Athlete)).ToListAsync();
            return View("AddAthlete", Users);
        }

        [HttpPost]
        public async Task<IActionResult> AddAthleteAsync([FromForm] AthleteViewModel athlete)
        {
            UserTestMapper UserTest = new UserTestMapper();
            var Tests = await _context.Tests.FirstOrDefaultAsync(t => t.ID == TestID);
            var Users = _context.Users.Where(u => u.Name == athlete.Name);

            UserTest.TestID = Tests.ID;
            foreach (User user in Users)
            {
                UserTest.UserID = user.ID;
            }
            UserTest.CooperTestDistance = athlete.Distance;
            UserTest.FitnessRating = CalculateFitness(athlete.Distance);

            _context.UserTestMappers.Add(UserTest);
            await _context.SaveChangesAsync();

            return RedirectToAction("TestDetails", new { id = TestID } );
        }

        private string CalculateFitness(double distance)
        {
            if (distance <= 1000)
            {
                return "Below Average";
            }
            else if (distance > 1000 && distance <= 2000)
            {
                return "Average";
            }
            else if (distance > 2000 && distance <= 3500)
            {
                return "Good";
            }
            else if (distance > 3500)
            {
                return "Very Good";
            }
            return " ";
        }
    }
}