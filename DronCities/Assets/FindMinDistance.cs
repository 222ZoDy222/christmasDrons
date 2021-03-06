using System;
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

		public List<City> rightSideOfMap = new List<City>();
		public List<City> leftSideOfMap = new List<City>();

		public FindMinDistance(Country country)
		{
			for(int i = 0; i < country.Cities.Count; i++)
			{
				if((country.StartPoint.y - country.Cities[i].y) < -17 && (country.StartPoint.x - country.Cities[i].x) < 0)
				{
					RightDown.Add(country.Cities[i]);
					rightSideOfMap.Add(country.Cities[i]);
					country.Cities[i].color = new CityColor(0,255,10);

				}
				else if((country.StartPoint.y - country.Cities[i].y) < -17 && (country.StartPoint.x - country.Cities[i].x) > 0)
				{
					RightUp.Add(country.Cities[i]);
					rightSideOfMap.Add(country.Cities[i]);
					country.Cities[i].color = new CityColor(0, 255, 10);
				}
				else if((country.StartPoint.y - country.Cities[i].y) > -17 && (country.StartPoint.x - country.Cities[i].x) > 0)
				{
					LeftUp.Add(country.Cities[i]);
					leftSideOfMap.Add(country.Cities[i]);
					country.Cities[i].color = new CityColor(0, 0, 255);
				}
				else
				{
					LeftDown.Add(country.Cities[i]);
					leftSideOfMap.Add(country.Cities[i]);
					country.Cities[i].color = new CityColor(0, 0, 255);
				}
			}

		}

		public void FindAllDistanceFromStartPoint()
		{

		}

		/// <summary>
		/// Считает дистацию между 2-мя городами
		/// </summary>
		/// <param name="city1"></param>
		/// <param name="city2"></param>
		/// <returns></returns>
		static public double FindDistance(City city1, City city2)
        {
			double res = 0;

			double a = Math.Abs(city2.x - city1.x);
			double b = Math.Abs(city2.y - city1.y);

			res = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));


			return res;
        }

		/// <summary>
		/// Возвращает самый ближайший город
		/// </summary>
		/// <param name="city"></param>
		/// <param name="Side"></param>
		/// <returns></returns>
		static public City FindAllDistance(City city, List<City> Side)
        {
			double res = 0;
			double Min = double.MaxValue;
			City minDistanceCity = new City();
			//double res = FindMinDistance.FindDistance(Russia.Cities[0], Russia.Cities[1]);
			for (int i = 0; i < Side.Count; i++)
            {
				if (FindDistance(city, Side[i]) < Min && Side[i].Visit == false)
                {
					Min = FindDistance(city, Side[i]);
					minDistanceCity = Side[i];
				}

			}


			return minDistanceCity;
        }

		/// <summary>
		/// Возвращает самый дальний город
		/// </summary>
		/// <param name="city"></param>
		/// <param name="Side"></param>
		/// <returns></returns>
		static public City FindAllDistanceMAX(City city, List<City> Side)
		{
			double res = 0;
			double Max = double.MinValue;
			City MaxDistanceCity = new City();
			//double res = FindMinDistance.FindDistance(Russia.Cities[0], Russia.Cities[1]);
			for (int i = 0; i < Side.Count; i++)
			{
				if (FindDistance(city, Side[i]) > Max && Side[i].Visit == false)
				{
					Max = FindDistance(city, Side[i]);
					MaxDistanceCity = Side[i];
				}

			}


			return MaxDistanceCity;
		}


		/// <summary>
		/// Возвращает 20 самых ближайших городов от города в первом параметре
		/// </summary>
		/// <param name="city"></param>
		/// <param name="Side"></param>
		/// <returns></returns>
		static public City[] FindListClosedCities(City city, List<City> Side)
		{
			var res = new City[100];
			var ShitName = new City();
			for(int i = 0; i < res.Length; i++)
			{
				res[i] = Side[0];
			}
			//double Min = double.MinValue;
			for (int i = 0; i < Side.Count; i++)
			{
				for(int j = 0; j < res.Length; j++)
				{
					
					if (FindDistance(city, Side[i]) < FindDistance(city, res[j]))
					{
						for(int k = j; k < res.Length - 1; k++)
						{
							res[j + 1] = res[j];
						}
						res[j] = Side[i];
						break;
					}
					else
					{
						for(int jj = 0; jj < res.Length; jj++)
						{
							if(res[jj].name == ShitName.name)
							{
								ShitName = res[jj];
								res[jj] = Side[i];
								break;
							}
						}
					}
				}
					
			}
			res[99] = Side[0];
			return res;
		}



		//static public City FindLeftMinDistance(City city, List<City> Side)
		//      {
		//	double res = 0;
		//	double Min = double.MaxValue;
		//	City MaxDistanceCity = new City();
		//	//double res = FindMinDistance.FindDistance(Russia.Cities[0], Russia.Cities[1]);
		//	for (int i = 0; i < Side.Count; i++)
		//	{
		//		if (FindDistance(city, Side[i]) < Min && Side[i].Visit == false && (city.x-Side[i].x) < 0)
		//		{
		//			Min = FindDistance(city, Side[i]);
		//			MaxDistanceCity = Side[i];
		//		}

		//	}

		//	return MaxDistanceCity;
		//}

		//static public City FindRightMinDistance(City city, List<City> Side)
		//{
		//	double res = 0;
		//	double Min = double.MaxValue;
		//	City MaxDistanceCity = new City();
		//	//double res = FindMinDistance.FindDistance(Russia.Cities[0], Russia.Cities[1]);
		//	for (int i = 0; i < Side.Count; i++)
		//	{
		//		if (FindDistance(city, Side[i]) < Min && Side[i].Visit == false && (city.x - Side[i].x) > 0)
		//		{
		//			Min = FindDistance(city, Side[i]);
		//			MaxDistanceCity = Side[i];
		//		}

		//	}
		//	return MaxDistanceCity;
		//}

		//static public City FindDownMinDistance(City city, List<City> Side)
		//{
		//	double res = 0;
		//	double Min = double.MaxValue;
		//	City MaxDistanceCity = new City();
		//	//double res = FindMinDistance.FindDistance(Russia.Cities[0], Russia.Cities[1]);
		//	for (int i = 0; i < Side.Count; i++)
		//	{
		//		if (FindDistance(city, Side[i]) < Min && Side[i].Visit == false && (city.y - Side[i].y) > 0)
		//		{
		//			Min = FindDistance(city, Side[i]);
		//			MaxDistanceCity = Side[i];
		//		}

		//	}
		//	return MaxDistanceCity;
		//}

		//static public City FindUpMinDistance(City city, List<City> Side)
		//{
		//	double res = 0;
		//	double Min = double.MaxValue;
		//	City MaxDistanceCity = new City();
		//	//double res = FindMinDistance.FindDistance(Russia.Cities[0], Russia.Cities[1]);
		//	for (int i = 0; i < Side.Count; i++)
		//	{
		//		if (FindDistance(city, Side[i]) < Min && Side[i].Visit == false && (city.x - Side[i].x) > 0)
		//		{
		//			Min = FindDistance(city, Side[i]);
		//			MaxDistanceCity = Side[i];
		//		}

		//	}
		//	return MaxDistanceCity;
		//}

	}
}
