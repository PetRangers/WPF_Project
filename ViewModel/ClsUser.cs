using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Windows;

namespace ViewModel
{
    public class UserViewModel
    {
        //記錄目前使用者的靜態欄位
        public static string CurrentUser;

        //建立登錄使用者的方法。
        public static RegisterErrorTypes CreateUser(string userName, string password, string password2, string email, string firstname, string lastname, string mobile, Image profilePic)
        {
            //確認資訊填寫完整程度。
            if (userName == "") { return RegisterErrorTypes.LackOfUsername; }
            if (email == "") { return RegisterErrorTypes.LackOfEmail; }
            if (password == "") { return RegisterErrorTypes.LackOfPassword; }
            if (password != password2) { return RegisterErrorTypes.InconsistentPassword; }

            Model.WPF_ProjectDBEntities db = new Model.WPF_ProjectDBEntities();

            //確認DataEntity中是否已存在相同帳號。
            foreach (Model.UserInformation u in db.UserInformations)
            {
                if (u.Username == userName)
                { return RegisterErrorTypes.DuplicatedUsername; }
                if (u.email == email)
                { return RegisterErrorTypes.DuplicateEmail; }
            }

            //用RNGCryptoServiceProvider產生隨機salt，加到cmd的參數中
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] salt = new byte[32];
            rng.GetBytes(salt);

            //將password加上salt後進行加密
            byte[] bytesPassword = Encoding.Unicode.GetBytes(password + Encoding.Unicode.GetString(salt));
            SHA256Managed Algorism = new SHA256Managed();
            byte[] hashedPassword = Algorism.ComputeHash(bytesPassword);

            //將Image轉為byte[]
            MemoryStream ms = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create((BitmapSource)profilePic.Source));
            encoder.Save(ms);
            byte[] imgData = ms.ToArray();
            ms.Close();

            //經多重檢查無誤後，將帳號資訊登錄於DataEntity中。
            Model.UserInformation m = new Model.UserInformation
            {
                Username = userName,
                Password = hashedPassword,
                email = email,
                salt = salt,
                RegistrationDate = DateTime.Now,
                Firstname = firstname,
                Lastname = lastname,
                mobile = mobile,
                Photo = imgData,
                UserType = "normal"
            };
           
            db.UserInformations.Add(m);
            db.SaveChanges();

