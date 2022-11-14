using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern {
	public class WeatherData : ISubject {
		private ArrayList observers;
		private float temperature;
		private float humidity;
		private float pressure;

		public WeatherData() {
			observers = new ArrayList();
		}

		public void RegisterObserver(IObserver o) {
			observers.Add(o);
		}

		public void RemoveObserver(IObserver o) {
			observers.Remove(o);
		}

		public void NotifyObservers() {
			
			for (int i = 0; i < observers.Count; i++) {
				IObserver observer = (IObserver)observers[i];
				observer.Update(temperature, humidity, pressure);
			}
		}

		public void MeasurementsChanged() {
			NotifyObservers();
		}

		public void SetMeasurements(float temperature, float humidity, float pressure) { 
			this.temperature = temperature;
			this.humidity = humidity;
			this.pressure = pressure;
			MeasurementsChanged();
		}
	}
}
