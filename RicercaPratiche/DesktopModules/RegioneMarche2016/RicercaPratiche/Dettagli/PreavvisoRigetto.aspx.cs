﻿using RicercaPratiche.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RicercaPratiche.DesktopModules.RegioneMarche2016.RicercaPratiche.Dettagli
{
	public partial class PreavvisoRigetto : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			using (wsSisma16DBEntities _e = new wsSisma16DBEntities())
			{
				System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("it-IT");

				/* */
				int aid = Int32.Parse(this.Request.QueryString["aid"] ?? "1");
				var row = _e.tmpvB02DettaglioPratica.FirstOrDefault(w => w.IdRichiesta == aid);
				if (row == null)
					return;

				/* ------------------------- */

				if (row.DataAvvisoRigetto2.HasValue)
					this.ltl_DataInvioAvvisoRigetto.Text = row.DataAvvisoRigetto2.Value.ToShortDateString();
				else
					this.ltl_DataInvioAvvisoRigetto.Text = "---";

				/* ------------------------- */

				if (row.DataTrasmDecretoRigetto.HasValue)
					this.ltl_DataDecretoRigetto.Text = row.DataTrasmDecretoRigetto.Value.ToShortDateString();
				else
					this.ltl_DataDecretoRigetto.Text = "---";

			}
		}
	}
}