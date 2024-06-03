using Microsoft.AspNetCore.Builder;
using ApiGateway;
using ApiGateway.Extensions;

var builder = WebApplication.CreateBuilder(args)
    .ConfigureAppConfiguration()
    .UseStartup<Startup>();