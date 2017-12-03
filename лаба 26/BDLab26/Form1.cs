using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDLab26
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDbContext _context;
        public Form1()
        {
            _context = new ApplicationDbContext();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!_context.Service.Any())
            {
                _context.Service.Add(new Service()
                {
                    Count = 0,
                    description = "Тестовое описание",
                    name = "Тестовое имя",
                    value = 15
                });
                _context.SaveChanges();
            }
            if (!_context.Visitor.Any())
            {
                _context.Visitor.Add(new Visitors()
                {
                    FIO = "Тестовая фамилия",
                    Discount = 0,
                    PhoneNumber = 1234567
                });
                _context.SaveChanges();
            }
            dataGridView1.DataSource = _context.Service.ToList();
            dataGridView2.DataSource = _context.Visitor.ToList();
            dataGridView3.DataSource = _context.Visit.ToList();   
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _context.Service.Add(new Service()
                {
                    name = SName.Text,
                    description = SDescription.Text,
                    value = (int) SValue.Value
                });
                _context.SaveChanges();
                UpdateTables();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Input Error");
            }
        }

        public void UpdateTables()
        {
            dataGridView1.DataSource = _context.Service.ToList();
            dataGridView2.DataSource = _context.Visitor.ToList();
            dataGridView3.DataSource = _context.Visit.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _context.Visitor.Add(new Visitors()
                {
                    FIO = VFIO.Text,
                    Discount = (int) VDiscount.Value,
                    PhoneNumber = (int) VPhoneNumber.Value
                });
                _context.SaveChanges();
                UpdateTables();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Input Error");
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            UpdateCb();
        }

        public void UpdateCb()
        {
            try
            {
                ClearCb();
                foreach (var item in _context.Visitor.ToList())
                {
                    VVisitor.Items.Add(item.FIO);
                }
                foreach (var item in _context.Service.ToList())
                {
                    VService.Items.Add(item.name);
                }
                foreach (var item in _context.Visit.ToList())
                {
                    if (!MasterForFind.Items.Contains(item.Master))
                    {
                        MasterForFind.Items.Add(item.Master);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error");
            }
        }

        public void ClearCb()
        {
            VService.Items.Clear();
            VVisitor.Items.Clear();
            MasterForFind.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                _context.Visit.Add(new Visits()
                {
                    Service = VService.Text,
                    Visitor = VVisitor.Text,
                    Date = VDate.Value,
                    Master = VMaster.Text
                });
                IsMore3Visits(VVisitor.Text);
                _context.SaveChanges();
                UpdateTables();
                UpdateCb();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Input Error");
            }
        }

        public void IsMore3Visits(string visitorFio)
        {
            try
            {
                var visitor = _context.Visitor.First(x => x.FIO == visitorFio);
                _context.Visitor.Remove(visitor);
                _context.SaveChanges();
                visitor.Count++;
                if (visitor.Count >= 3)
                {
                    visitor.Discount += 10;
                    if (visitor.Discount >= 50)
                    {
                        visitor.Discount = 50;
                    }
                }
                _context.Visitor.Add(visitor);
            }
            catch (Exception )
            {
                MessageBox.Show(@"Error");
            }            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void FindVisitor_Click(object sender, EventArgs e)
        {
            try
            {
                var findValue = int.Parse(ServiceMoreThenThis.Text);
                var services = _context.Visit.ToList()
                    .Select(item => _context.Service.First(x => x.name == item.Service))
                    .Where(first => first.value >= findValue).ToList();

                var visitors = new List<Visitors>();
                foreach (var item in _context.Visit.ToList())
                {
                    var temp = _context.Visitor.First(x => x.FIO == item.Visitor);
                    if (services.Contains(_context.Service.First(x=>x.name==item.Service)) && !visitors.Contains(temp))
                    {
                        visitors.Add(temp);
                    }
                    
                }

                var output = visitors.Aggregate(string.Empty, (current, item) => current + (item.FIO + Environment.NewLine));
                MessageBox.Show(output);
        }
            catch (Exception)
            {
                MessageBox.Show(@"Error");
            }

}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var output = string.Empty;
            var maxDiscount = _context.Visitor.ToList().Aggregate((x, y) => x.Discount > y.Discount ? x : y).Discount;
            output = Enumerable.Aggregate(_context.Visitor.Where(visitorse => visitorse.Discount == maxDiscount),
                output,
                (current, visitorse) => current + (visitorse.FIO + " " + visitorse.PhoneNumber + " " +
                                                   visitorse.Discount + Environment.NewLine));
            MessageBox.Show(output);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string master;
            try
            {
                master = MasterForFind.Text;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error");
                return;
            }
            
            var output = string.Empty;
            var services = new List<Service>();
            var visitors = new List<Visitors>();
            foreach (var visit in _context.Visit.ToList())
            {
                if (visit.Master == master)
                {
                    var tempService = _context.Service.First(x => x.name == visit.Service);
                    if (!services.Contains(tempService))
                    {
                        services.Add(tempService);
                    }

                    var tempVisitor = _context.Visitor.First(x => x.FIO == visit.Visitor);
                    if (!visitors.Contains(tempVisitor))
                    {
                        visitors.Add(tempVisitor);
                    }
                    
                }
            }

            foreach (var service in services)
            {
                output += service.ToString() + Environment.NewLine;
            }

            foreach (var visitor in visitors)
            {
                output += visitor.ToString() + Environment.NewLine;
            }

            MessageBox.Show(output);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var output = string.Empty;
            float avg = 0;
            try
            {
                avg = float.Parse(Avg.Text);
            }
            catch (Exception )
            {
                MessageBox.Show(@"InputError");
                return;
            }

            foreach (var item in GetAvgPriceMasters())
            {
                if (item.Value>=avg)
                {
                    output += item.Key + Environment.NewLine;
                }            
            }
            MessageBox.Show(output);
        }

        public Dictionary<string, float>  GetAvgPriceMasters()
        {
            var services = new List<Service>();
            var visitors = new List<Visitors>();
            var mastersPrice = new Dictionary<string, float>();
            var mastersSumPrice = new Dictionary<string, int>();
            var mastersCountPrice = new Dictionary<string, int>();
            foreach (var visit in _context.Visit.ToList())
            {
                var master = visit.Master;                
                foreach (var item in _context.Visit.ToList())
                {
                    var tempService = _context.Service.First(x => x.name == visit.Service);
                    if (!mastersSumPrice.ContainsKey(master))
                    {
                        mastersSumPrice.Add(master, 0);
                        mastersCountPrice.Add(master,0);
                    }
                    mastersSumPrice[master] += tempService.value;
                    mastersCountPrice[master]++;
                }

                if (!mastersPrice.ContainsKey(master))
                {
                    mastersPrice.Add(master, 0);
                }

                // ReSharper disable once PossibleLossOfFraction
                mastersPrice[master] = mastersSumPrice[master] / mastersCountPrice[master];
            }           
            
            return mastersPrice;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var count = 0;

            foreach (var visitse in _context.Visit.ToList())
            {
                if (visitse.Date.Month == DateTime.Now.Month)
                {
                    count++;
                }
            }
            MessageBox.Show(count.ToString());
        }
    }
}
