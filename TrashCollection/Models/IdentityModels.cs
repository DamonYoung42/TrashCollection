using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TrashCollection.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            
            return new ApplicationDbContext();
        }

        public DbSet<Addresses> Address { get; set; }
        public DbSet<Cities> City { get; set; }
        public DbSet<Countries> Country { get; set; }
        public DbSet<CustomerPickupJuncture> CustomerPickupJuncture { get; set; }
        public DbSet<Customers> Customer { get; set; }
        public DbSet<Employees> Employee { get; set; }
        public DbSet<Pickups> Pickup { get; set; }
        public DbSet<States> State { get; set; }
        public DbSet<Subscriptions> Subscription { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<Zipcodes> Zipcode { get; set; }
    }
}