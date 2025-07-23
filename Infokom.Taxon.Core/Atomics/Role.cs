using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infokom.Taxon.Core.Atomics
{
	public enum Role
	{
		/// <summary>
		/// End user who books trips
		/// </summary>
		Client = 1,

		/// <summary>
		/// Fulfills the trip requests
		/// </summary>
		Driver = 2,

		/// <summary>
		/// Manages trip assignments and flow
		/// </summary>
		Dispatcher = 3,
	}
}
