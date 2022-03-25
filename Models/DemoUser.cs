
using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcuERP_Demo.Models;

/// <summary>
///     Add profile data for application users by adding properties to the ApiDemoUser class
/// </summary>
public class DemoUser : IdentityUser
{
    [PersonalData]
    public string Name { get; set; } = String.Empty;

    [PersonalData]
    [DataType(DataType.Date)]
    public DateTime? DOB { get; set; }

}

