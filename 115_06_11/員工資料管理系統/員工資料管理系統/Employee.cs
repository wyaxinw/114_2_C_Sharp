using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 員工資料管理系統
{
    /// <summary>
    /// 員工資料類別，符合規格書中 Employee 類別定義
    /// </summary>
    public class Employee
    {
        // 姓名
        public string Name { get; set; }
        // 員工編號（唯一識別碼）
        public int IdNumber { get; set; }
        // 部門
        public string Department { get; set; }
        // 職稱
        public string Position { get; set; }

        // 無參數建構子：預設值
        public Employee()
        {
            Name = string.Empty;
            Department = string.Empty;
            Position = string.Empty;
            IdNumber = 0;
        }

        // 兩參數建構子：指定姓名與編號，其他為預設空字串
        public Employee(string name, int idNumber)
        {
            // 將姓名修剪並設定編號，其他屬性設為空字串
            Name = (name ?? string.Empty).Trim();
            IdNumber = idNumber;
            Department = string.Empty;
            Position = string.Empty;
        }

        // 四參數建構子：完整指定所有屬性
        public Employee(string name, int idNumber, string department, string position)
        {
            Name = name ?? string.Empty;
            IdNumber = idNumber;
            Department = department ?? string.Empty;
            Position = position ?? string.Empty;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}", IdNumber, Name);
        }
    }
}