            return RegisterErrorTypes.SuccessfulRegistration;
        }

        public enum RegisterErrorTypes
        {
            SuccessfulRegistration = 0,
            LackOfUsername = 1,
            LackOfPassword = 2,
            DuplicatedUsername = 3,
            InconsistentPassword = 4,
            DuplicateEmail = 5,
            LackOfEmail = 6
        }

        //建立驗證使用者帳號密碼的方法。
        public static LogonErrorTypes ValidateUser(string userName, string password)
        {
            if (userName == "") { return LogonErrorTypes.LackOfUsername; }
            if (password == "") { return LogonErrorTypes.LackOfPassword; }

            Model.WPF_ProjectDBEntities db = new Model.WPF_ProjectDBEntities();

            //確認DataEntity中是否有帳號密碼相符的資訊。
            foreach (Model.UserInformation u in db.UserInformations)
            {
                if (u.Username == userName)
                {
                    byte[] bytesInputPassword = Encoding.Unicode.GetBytes(password + Encoding.Unicode.GetString(u.salt));
                    SHA256Managed Algorism = new SHA256Managed();
                    byte[] hashedInputPassword = Algorism.ComputeHash(bytesInputPassword);
                    if (u.Password.SequenceEqual(hashedInputPassword))
                    {
                        switch (u.UserType)
                        {
                            case "admin":
                                return LogonErrorTypes.ValidAdminUser;
                                
                            case "normal":
                                return LogonErrorTypes.ValidNormalUser;
                                
                            case "store":
                                return LogonErrorTypes.ValidStoreUser;
                                
                            default:
                                break;
                        }
                    }
                    else
                    {
                        return LogonErrorTypes.InvalidUser;
                    }
                }
            }
            return LogonErrorTypes.UserNotExist;
        }

        public enum LogonErrorTypes
        {
            ValidNormalUser = 0,
            ValidStoreUser = 1,
            ValidAdminUser = 2,
            LackOfUsername = 3,
            LackOfPassword = 4,
            InvalidUser = 5,
            UserNotExist = 6
        }

        public static RegisterErrorTypes UpdateUser(string email, string firstname, string lastname, string mobile, Image profilePic)
        {
            //確認資訊填寫完整程度。
            if (email == "") { return RegisterErrorTypes.LackOfEmail; }

            Model.WPF_ProjectDBEntities db = new Model.WPF_ProjectDBEntities();
            //Window mainWindow = Application.Current.MainWindow;
            //確認DataEntity中是否已存在相同email。
            foreach (Model.UserInformation u in db.UserInformations)
            {
                if ((CurrentUser != u.Username) && (u.email == email))
                { return RegisterErrorTypes.DuplicateEmail; }
            }

            //將Image轉為byte[]
            MemoryStream ms = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create((BitmapSource)profilePic.Source));
            encoder.Save(ms);
            byte[] imgData = ms.ToArray();
            ms.Close();

            //經多重檢查無誤後，將帳號資訊登錄於DataEntity中。
            var q = from u in db.UserInformations
                    where u.Username == CurrentUser
                    select u;

            foreach (var user in q)
            {
                user.email = email;
                user.Firstname = firstname;
                user.Lastname = lastname;
                user.mobile = mobile;
                user.Photo = imgData;
            }
            db.SaveChanges();

            return RegisterErrorTypes.SuccessfulRegistration;
        }

        //建立移除使用者的方法。
        public static void DeleteUser(string currentUser)
        {
            Model.WPF_ProjectDBEntities db = new Model.WPF_ProjectDBEntities();

            var q = from u in db.UserInformations
                    where u.Username == currentUser
                    select u;

            if (q != null)
            {
                db.UserInformations.RemoveRange(q);
                db.SaveChanges();
                MessageBox.Show("成功移除帳號!");
            }
            else
            {
                MessageBox.Show("移除失敗!");
            }
        }

        //測試: 產生假的Normal User資料
        public static Model.UserInformation GenerateData()
        {
            Random r = new Random();
            string[] lastNameList = {"趙","錢","孫","李","陳","林","黃","吳","張","簡","廖","梁","蕭","花","江",
                                             "袁","蔡","周","王","許","譚","鄧","洪","何","郭","馬","崔","馮","余","闕",
                                             "汪","方","莊","范","蘇","詹","章","葉","劉","毛","邱","胡","溫","謝","卓"};
            string[] firstNameList = {"小明","小英","家偉","國華","罔市","罔腰","招弟","阿牛","小芳","曉萱",
                                              "金寶","阿狗","大鼻","建智","美美","小紅","家豪","怡君","小智","俊雄",
                                              "阿良","兵兵","冰冰","曉琪","丁丁","美枝","來福","惠鈺","小乖","小威"};

            string fLastname = lastNameList[r.Next(lastNameList.Length)];
            string fFastname = firstNameList[r.Next(firstNameList.Length)];
            string fMobile = $"09{r.Next(100000000):d8}";

            string fUserName = "";
            int stringLen = r.Next(3, 8);
            string alphabetic = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < stringLen; i++)
            {
                int charNO = r.Next(52);
                fUserName += alphabetic[charNO];
            }

            string fEmail = "XXXX@";
            for (int i = 0; i < 12; i++)
            {
                int charNO = r.Next(52);
                fEmail += alphabetic[charNO];
            }

            Model.UserInformation fakeUser = new Model.UserInformation
            {
                mobile = fMobile,
                Firstname = fFastname,
                Lastname = fLastname,
                Username = fUserName,
                email = fEmail,
            };
            return fakeUser;
        }
    }
}
