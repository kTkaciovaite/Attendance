using Microsoft.Owin;
using Owin;
using Attendance.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

[assembly: OwinStartupAttribute(typeof(Attendance.Startup))]
namespace Attendance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            _createRolesAndUsers();
        }

        private void _createRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole
                {
                    Name = "Admin"
                };
                roleManager.Create(role);

                var user = new ApplicationUser
                {
                    UserName = "karolina.tkaciovaite",
                    Email = "karolina.tkaciovaite@gmail.com"
                };

                string userPWD = "Abcd.1234";

                var userChecker = UserManager.Create(user, userPWD);
    
                if (userChecker.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");

                }
            }
   
            if (!roleManager.RoleExists("Manager"))
            {
                var role = new IdentityRole
                {
                    Name = "Manager"
                };
                roleManager.Create(role);
            }
   
            if (!roleManager.RoleExists("Lecturer"))
            {
                var role = new IdentityRole
                {
                    Name = "Lecturer"
                };
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("Student"))
            {
                var role = new IdentityRole
                {
                    Name = "Student"
                };
                roleManager.Create(role);
            }
        }
    }
}
