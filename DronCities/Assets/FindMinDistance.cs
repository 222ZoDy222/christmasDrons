﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronCities.Assets
{
	public class FindMinDistance
	{

		public List<City> LeftDown = new List<City>();
		public List<City> LeftUp = new List<City>();
		public List<City> RightDown = new List<City>();
		public List<City> RightUp = new List<City>();


		public FindMinDistance(Country country)
		{
			for(int i = 0; i < country.Cities.Count; i++)
			{
				if((country.StartPoint.y - country.Cities[i].y) < 0 && (country.StartPoint.x - country.Cities[i].x) < 0)
				{
					RightUp.Add(country.Cities[i]);
				}
				else if((country.StartPoint.y - country.Cities[i].y) < 0 && (country.StartPoint.x - country.Cities[i].x) > 0)
				{
					RightDown.Add(country.Cities[i]);
				}
				else if((country.StartPoint.y - country.Cities[i].y) > 0 && (country.StartPoint.x - country.Cities[i].x) > 0)
				{
					LeftUp.Add(country.Cities[i]);
				}
				else
				{
					LeftDown.Add(country.Cities[i]);
				}
			}

		}

		public void FindAllDistanceFromStartPoint()
		{

		}

	}
}
