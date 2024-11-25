namespace DataModel
{
    public class MyData
    {
        public MyData()
        {
            invoice = 123456;
            address = "東京都千代田区大手町2-1";
            name = "株式会社山の手通信工業";
            amount = 987654321;
            memo = "データセンタ改修工事一式";
        }
        public int invoice
        {
            get; set;
        }
        public string address
        {
            get; set;
        }
        public string name
        {
            get; set;
        }
        public int amount
        {
            get; set;
        }
        public string memo
        {
            get; set;
        }
    }
}
