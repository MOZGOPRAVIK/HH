namespace Delivery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sort_Click(object sender, EventArgs e)
        {
            int MINUTES = 30;

            using (StreamWriter writer = new StreamWriter("C:\\Users\\boris\\OneDrive\\Desktop\\Delivery\\Result.txt", false)) { }

            richTextBox3.Clear();

            Dictionary<string, List<Order>> dict = new Dictionary<string, List<Order>>();

            string[] str = GetText().Split('\n');

            foreach (string x in str)
            {
                Order order = new Order(x);

                if (dict.ContainsKey(order.city)) dict[order.city].Add(order);
                else dict[order.city] = new List<Order> { order };
            }

            string adress = textBox1.Text.Replace(' ', '_');

            AddText(adress, "C:\\Users\\boris\\OneDrive\\Desktop\\Delivery\\Logging.txt");
            AddText("", "C:\\Users\\boris\\OneDrive\\Desktop\\Delivery\\Logging.txt");


            if (!dict.ContainsKey(adress))
            {
                MessageBox.Show("Такого района нет");
                return;
            }

            DateTime firstTime = dict[adress][0].date;

            foreach (var x in dict[adress])
            {
                if (x.date < firstTime) firstTime = x.date;
            }

            DateTime secondTime = firstTime.AddMinutes(MINUTES);

            List<Order> idProducts = new List<Order>();

            foreach (var t in dict)
            {
                if (t.Key == adress)
                {
                    foreach (var x in t.Value)
                    {
                        if (x.date >= firstTime && x.date <= secondTime) idProducts.Add(x);
                    }
                }
            }

            foreach (Order x in idProducts.OrderBy(x => x.date))
            {
                richTextBox3.AppendText($"ID: {x.id} City: {x.city} Date and Time: {x.date}" + "\n");

                AddText(x.id.ToString() + ':' + x.city.ToString() + ':' + x.date.ToString());

                AddText(x.id.ToString() + ':' + x.city.ToString() + ':' + x.date.ToString(), "C:\\Users\\boris\\OneDrive\\Desktop\\Delivery\\Logging.txt");
            }

            richTextBox3.AppendText("Данные в файл записаны");

            AddText("", "C:\\Users\\boris\\OneDrive\\Desktop\\Delivery\\Logging.txt");
            AddText(DateTime.Now.ToString(), "C:\\Users\\boris\\OneDrive\\Desktop\\Delivery\\Logging.txt");
            AddText("-------------------------", "C:\\Users\\boris\\OneDrive\\Desktop\\Delivery\\Logging.txt");
        }

        static void AddText(string text)
        {
            using (StreamWriter writer = new StreamWriter("C:\\Users\\boris\\OneDrive\\Desktop\\Delivery\\Result.txt", true))
            {
                writer.WriteLine(text);
            }
        }

        static void AddText(string text, string file)
        {
            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.WriteLine(text);
            }
        }

        static string GetText()
        {
            using (StreamReader writer = new StreamReader("C:\\Users\\boris\\OneDrive\\Desktop\\Delivery\\File.txt", true))
            {
                return writer.ReadToEnd();
            }
        }
    }
    class Order
    {
        public int id { get; set; }
        public double weight { get; set; }
        public string city { get; set; }
        public DateTime date { get; set; }

        public Order(string str)
        {
            string[] list = str.Split(' ');

            if (int.TryParse(list[0], out int id)) this.id = id;
            else MessageBox.Show($"Ошибка в {list[0]}");

            if (double.TryParse(list[1], out double weight)) this.weight = weight;
            else MessageBox.Show($"Ошибка в {list[1]}");

            city = list[2].ToString();

            if (DateTime.TryParse(list[3] + " " + list[4], out DateTime date)) this.date = date;
            else MessageBox.Show($"Ошибка в {list[3] + " " + list[4]}");
        }
    }
}