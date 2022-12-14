using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern {
	public class ForecastDisplay : IObserver, IDisplayElement {
		private float temperature;
		private float humidity;
		private ISubject weatherData;
		public ForecastDisplay(ISubject weatherData) {
			this.weatherData = weatherData;
			weatherData.RegisterObserver(this);
		}
		public void Display() {
			Console.WriteLine("Forecast: " + temperature + "F degrees and " + humidity + "% humiduty");
		}

		public void Update(float temp, float humidity, float pressure) {
			this.temperature = temp;
			this.humidity = humidity;
			Display();
		}
	}
}
