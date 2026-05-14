using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Cell_Phone_Test
{
    // CellPhone 類別代表一支手機，包含品牌、型號與價格等屬性。
    class CellPhone
    {
        // 私有欄位：儲存各屬性資料
        private string _brand;
        private string _model;
        private decimal _price;

        // 建構子：初始化欄位為預設值
        public CellPhone()
        {
            _brand = string.Empty;
            _model = string.Empty;
            _price = 0.0m;
        }

        // 公開屬性：Brand（品牌）
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        // 公開屬性：Model（型號）
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        // 公開屬性：Price（價格）
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
