using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace expences_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            var path = readTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File doesn't exist. Cannot proceed");
                return;
            }

            showTextBox.Text = File.ReadAllText(path);
        }

        private void task1_Click(object sender, EventArgs e)
        {
            var path = readTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File doesn't exist. Cannot proceed");
                return;
            }

            var lines = File.ReadAllLines(path).Skip(1);

            var expences = new List<Expences>();
            foreach (var line in lines)
            {
                var split = line.Split('|');
                var date = DateTime.ParseExact(split[0], "yyyy-MM-dd", null);
                var price = Convert.ToDecimal(split[1]);
                var category = split[2];

                var expence = new Expences(date, price, category);
                expences.Add(expence);
            }

            var catnum = expences
                .Select(x => x.Category).Distinct().Count();

            var total = expences
                .Select(x => x.Price).Sum();

            showTextBox.Text += $"The number of categories: {catnum}, total expences = {total}";
        }

        private void task2_Click(object sender, EventArgs e)
        {
            var path = readTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File doesn't exist. Cannot proceed");
                return;
            }

            var lines = File.ReadAllLines(path).Skip(1);

            var expences = new List<Expences>();
            foreach (var line in lines)
            {
                var split = line.Split('|');
                var date = DateTime.ParseExact(split[0], "yyyy-MM-dd", null);
                var price = Convert.ToDecimal(split[1]);
                var category = split[2];

                var expence = new Expences(date, price, category);
                expences.Add(expence);
            }

            var catnum = expences
                .Select(x => x.Category).Distinct().Count();

            var total = expences
                .Select(x => x.Price).Sum();

            IEnumerable<string> cats = expences
                .Select(x => x.Category).Distinct();

            IEnumerable<DateTime> dates = expences
                .Select(x => x.DateTime).Distinct();

            showTextBox.Text += $"\r\nNumber of categories: {catnum}, total expences = {total}";
            showTextBox.Text += $"\r\nCategories: ";
            foreach (var cat in cats)
                showTextBox.Text += $"{cat}, ";
            showTextBox.Text += $"\r\nDates: ";
            foreach (var dat in dates)
                showTextBox.Text += $"{dat.ToString("yyyy-MM-dd")}, ";
        }

        private void task3_Click(object sender, EventArgs e)
        {
            var path = readTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File doesn't exist. Cannot proceed");
                return;
            }

            var lines = File.ReadAllLines(path).Skip(1);

            var expences = new List<Expences>();
            foreach (var line in lines)
            {
                var split = line.Split('|');
                var date = DateTime.ParseExact(split[0], "yyyy-MM-dd", null);
                var price = Convert.ToDecimal(split[1]);
                var category = split[2];

                var expence = new Expences(date, price, category);
                expences.Add(expence);
            }

            var catnum = expences
                .Select(x => x.Category).Distinct().Count();

            var total = expences
                .Select(x => x.Price).Sum();

            IEnumerable<string> cats = expences
                .Select(x => x.Category).Distinct();

            var excat = expences
                .GroupBy(x => x.Category)
                .Select(x => $"{x.Key}: {x.Sum(y => y.Price)}");

            showTextBox.Text = string.Join("\r\n", excat);

            showTextBox.Text += $"\r\nNumber of categories: {catnum}, total expences = {total}";

            showTextBox.Text += $"\r\nCategories: ";
            foreach (var cat in cats)
                showTextBox.Text += $"{cat}, ";
        }


    }
    public class Expences
    {
        public DateTime DateTime { get; }
        public decimal Price { get; }
        public string Category { get; }

        public Expences(DateTime dateTime, decimal price, string category)
        {
            DateTime = dateTime;
            Price = price;
            Category = category;
        }
    }
}

