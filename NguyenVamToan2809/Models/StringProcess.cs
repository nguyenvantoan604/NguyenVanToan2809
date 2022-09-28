using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace NguyenVamToan2809.Models
{
    public class StringProcess 
    {
        //xoa bo khoang trang
        public string Whitespace(string strInput)
        {
            string sent = "";

            strInput = strInput.Trim();
            
            int index =  strInput.IndexOf("  ");

            while(strInput.IndexOf("  ") > 0)
            {
                strInput = strInput.Replace("  ", " ");
            }
            sent = strInput;
            return sent;
        }
        //viet hoa chuoi
        public string LowerToUpper(string strInput)
        {
            string sent2 = "";
            strInput = strInput.ToUpper();
            sent2 = strInput;
            return sent2;
        }
        // viet thuong chuoi
        public string UpperToLower(string strInput)
        {
            string sent3 = "";
            strInput = strInput.ToLower();
            sent3 = strInput;
            return sent3;
        }
        //viet hoa ki tu dau tien
        public string CapitalizeOneFirstCharacter(string strInput)
        {
            string sent4 = "";
            string strInput1 = strInput.Substring(0,1);
            string strInput2 = strInput.Substring(1);
            strInput1 = strInput1.ToUpper();
            strInput = strInput1 + strInput2;
            sent4 = strInput;
            return sent4;
        }

        //bo dau tieng viet
       
        public string RemoveVietnameseAccents(string strInput)
        {
            string sent5 = "";
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                strInput = strInput.Replace(arr1[i], arr2[i]);
                strInput = strInput.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            sent5 = strInput;


            return sent5;
         
        }



    }
}
