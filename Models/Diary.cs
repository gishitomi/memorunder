namespace memorunder.Models
{
    public class Diary
    {
      //ID
      public string? id { get; set; }

      //タイトル
      public string? title { get; set; }

      //見出し画像
      public string? top_image { get; set; }

      //テキスト
      public string? diary_text { get; set; }

      //ユーザID
      public string? user_id { get; set; }
    }
}
