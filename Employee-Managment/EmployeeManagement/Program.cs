using EmployeeManagement.Models;
using EmployeeManagement.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NLog.Web;
using NLog;

var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Debug("init main");

try
{


    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddDbContextPool<AppDbContext>(
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeDBConnection")));

    builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
        {
            // Default Password settings.
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = true;
            options.Password.RequiredLength = 6;
            options.Password.RequiredUniqueChars = 1;
        })
        .AddEntityFrameworkStores<AppDbContext>();

    builder.Services.Configure<IdentityOptions>(options =>
        {
            // Default Password settings.
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = true;
            options.Password.RequiredLength = 6;
            options.Password.RequiredUniqueChars = 1;
        });

    builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
    builder.Services.AddMvc(option =>
        {
            var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();

            option.Filters.Add(new AuthorizeFilter(policy));
        }
        ).AddXmlSerializerFormatters();

    builder.Services.AddAuthentication().AddGoogle(googleOptions =>
    {
        googleOptions.ClientId = "414450217003-75fl223a2v18b5cdf2lvb0i34cjchq3c.apps.googleusercontent.com";
        googleOptions.ClientSecret = "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";
    });

    builder.Services.ConfigureApplicationCookie(options =>
    {
        options.AccessDeniedPath = new PathString("/Administration/AccessDenied");
    });



    // User Authorization claims

    builder.Services.AddAuthorization(options =>
    {
        options.AddPolicy("DeleteRolePolicy",
            policy => policy.RequireClaim("Delete Role","true"));
    });

    builder.Services.AddAuthorization(options =>
    {
        options.AddPolicy("EditRolePolicy", policy =>
            policy.AddRequirements(new ManageAdminRolesAndClaimsRequirement()));
    });


    builder.Services.AddAuthorization(options =>
    {
        options.AddPolicy("EditRolePolicy",
            policy => policy.RequireClaim("Edit Role","true"));
    });

    bool AuthorizeAccess(AuthorizationHandlerContext context)
    {
        return context.User.IsInRole("Admin") &&
               context.User.HasClaim(claim => claim.Type == "Edit Role" && claim.Value == "true") ||
               context.User.IsInRole("Super Admin");
    }

    builder.Services.AddAuthorization(options =>
    {
        options.AddPolicy("AdminRolePolicy", policy => policy.RequireRole("Admin"));
    });


    builder.Services.AddSingleton<IAuthorizationHandler, CanEditOnlyOtherAdminRolesAndClaimsHandler>();
    builder.Services.AddSingleton<IAuthorizationHandler, SuperAdminHandler>();
    builder.Services.AddScoped<IEmployeeRepository, SqlEmployeeRepository>();

    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    var app = builder.Build();

    if (builder.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    else
    {
        app.UseExceptionHandler("/Error");
        app.UseStatusCodePagesWithReExecute("/Error/{0}");
    }

    app.UseStaticFiles();

    app.UseAuthentication();
    app.UseAuthorization();
  
    app.UseRouting();


    app.UseMvc(routes =>
        routes.MapRoute("default", "{controller=Home}/{action=index}/{id?}")
        );
    app.MapGet("/", () => "Hello world");
    app.Run();
}
catch (Exception exception)
{
    // NLog: catch setup errors
    logger.Error(exception, "Stopped program because of exception");
    throw;
}
finally
{
    // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
    NLog.LogManager.Shutdown();
}
