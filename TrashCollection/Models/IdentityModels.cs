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

        public virtual DbSet<Addresses> Address { get; set; }
        public virtual DbSet<Cities> City { get; set; }
        public virtual DbSet<Countries> Country { get; set; }
        public virtual DbSet<CustomerPickupJuncture> CustomerPickupJuncture { get; set; }
        public virtual DbSet<Customers> Customer { get; set; }
        public virtual DbSet<Employees> Employee { get; set; }
        public virtual DbSet<Pickups> Pickup { get; set; }
        public virtual DbSet<States> State { get; set; }
        public virtual DbSet<Subscriptions> Subscription { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<Zipcodes> Zipcode { get; set; }
    }
}