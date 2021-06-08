using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context = context;
        }
        // get request for all activities url/api/activities
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _context.Activities.ToListAsync();
        }
        // get request for a specific activity url/api/activities/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }
    }
}