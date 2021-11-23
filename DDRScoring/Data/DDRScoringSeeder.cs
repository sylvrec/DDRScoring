using DDRScoring.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data
{
    public class DDRScoringSeeder
    {
        private readonly DDRScoringContext _ctx;
        private readonly IWebHostEnvironment _env;
        private readonly UserManager<StoreUser> _userManager;

        public DDRScoringSeeder(DDRScoringContext ctx, IWebHostEnvironment env, UserManager<StoreUser> userManager)
        {
            _ctx = ctx;
            _env = env;
            _userManager = userManager;
        }

        public async Task SeedAsync()
        {
            _ctx.Database.EnsureCreated();
            var user = await _userManager.FindByEmailAsync("contact@sylvrec.com");
            if (user == null)
            {
                user = new StoreUser()
                {
                    UserName = "sylvrec",
                    Email = "contact@sylvrec.com"
                };
                var result = await _userManager.CreateAsync(user, "P@$$w0rd!");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create new user in seeder");
                }
            }

        }
    }
}
