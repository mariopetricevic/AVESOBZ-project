using AVESOBZ.BaseLib;
using AVESOBZ.Controllers;
using AVESOBZ.MemoryBasedDAL;
using AVESOBZ.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVESOBZ.AppStarter
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			IWindowFormsFactory _formsFactory = new WindowFormsFactory();

			TicketRepository _ticketRepo = new TicketRepository();

			// umjesto Singleton patterna, imati ćemo samo jednu instancu repozitorija unutar glavnog programa
			

			// a za Profile repozitorij koristimo Singleton
			MainFormController mainController = new MainFormController(_formsFactory, ProfileRepository.getInstance(), _ticketRepo);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new AVESOBZ.PresentationLayer.frmMainWindow(mainController));
		}
	}
}
