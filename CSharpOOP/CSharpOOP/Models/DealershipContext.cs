using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CSharpOOP.Models
{
    // Inheriting from Dbcontext provides us most of the functionality. The rest of the fileis customizing to suit our database. 
    public partial class DealershipContext : DbContext
    {
    
    }
}
