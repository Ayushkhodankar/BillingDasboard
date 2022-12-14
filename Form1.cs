using static System.Net.Mime.MediaTypeNames;

namespace BillingDasboard
{
    public partial class Form1 : Form
    {
        int teaCount=0;
        int teasum = 0;
        int elaichiCount = 0;
        int elaichisum = 0;
        int maggieCount = 0;
        int maggiesum = 0;
        int coffeeCount = 0;
        int coffeesum = 0;
        string sum=null;

        int totalsum=0;    
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            teaCount++;
            teasum = teaCount * 10;
           // int text = integ tea.Text;
            
            string[] row = { tea.Text, teaCount.ToString(), teasum.ToString()};
           // listItem.Items.Remove(text);
          var listViewItem = new ListViewItem(row);
          /*  if (!listItem.Items.ContainsKey(text))
            {*/
                listItem.Items.Add(listViewItem); 
                
           // }
            
        }

        private void listItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            listItem.View = View.Details;
            listItem.GridLines = true;
            listItem.FullRowSelect = true;

        }

        public void elaichi_Click(object sender, EventArgs e)
        {
            elaichiCount++;
            elaichisum = elaichiCount * 15;

            
            string[] row = { elaichi.Text, elaichiCount.ToString(), elaichisum.ToString() };
            var listViewItem = new ListViewItem(row);
            
            if (!listItem.Items.Contains(listViewItem))
            {
                listItem.Items.Clear();
                listItem.Items.Add(listViewItem);
            }
        }

        public void maggie_Click(object sender, EventArgs e)
        {
            maggieCount++;
            maggiesum = maggieCount * 20;

            listItem.Items.Clear();
            string[] row = { maggie.Text, maggieCount.ToString(), maggiesum.ToString() };
            var listViewItem = new ListViewItem(row);
            listItem.Items.Add(listViewItem);
        }

        public void coffee_Click(object sender, EventArgs e)
        {
            int ccount=coffeeCount++;
            coffeesum = coffeeCount * 12;

            listItem.Items.Clear();

            string[] row = { coffee.Text, coffeeCount.ToString(), coffeesum.ToString() };
            var listViewItem = new ListViewItem(row);
           listItem.Items.Add(listViewItem);
            
          //  listItem.Items[maggie.Text].Remove();
           
            //  listItem.Items.Remove(listViewItem);
        }

        private void totalAmount_TextChanged(object sender, EventArgs e)
        {
            int totalsum = this.coffeesum + this.teasum + this.maggiesum + this.elaichisum;
            sum=totalsum.ToString();
            totalAmount.Text=sum;
        }

        private void print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Bill= Rs."+this.sum+"\nYour Bill Is Printed Successfully!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void reset_Click(object sender, EventArgs e)
        {
            listItem.Clear();
            
        }
    }
}