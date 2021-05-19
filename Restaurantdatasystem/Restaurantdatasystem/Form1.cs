using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurantdatasystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet12.ORDER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oRDERTableAdapter.Fill(this.dataSet12.ORDER);
            // TODO: Bu kod satırı 'dataSet12.BİLL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bİLLTableAdapter.Fill(this.dataSet12.BİLL);
            // TODO: Bu kod satırı 'dataSet12.ORDER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oRDERTableAdapter.Fill(this.dataSet12.ORDER);
            // TODO: Bu kod satırı 'dataSet1.PRODUCT' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.pRODUCTTableAdapter.Fill(this.dataSet1.PRODUCT);
            // TODO: Bu kod satırı 'dataSet1.ORDER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oRDERTableAdapter.Fill(this.dataSet1.ORDER);
            // TODO: Bu kod satırı 'dataSet1.Restaurant' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.restaurantTableAdapter.Fill(this.dataSet1.Restaurant);
            // TODO: Bu kod satırı 'dataSet1.EMPLOYEE' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.eMPLOYEETableAdapter.Fill(this.dataSet1.EMPLOYEE);
            // TODO: Bu kod satırı 'dataSet1.CUSTOMER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
            // TODO: Bu kod satırı 'dataSet11.BİLL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bİLLTableAdapter.Fill(this.dataSet11.BİLL);
            // TODO: Bu kod satırı 'dataSet1.BİLL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bİLLTableAdapter.Fill(this.dataSet1.BİLL);
            // TODO: Bu kod satırı 'dataSet1.ORDER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oRDERTableAdapter.Fill(this.dataSet1.ORDER);
            // TODO: Bu kod satırı 'dataSet1.PRODUCT' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.pRODUCTTableAdapter.Fill(this.dataSet1.PRODUCT);
            // TODO: Bu kod satırı 'dataSet1.EMPLOYEE' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.eMPLOYEETableAdapter.Fill(this.dataSet1.EMPLOYEE);
            // TODO: Bu kod satırı 'dataSet1.CUSTOMER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
            // TODO: Bu kod satırı 'dataSet1.Restaurant' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.restaurantTableAdapter.Fill(this.dataSet1.Restaurant);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//customer
        {
            int csıd, empıd;
            int.TryParse(textBox3.Text, out csıd);
            int.TryParse(comboBox1.SelectedValue.ToString(), out empıd);
            this.cUSTOMERTableAdapter.InsertQuery(textBox1.Text, textBox2.Text, csıd, textBox4.Text, empıd);
            this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int CS_ID;
            int.TryParse(textBox5.Text, out CS_ID);
            textBox6.Text = this.cUSTOMERTableAdapter.ScalarQuery_FName(CS_ID);
            textBox7.Text = this.cUSTOMERTableAdapter.ScalarQuery_LName(CS_ID);
            textBox8.Text = Convert.ToString(this.cUSTOMERTableAdapter.ScalarQuery_Number(CS_ID));
            textBox9.Text = this.cUSTOMERTableAdapter.ScalarQuery_Adress(CS_ID);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID, Number, EMP_ID;
            int.TryParse(textBox5.Text, out ID);
            int.TryParse(textBox8.Text, out Number);
            int.TryParse(comboBox2.SelectedValue.ToString(), out EMP_ID);
            this.cUSTOMERTableAdapter.UpdateQuery(textBox6.Text, textBox7.Text, Number, textBox9.Text, EMP_ID, ID);
            this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox5.Text, out ID);
            this.cUSTOMERTableAdapter.DeleteQuery(ID);
            this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
        }

        private void button5_Click(object sender, EventArgs e) //employee
        {
            int ID, S_ID;
            int.TryParse(textBox12.Text, out ID);
            int.TryParse(comboBox3.SelectedValue.ToString(), out S_ID);
            this.eMPLOYEETableAdapter.InsertQuery(textBox10.Text, textBox11.Text, ID, textBox13.Text, S_ID);
            this.eMPLOYEETableAdapter.Fill(this.dataSet1.EMPLOYEE);
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int EMP_ID;
            int.TryParse(textBox14.Text, out EMP_ID);
            textBox15.Text = this.eMPLOYEETableAdapter.ScalarQuery_FName(EMP_ID);
            textBox16.Text = this.eMPLOYEETableAdapter.ScalarQuery_LName(EMP_ID);
            textBox17.Text = Convert.ToString(this.eMPLOYEETableAdapter.ScalarQuery_Number(EMP_ID));
            textBox18.Text = this.eMPLOYEETableAdapter.ScalarQuery_Adress(EMP_ID);
            this.eMPLOYEETableAdapter.Fill(this.dataSet1.EMPLOYEE);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int ID, Number, S_ID;
            int.TryParse(textBox14.Text, out ID);
            int.TryParse(textBox17.Text, out Number);
            int.TryParse(comboBox4.SelectedValue.ToString(), out S_ID);
            this.eMPLOYEETableAdapter.UpdateQuery(textBox15.Text, textBox16.Text, Number, textBox18.Text, S_ID, ID);
            this.eMPLOYEETableAdapter.Fill(this.dataSet1.EMPLOYEE);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox14.Text, out ID);
            this.eMPLOYEETableAdapter.DeleteQuery(ID);
            this.eMPLOYEETableAdapter.Fill(this.dataSet1.EMPLOYEE);
        }

        private void button9_Click(object sender, EventArgs e)//product
        {
            int PR_NUMBER;
            int Q_ID;
            int empıd;
            int.TryParse(comboBox5.SelectedValue.ToString(), out empıd);
            int.TryParse(textBox21.Text, out PR_NUMBER);
            int.TryParse(textBox20.Text, out Q_ID);
            this.pRODUCTTableAdapter.InsertQuery(textBox19.Text,PR_NUMBER, Q_ID,empıd);
            this.pRODUCTTableAdapter.Fill(this.dataSet1.PRODUCT);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int PR_ID;
            int.TryParse(textBox22.Text, out PR_ID);
            textBox23.Text = this.pRODUCTTableAdapter.ScalarQuery_Name(PR_ID);
            textBox24.Text = Convert.ToString(this.pRODUCTTableAdapter.ScalarQuery_Price(PR_ID));
            textBox25.Text = Convert.ToString(this.pRODUCTTableAdapter.ScalarQuery_Quantity(PR_ID));
            this.pRODUCTTableAdapter.Fill(this.dataSet1.PRODUCT);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int PR_ID, P_PRICE, P_QUA;
            int.TryParse(textBox25.Text, out P_PRICE);
            int.TryParse(textBox22.Text, out PR_ID);
            int.TryParse(textBox24.Text, out P_QUA);
            this.pRODUCTTableAdapter.UpdateQuery(textBox23.Text, P_PRICE, P_QUA, PR_ID);
            this.pRODUCTTableAdapter.Fill(this.dataSet1.PRODUCT);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int PR_ID;
            int.TryParse(textBox22.Text, out PR_ID);
            this.pRODUCTTableAdapter.DeleteQuery(PR_ID);
            this.pRODUCTTableAdapter.Fill(this.dataSet1.PRODUCT);
        }

        private void button13_Click(object sender, EventArgs e)//Restaurant
        {
            int ID;
            int num;
            int.TryParse(textBox31.Text, out num);
            int.TryParse(textBox33.Text, out ID);
            this.restaurantTableAdapter.InsertQuery(textBox30.Text, num, textBox32.Text);
            this.restaurantTableAdapter.Fill(this.dataSet1.Restaurant);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox33.Text, out ID);
            textBox34.Text = this.restaurantTableAdapter.ScalarQuery_Name(ID);
            textBox35.Text = Convert.ToString(this.restaurantTableAdapter.ScalarQuery_Phone(ID));
            textBox36.Text = this.restaurantTableAdapter.ScalarQuery_Adress(ID);
            this.restaurantTableAdapter.Fill(this.dataSet1.Restaurant);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int ID;
            int num;
            int.TryParse(textBox35.Text, out num);
            int.TryParse(textBox33.Text, out ID);
            this.restaurantTableAdapter.UpdateQuery(textBox34.Text, num, textBox36.Text, ID);
            this.restaurantTableAdapter.Fill(this.dataSet1.Restaurant);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox33.Text, out ID);
            this.restaurantTableAdapter.DeleteQuery(ID);
            this.restaurantTableAdapter.Fill(this.dataSet1.Restaurant);
        }

        private void button17_Click(object sender, EventArgs e)//ORDER
        {
            int C_ID, CAR_ID;
            int ORDER_ID;
            int.TryParse(textBox38.Text, out ORDER_ID);
            int.TryParse(comboBox7.SelectedValue.ToString(), out C_ID);
            int.TryParse(comboBox8.SelectedValue.ToString(), out CAR_ID);
            this.oRDERTableAdapter.InsertQuery(C_ID, CAR_ID);
            this.oRDERTableAdapter.Fill(this.dataSet1.ORDER);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int ORDER_ID, C_ID, CAR_ID;
            int.TryParse(textBox38.Text, out ORDER_ID);
            int.TryParse(comboBox9.SelectedValue.ToString(), out C_ID);
            int.TryParse(comboBox10.SelectedValue.ToString(), out CAR_ID);
            this.oRDERTableAdapter.UpdateQuery(C_ID, CAR_ID, ORDER_ID);
            this.oRDERTableAdapter.Fill(this.dataSet1.ORDER);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int ORDER_ID;
            int.TryParse(textBox38.Text, out ORDER_ID);
            comboBox7.SelectedValue = Convert.ToString(this.oRDERTableAdapter.ScalarQuery_Customer(ORDER_ID));
            comboBox8.SelectedValue = Convert.ToString(this.oRDERTableAdapter.ScalarQuery_Product(ORDER_ID));
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int ORDER_ID;
            int.TryParse(textBox38.Text, out ORDER_ID);
            this.oRDERTableAdapter.DeleteQuery(ORDER_ID);
            this.oRDERTableAdapter.Fill(this.dataSet1.ORDER);
        }

        private void button21_Click(object sender, EventArgs e)//bill
        {
            int ORD_ID;
            int.TryParse(comboBox5.SelectedValue.ToString(), out ORD_ID);
            this.bİLLTableAdapter.InsertQuery(ORD_ID);
            this.bİLLTableAdapter.Fill(this.dataSet1.BİLL);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int B_ID;
            int.TryParse(textBox40.Text, out B_ID);
            comboBox11.SelectedValue = Convert.ToString(this.bİLLTableAdapter.ScalarQuery_ORDER(B_ID));
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox40.Text, out ID);
            this.bİLLTableAdapter.DeleteQuery(ID);
            this.bİLLTableAdapter.Fill(this.dataSet1.BİLL);
        }
    }
}
