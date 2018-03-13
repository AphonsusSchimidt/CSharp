using System;
using System.Net;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;
namespace DownloadVideoOnYt
{
    class LinkYoutube
    {
        public string URL { get; set; }
        public string ChatLuong { get; set; }
        public string DinhDang { get; set; }
        public string Itag { get; set; }

        public override string ToString()
        {
            return DinhDang + " (" + ChatLuong + ")";
        }

        public string getExt()
        {
            return DinhDang.Substring(DinhDang.IndexOf("/") + 1);
        }
    }

    class YoutubeHelper
    {
        public IList<LinkYoutube> ListUrlVideo { get; set; }

        public string Html { get; set; }
        public string TieuDe { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }


        public YoutubeHelper()
        {

        }


        /// <summary>
        ///  Phân tích html và lấy link
        /// </summary>
        /// <param name="url"></param>
        public void KhoiTao(string url)
        {
            using (var _client = new WebClient())
            {

                _client.Encoding = System.Text.Encoding.UTF8;
                Html = _client.DownloadString(url);

                /****************************************************
                 * LẤY THÔNG TIN URL VIDEO
                 * **************************************************/

                //Giờ mình cắt lấy chuỗi sau url_encoded_fmt_stream_map
                Regex regStreamMap = new Regex("url_encoded_fmt_stream_map(.*?)\",");
                Match m = regStreamMap.Match(Html);
                if (!m.Success) throw new Exception("Video không tồn tại!");
                //Lấy giá trị đoạn script của youtube player
                string strStreamMap = m.Groups[1].Value;
                //decode url để tiện trích xuất dữ liệu cần
                strStreamMap = Regex.Unescape(strStreamMap);
                strStreamMap = HttpUtility.UrlDecode(strStreamMap);

                //Đoạn thông tin chứa độ phân giải của video
                string strFmt = new Regex("\"fmt_list\":\"(.*?)\"").Match(Html).Groups[1].Value;

                //Lọc lấy từng link video
                Regex regUrl = new Regex("url=(.*?)(;|,|\\z)");
                MatchCollection arrM = regUrl.Matches(strStreamMap);
                ListUrlVideo = new List<LinkYoutube>();
                foreach (Match item in arrM)
                {
                    LinkYoutube obj = new LinkYoutube();
                    obj.URL = HttpUtility.UrlDecode(item.Groups[1].Value);
                    obj.DinhDang = new Regex("mime=(.*?)(&|\\z)").Match(obj.URL).Groups[1].Value;
                    obj.Itag = new Regex("itag=(\\d+)(&|\\z)").Match(obj.URL).Groups[1].Value;
                    obj.ChatLuong = new Regex(obj.Itag + "\\\\\\/(\\d+x\\d+)").Match(strFmt).Groups[1].Value;
                    ListUrlVideo.Add(obj);
                }


                /****************************************************
                 * LẤY TIÊU ĐỀ, HÌNH ẢNH VÀ MÔ TẢ VIDEO
                 * **************************************************/
                TieuDe = new Regex("<meta property=\"og:title\" content=\"(.*?)\"").Match(Html).Groups[1].Value;
                MoTa = new Regex("<meta property=\"og:description\" content=\"(.*?)\"").Match(Html).Groups[1].Value;
                HinhAnh = new Regex("<meta property=\"og:image\" content=\"(.*?)\"").Match(Html).Groups[1].Value;
            }

        }
    }
}
