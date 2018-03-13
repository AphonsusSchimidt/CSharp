using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReaderMVC.Models
{
    interface IRuleCheckingMethod
    {
        bool RuleCheck(List<object> param);
    }
    class Rules
    {
        private bool? isValid = null;
        private List<IRuleCheckingMethod> CheckingMethod = new List<IRuleCheckingMethod>();
        private List<object> RuleParam = new List<object>();
        public void AddCheckingMethod(IRuleCheckingMethod ir)
        {
            CheckingMethod.Add(ir);
        }

        public void AddRuleParam(params object[] pr)
        {
            foreach (object o in pr)
                RuleParam.Add(o);
            isValid = null;
        }

        public string RName { get; set; }
        public bool IsValid
        {
            get
            {
                if (isValid == null)
                    Run(RuleParam);
                return isValid.Value;
            }
        }
        private void Run(List<object> param)
        {
            bool ok = true;
            foreach (IRuleCheckingMethod icheck in CheckingMethod)
                ok = ok && icheck.RuleCheck(param);
            isValid = ok;
        }
    }
    class StringAppearing : IRuleCheckingMethod
    {
        public bool RuleCheck(List<object> param)
        {
            List<string> lst = new List<string>();
            foreach (object o in param)
            {
                lst.Add(o.ToString());
            }
            for (int i = 1; i < lst.Count; i++)
            {
                int index = lst[0].IndexOf(lst[i]);
                if (index < 0)
                    return false;
                lst[0] = lst[0].Remove(0, index + lst[i].Length);
            }
            return true;
        }
    }

    class TypeData : IRuleCheckingMethod
    {
        public bool RuleCheck(List<object> param)
        {
            List<string> lst = new List<string>();
            List<string> lstType = new List<string>();
            foreach (string s in ((List<string>)param[0]))
            {
                lstType.Add(s);
            }

            for (int i = 1; i < param.Count; i++)
            {
                lst.Add(param[i].ToString());
            }
            for (int i = 0; i < lst.Count; i++)
            {
                if (lstType[i]=="I")
                {
                   int x;
                   if(!int.TryParse(lst[i].Remove(0, 2), out x))
                   {
                       return false;
                   }
                   continue;
                }
                string[] w = lst[i].Remove(0, 2).Split(' ');
                foreach(string s in w)
                {
                    int x;
                    if (int.TryParse(s, out x))
                    {
                        return false;
                    }
                }
               
            }
            return true;
        }
    }
    #region
    class CheckFomatView : IRuleCheckingMethod
    {
        public bool RuleCheck(List<object> lst)
        {

            List<string> lstParam = new List<string>();
            foreach (object o in lst)
            {
                lstParam.Add(o.ToString());
            }
            // Kiểu xuất hiện
            // Các dạng: string ,number, date ,
            // Thứ tự xuất hiện theo list data đưa vào
            // Kiểu dữ liệu cần chiết tách

            return true;
        }

    }
    #endregion
}
