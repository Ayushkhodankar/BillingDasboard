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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teaCount++;
            teasum = teaCount * 10;
            

            string[] row = { tea.Text, teaCount.ToString(), teasum.ToString()};
            var listViewItem = new ListViewItem(row);
            listItem.Items.Add(listViewItem);
        }

        private void listItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            listItem.View = View.Details;
            listItem.GridLines = true;
            listItem.FullRowSelect = true;

        }

        private void elaichi_Click(object sender, EventArgs e)
        {
            elaichiCount++;
            elaichisum = elaichiCount * 15;


            string[] row = { elaichi.Text, elaichiCount.ToString(), elaichisum.ToString() };
            var listViewItem = new ListViewItem(row);
            listItem.Items.Add(listViewItem);
        }

        private void maggie_Click(object sender, EventArgs e)
        {
            maggieCount++;
            maggiesum = maggieCount * 20;


            string[] row = { maggie.Text, maggieCount.ToString(), maggiesum.ToString() };
            var listViewItem = new ListViewItem(row);
            listItem.Items.Add(listViewItem);
        }

        private void coffee_Click(object sender, EventArgs e)
        {
            coffeeCount++;
            coffeesum = maggieCount * 12;


            string[] row = { coffee.Text, coffeeCount.ToString(), coffeesum.ToString() };
            var listViewItem = new ListViewItem(row);
            listItem.Items.Add(listViewItem);
        }
    }
}