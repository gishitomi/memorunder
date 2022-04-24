using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using memorunder.Controllers.Base;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace memorunder.Controllers
{
  public class MemoController : Controller
  {
    // GET: /<controller>/
    //メモ一覧画面
    public IActionResult Index()
    {
      return View();
    }
  }
}
