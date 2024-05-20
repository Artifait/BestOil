using Microsoft.Win32;
using System;

namespace BestOil
{
	static class Settings
	{
		// Cafe product price
		static public double hotDogPrice = 50;
		static public double hamburgerPrice = 75;
		static public double frenchFriesPrice = 60;
		static public double cocaColaPrice = 45;

		// Gas types price
		static public double a92Price = 50.00;
		static public double a95Price = 60.00;

		static public double GetOilPrice(TypeOil type)
        {
            return type switch
            {
                TypeOil.Oil92 => a92Price,
                TypeOil.Oil95 => a95Price,
                _ => (double)0f,
            };
        }


		static public int pauseDuration = 10;
		static public string currency = "RUB";
		static public double gain = 0.00;

		static string regKeyName = "Software\\Artifait\\BestOil";

		static public void ReadSettings()
		{
			RegistryKey rk = null;

			try
			{
				rk = Registry.CurrentUser.OpenSubKey(regKeyName);

				if (rk != null)
				{
					hotDogPrice = Convert.ToDouble(rk.GetValue("HotDog"));
					hamburgerPrice = Convert.ToDouble(rk.GetValue("Hamburger"));
					frenchFriesPrice = Convert.ToDouble(rk.GetValue("FrenchFries"));
					cocaColaPrice = Convert.ToDouble(rk.GetValue("CocaCola"));

					a92Price = Convert.ToDouble(rk.GetValue("A92"));
					a95Price = Convert.ToDouble(rk.GetValue("A95"));

					pauseDuration = Convert.ToInt32(rk.GetValue("Pause"));
					currency = rk.GetValue("Currency").ToString();
					gain = Convert.ToDouble(rk.GetValue("Gain"));
				}
			}
			finally
			{
				if (rk != null) rk.Close();
			}
		}

		static public void WriteSettings()
		{
			RegistryKey rk = null;

			try
			{
				rk = Registry.CurrentUser.CreateSubKey(regKeyName);
				if (rk == null) return;

				rk.SetValue("HotDog", hotDogPrice);
				rk.SetValue("Hamburger", hamburgerPrice);
				rk.SetValue("FrenchFries", frenchFriesPrice);
				rk.SetValue("CocaCola", cocaColaPrice);

				rk.SetValue("A92", a92Price);
				rk.SetValue("A95", a95Price);

				rk.SetValue("Pause", pauseDuration);
				rk.SetValue("Currency", currency);
				rk.SetValue("Gain", gain);
			}
			finally
			{
				if (rk != null) rk.Close();
			}
		}
	}
}
