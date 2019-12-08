using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MVCIdentity.Models;

[assembly: OwinStartupAttribute(typeof(MVCIdentity.Startup))]
namespace MVCIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesandUsers();
        }

        private void CreateRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if(!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                var user = new ApplicationUser();
                user.UserName = "Jahanzeb";
                user.Email = "jahanzeb.naeem@hotmail.com";

                string userPwd = "J@Z201908";

                var chkUsr = UserManager.Create(user, userPwd);

                if(chkUsr.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");
                }
            }

            if (!roleManager.RoleExists("Cashier"))
            {
                var role = new IdentityRole();
                role.Name = "Cashier";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("SalesPerson"))
            {
                var role = new IdentityRole();
                role.Name = "SalesPerson";
                roleManager.Create(role);
            }
        }
    }
}
