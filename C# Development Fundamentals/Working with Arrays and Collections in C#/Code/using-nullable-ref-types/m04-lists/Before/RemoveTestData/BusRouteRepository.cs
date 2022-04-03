﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.ArraysCollections.Demos
{
	class BusRouteRepository
	{
		public static BusRoute[] InitializeRoutes()
		{
			return new BusRoute[] {
				new BusRoute(40, new string[]{
					"Morecambe", "Lancaster", "Garstang", "Preston" }),
				new BusRoute(42, new string[]{"Lancaster", "Garstang", "Blackpool" }),
				new BusRoute(5, new string[]{"Overton", "Morecambe", "Carnforth" }),
				new BusRoute(555, new string[]{
					"Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick" }),
				new BusRoute(1_000, new string[] { "Test origin", "Test destination" }),
			};
		}
	}

}
