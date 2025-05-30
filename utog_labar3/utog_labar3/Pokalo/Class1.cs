using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utog_labar3.Pokalo
{
    public static class MovingAverageCalculator
    {
        // Основной метод для расчета скользящего среднего
        public static List<double> Calculate(List<double> data, int windowSize)
        {
            if (windowSize <= 0 || windowSize > data.Count)
                throw new ArgumentException("Некорректный размер окна");

            List<double> movingAverages = new List<double>();

            for (int i = 0; i <= data.Count - windowSize; i++)
            {
                double windowSum = 0;
                for (int j = i; j < i + windowSize; j++)
                {
                    windowSum += data[j];
                }
                movingAverages.Add(windowSum / windowSize);
            }

            return movingAverages;
        }

        // Стандартный метод прогноза (без учета тренда)
        public static List<double> Forecast(List<double> data, int windowSize, int periods)
        {
            if (data == null || data.Count == 0)
                throw new ArgumentException("Нет данных для прогноза");

            List<double> forecast = new List<double>();
            List<double> movingAverages = Calculate(data, windowSize);

            for (int i = 0; i < periods; i++)
            {
                double sum = 0;
                int start = Math.Max(0, movingAverages.Count - windowSize);
                for (int j = start; j < movingAverages.Count; j++)
                {
                    sum += movingAverages[j];
                }
                double nextValue = sum / Math.Min(windowSize, movingAverages.Count);
                forecast.Add(nextValue);
                movingAverages.Add(nextValue);
            }

            return forecast;
        }

        // Улучшенный метод прогноза с учетом тренда
        public static List<double> ForecastWithTrend(List<double> data, int windowSize, int periods)
        {
            if (data == null || data.Count == 0)
                throw new ArgumentException("Нет данных для прогноза");

            // Рассчитываем скользящие средние
            List<double> movingAverages = Calculate(data, windowSize);

            // Линейная регрессия для вычисления тренда (y = a*x + b)
            double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;
            int n = movingAverages.Count;

            for (int i = 0; i < n; i++)
            {
                sumX += i;               // x (время)
                sumY += movingAverages[i]; // y (значения)
                sumXY += i * movingAverages[i];
                sumX2 += i * i;
            }

            double a = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX); // Наклон тренда
            double b = (sumY - a * sumX) / n;                                // Пересечение

            // Прогнозируем с учетом тренда
            List<double> forecast = new List<double>();
            for (int i = 0; i < periods; i++)
            {
                double nextValue = a * (n + i) + b;
                forecast.Add(nextValue);
            }

            return forecast;
        }
    }
}


