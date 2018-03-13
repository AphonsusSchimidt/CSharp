using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKyHoc_MTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string userName;
        private string pass;
        private FirefoxDriver firefoxDriver;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Khởi tạo
            userName = "15150136";
            pass = "25081995a7";
            //userName = txtUseName.Text;
            // pass = txtPass.Text;
            firefoxDriver = new FirefoxDriver();
            firefoxDriver.Url = "http://dangkyhoc.mta.edu.vn/dkmh/login.asp";
            firefoxDriver.Navigate();

            WebDriverWait wait = new WebDriverWait(this.firefoxDriver, TimeSpan.FromSeconds(30));
            wait.Until((x) =>
            {
                return ((IJavaScriptExecutor)this.firefoxDriver).ExecuteScript("return document.readyState").Equals("complete");
            });


            //Gửi dữ liệu
            var userNameID = firefoxDriver.FindElementById("txtLoginId");
            userNameID.SendKeys(userName);
            var passID = firefoxDriver.FindElementById("txtPassword");
            passID.SendKeys(pass);
            var login = firefoxDriver.FindElementByClassName("button");
            login.Click();
           
            WebDriverWait wait1 = new WebDriverWait(this.firefoxDriver, TimeSpan.FromSeconds(30));
            wait1.Until((x) =>
            {
                return ((IJavaScriptExecutor)this.firefoxDriver).ExecuteScript("return document.readyState").Equals("complete");
            });
            var dkmh = firefoxDriver.FindElementById("PortalModule_271");
            dkmh.Click();
            string scr = "var vStdRegMax= Number('25');";
            firefoxDriver.ExecuteScript(scr);


        }
    }
}
