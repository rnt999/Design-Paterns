﻿using Main.Structural_Patterns.Facade_Pattern.Models;

namespace Main.Structural_Patterns.Facade_Pattern
{
    public class TemperatureFacade
    {
        readonly WeatherService weatherService;
        readonly EnglishMetricConverter converter;

        public TemperatureFacade()
            : this(new WeatherService(), new EnglishMetricConverter())
        { }

        public TemperatureFacade(WeatherService weatherService, EnglishMetricConverter englishMetricConverter)
        {
            this.weatherService = weatherService;
            this.converter = englishMetricConverter;
        }

        public LocalTemperature GetTemperature()
        {
            var farenheit = weatherService.GetTempFarenheit();
            var celcius = converter.FarenheitToCelcious(farenheit);

            var localTemperature = new LocalTemperature()
            {
                Farenheit = farenheit,
                Celcius = celcius,
            };

            return localTemperature;
        }
    }
}
