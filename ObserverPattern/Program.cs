using System;

namespace ObserverPattern {
	internal class Program {
		static void Main(string[] args) {
			WeatherData weatherData = new WeatherData();
			CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
			StatisticDisplay statisticDisplay = new StatisticDisplay(weatherData);
			ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
			weatherData.SetMeasurements(37,26, 21.7f);
			weatherData.SetMeasurements(39,24, 27.1f);
			weatherData.SetMeasurements(35,21, 32.4f);
			Console.WriteLine("ss");
		}
	}
}
