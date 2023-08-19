using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Areas.Admin.Controllers
{
	[Authorize]
	[Area("Admin")]
	public class AdminBaseController : Controller { }
}
