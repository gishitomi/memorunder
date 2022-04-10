namespace memorunder.Models
{
    public class Diary
    {
        public string[] CreateCalendar()
        {
            DateTime today = DateTime.Today;

            //現在の月を取得
            String ym = today.ToString("yyyy-MM");


            //該当月の日数を取得
            int dayCount = DateTime.DaysInMonth(today.Year, today.Month);
            //月初め1日の曜日を取得 日:0 ~ 土:6
            DateTime firstDay = new DateTime(today.Year, today.Month, 1);
            DayOfWeek dow = firstDay.DayOfWeek;
            int youbi = (int)dow;

            //カレンダー作成の準備
            //string[] weeks;
            var weeks = new List<string>();
            string week = "";

            //一週目のセルの追加
            // 例）１日が火曜日だった場合、日・月曜日の２つ分の空セルを追加する
            for (int i = 0; i < youbi; i++)
            {
                week += "<td></td>";
            }

            String date = "";

            for (int day = 1; day <= dayCount; day++)
            {
                date = ym + "-" + String.Format("{0:D2}", day);
                if (date == today.ToString("yyyy-MM-dd"))
                {
                    week += "<td class='today'>" + day.ToString();
                }
                else
                {
                    week += "<td>" + day.ToString();
                }
                week += "</td>";

                //週終わり、または月終わりの場合
                if (youbi % 7 == 6 || day == dayCount)
                {
                    if (day == dayCount)
                    {
                        // 月の最終日の場合、空セルを追加
                        // 例）最終日が水曜日の場合、木・金・土曜日の空セルを追加
                        int restYoubi = 6 - youbi;
                        for (int i = 0; i < restYoubi; i++)
                        {
                            week += "<td></td>";
                        }
                    }
                    //weeks配列にweekを追加する
                    //weeks.Add("<tr>" + week + "</tr>");
                    weeks.Add(week);
                    //weekをリセット
                    week = "";
                }

                youbi++;
            }

            return weeks.ToArray();
        }
    }
}
