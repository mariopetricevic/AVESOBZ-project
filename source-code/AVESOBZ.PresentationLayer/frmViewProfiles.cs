using AVESOBZ.BaseLib;
using AVESOBZ.Model;
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
	public partial class frmViewProfiles : Form, IShowProfilesListView
	{
		private List<Profile> _listProfiles = null;
		private IMainFormController _mainController = null;

		public frmViewProfiles()
		{
			InitializeComponent();
		}

		public void ShowModaless(IMainFormController inMainController, List<Profile> inListProfiles)
		{
			_mainController = inMainController;
			_listProfiles = inListProfiles;

			UpdateList();

			this.Show();
		}

		private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
			
				try
				{
					_mainController.DeleteProfile(listProfiles.SelectedItems[0].Index);
					this.Close();
				}
				catch (Exception)
				{
					DialogResult dl = MessageBox.Show("Zelite li sigurno obrisati profil?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (dl == DialogResult.Yes)
					{
						_mainController.DeleteProfile(listProfiles.SelectedItems[0].Index);
						this.Close();
					}

				}
			}
			
            

			
        

		private void btnAddNewProfile_Click(object sender, EventArgs e)
		{
			_mainController.AddProfile();
		}
		private void listProfiles_DoubleClick(object sender, EventArgs e)
		{
			if (listProfiles.SelectedItems[0] != null)
			{
				int ind = listProfiles.SelectedItems[0].Index;
				string Ime = listProfiles.SelectedItems[0].SubItems[0].Text;
				string Prezime = listProfiles.SelectedItems[0].SubItems[0].Text;
				string Mjesto = listProfiles.SelectedItems[0].SubItems[0].Text;

				//_mainController.EditProfile(Ime, Prezime, Mjesto);
			}
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void UpdateList()
		{
			for (int i = 0; i < _listProfiles.Count(); i++)
			{
				Profile acc = _listProfiles[i];

				string Ime = acc.Ime;
				string Mjesto = acc.Mjesto;
				string Prezime = acc.Prezime;
				string Kontakt = acc.Kontakt;
				string Potvrda = acc.Potvrda;
				int Id = acc.Id;


				ListViewItem lvt = new ListViewItem(acc.Id.ToString());
				lvt.SubItems.Add(Ime);
				lvt.SubItems.Add(Prezime);
				lvt.SubItems.Add(Mjesto);
				lvt.SubItems.Add(Kontakt);
				lvt.SubItems.Add(Potvrda);
			

				listProfiles.Items.Add(lvt);
			}
		}
	}
}
