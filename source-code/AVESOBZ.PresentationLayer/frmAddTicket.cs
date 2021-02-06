using AVESOBZ.BaseLib;
using AVESOBZ.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVESOBZ.PresentationLayer
{
    public partial class frmAddTicket : Form, IAddNewTicketView
    {

		
		public frmAddTicket()
		{

			InitializeComponent();
		}
		public string Label1
        {
            get { return this.label1.Text; }
            set { this.label1.Text = value; }
        }

		public bool ShowViewModal()
		{
			if (this.ShowDialog() == DialogResult.OK)
				return true;
			else
				return false;
		}
		string inMjesto1;
		string inMjesto2;

		private void CalculatePriceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result;
			Random rnd = new Random();
			float inprice = rnd.Next(20, 250);
			string cijena;
			string message = "Cijena karte bez popusta iznosi: ";
			cijena = inprice.ToString();

		

			result = MessageBox.Show(message+ cijena+ " Kn."+ " Želite li kupiti kartu?", "Kupnja karte", buttons);
			if (result==DialogResult.Yes)
            {
				txtPrice.Text = cijena;
				inMjesto1 = txtMjesto1.Text;
				inMjesto2 = txtMjesto2.Text;
			

			}
            else
            {
				this.Close();
            }
			
		}
		public string price => txtPrice.Text;

		public string Mjesto1 => inMjesto1;

		public string Mjesto2 => inMjesto2;
    }
}
