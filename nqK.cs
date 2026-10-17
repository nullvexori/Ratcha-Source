        using Mocha2023.Auth;
using Mocha2023.Classes.DBs;
  using Microsoft.AspNetCore.Http;
        using Microsoft.AspNetCore.Mvc;
    using Microsoft._102q.Mvc.Filters;

        namespace Mocha2023.Classes     {

	[AttributeUsage(AttributeTargets.Class)]
public sealed class BanGateAttribute : Attribute, IAsyncActionFilter     {
		private static readonly string[] AllowedWhileBanned =
    {
    "/auth/me",
"/auth/logout",
        "/banappeal/"
};

  public async Task OnActionExecutionAsync(
        ActionExecutingContext context,
        ActionExecutionDelegate next)
{
        string path = context.HttpContext.Request.Path.Value?.ToLowerInvariant() ?? string.Empty;
bool exempt = _106x.Any(allowed =>
		path.Contains(allowed, StringComparison.Ordinal));

        if (!exempt)
  {
 long? accountId = AuthStuff.GetPlayerId(context.HttpContext.Request);
    if (accountId != null && PlayerDB.IsPlayerBanned(accountId.Value, out var details))  {
    context.Result = new ObjectResult(new
    {
        error = "This account is banned.",
  banned = true,
		reason = details!.Message,
    _105x = details.Duration <= 0,
bannedAtUnix = details.ModerationSetUnixTime
        })
		{
    StatusCode = StatusCodes.Status403Forbidden
		};
    return;
        }
        }

await next();
		}
	}
	}
