using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metodenumerice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sistemedenumeratie.deca d = new sistemedenumeratie.deca();
        sistemedenumeratie.binar b = new sistemedenumeratie.binar();



        

        private void Form1_Load(object sender, EventArgs e)
        {
            //number in deca
            _Text.Text  += d.numberofdigits(1234567890).ToString();
            d.numeric2List(1234567890, ref d._numar);
            _Text.Text += ":";
            _Text.Text += d.printList(ref d._numar);
            _Text.Text += "\r\n";

            //number in binary and converted back in deca
            _Text.Text += b.numberofdigits(1001010010).ToString();
            b.numeric2List(1001010010, ref b._numar); //594
            _Text.Text += ":";
            _Text.Text += b.printList(ref b._numar);
            _Text.Text += ":"; 
            _Text.Text += b.convertBinary2DecaInt(ref b._numar).ToString();
            
            _Text.Text += "\r\n";


            //convert deca 2 binay
            int xx = 594;
            List<int> list = new List<int>();
            list = d.convertDeca2BinaryInt(ref xx);
            b._numar.Clear();
            b._numar = list;
            _Text.Text += b.printList(ref b._numar);
            _Text.Text += ":";
            _Text.Text += xx.ToString();


            //convert deca 2 hex
            int xx2 = 2594;
            List<int> list2 = new List<int>();
            list2 = d.convertDeca2HexInt(ref xx2);
           sistemedenumeratie.hexa h = new sistemedenumeratie.hexa();
            h._numar.Clear();
            h._numar = list2;
            _Text.Text += "\r\n";
            _Text.Text += h.printListHexa(ref h._numar);
            _Text.Text += ":";
            _Text.Text += xx2.ToString();


        }
    }
}
