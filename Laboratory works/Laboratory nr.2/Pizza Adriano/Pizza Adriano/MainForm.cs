using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Adriano
{
    public partial class MainForm : Form
    {
        Order order;
        Check check;
        Price price;

        public MainForm()
        {
            InitializeComponent();
            //order 
            order = new Order();
            //checking
            check = new Check();
            //computing price
            price = new Price();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //check the price
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(GetPrice()) + " lei";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //get the price
        private int GetPrice()
        {
            int retVal = 0;

            //cecked cheeses components
            List<int> arg1 = ConvertToList(checkedListBox1);

            //cecked vegetables components
            List<int> arg2 = ConvertToList(checkedListBox3);

            //cecked meat components
            List<int> arg3 = ConvertToList(checkedListBox2);

            //check if the components are not exceeded
            int checkResult = check.CheckComponents(arg1,arg2,arg3);

            if (checkResult == 0)
            {
                retVal = price.ComputePrice(arg1,arg2,arg3);
            }
            else if(checkResult == -1)
                MessageBox.Show("Please choose up to 2 Meat items");
            else if(checkResult == -2)
                MessageBox.Show("Please choose up to 5 Vegetables items");
            else if(checkResult == -3)
                MessageBox.Show("Please choose up to 3 Cheeses items");
            else
                MessageBox.Show("Something bad happened!");

            return retVal;
        }

        //order
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                //prints the price
                textBox2.Text = Convert.ToString(GetPrice()) + " lei";
                //prints the id
                textBox3.Text = textBox1.Text + "-" + Convert.ToString(order.GetId());
                //hides the buttons, so no new command is possible
                button1.Hide();
                button2.Hide();
            }
            else
                MessageBox.Show("Please enter a name");
        }

        //convert the CheckedListBox.CheckedIndices to a List<int>
        private List<int> ConvertToList(CheckedListBox input)
        {
            List<int> retVal = new List<int>();

            for (int i = 0; i < input.CheckedIndices.Count; i++)
            {
                retVal.Add(input.CheckedIndices[i]);
            }

            return retVal;
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
