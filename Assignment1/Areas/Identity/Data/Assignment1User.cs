using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;
using Microsoft.AspNetCore.Identity;

namespace Assignment1.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Assignment1User class
public class Assignment1User : IdentityUser
{
    public static object Books { get; internal set; }
    public DateTime? DoB { get; set; }
    public string? Address { get; set; }
    public Store? Store { get; set; }
    public virtual ICollection<Order>? Orders { get; set; }
    public virtual ICollection<Cart>? Carts { get; set; }
}

