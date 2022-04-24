using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using memorunder.Controllers.Base;
using Dapper;
using MySql.Data.MySqlClient;
using memorunder.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace memorunder.Controllers
{
  public class DiaryController : Controller
  {
    // GET: /<controller>/
    //トップページ（日記一覧画面）
    public IActionResult Index()
    {
        //現在の月を取得
        DateTime today = DateTime.Now;
        ViewBag.month = today.Month;

        //DB接続
        using (var dbConn = new MySqlConnection("server=localhost;database=memorunder;uid=root;pwd=yg04281215"))
            {
                dbConn.Open();

                var sql = "SELECT name FROM users";

                var users = dbConn.Query<User>(sql);
            }



        return View();
    }

    //日記作成画面
    public IActionResult Create()
        {
            return View();
        }
  }
}
