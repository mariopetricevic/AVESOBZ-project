using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVESOBZ.BaseLib;

namespace AVESOBZ.PresentationLayer
{
    public partial class frmAddProfile : Form, IAddNewProfileView
	{

		public frmAddProfile()
		{

			InitializeComponent();
		}


		public bool ShowViewModal()
		{
			if (this.ShowDialog() == DialogResult.OK)
				return true;
			else
				return false;
		}

		public string Ime => txtIme.Text;
		public string Prezime => txtPrezime.Text;
		public string Mjesto => txtMjesto.Text;
		public string Kontakt => txtKontakt.Text;

		public string Potvrda => txtPotvrda.Text;

    }
}
