using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace utog_labar3.Pokalo
{
    public partial class pok : Form
    {
        private List<DiseaseData> _diseaseData;
        private Dictionary<string, Color> _diseaseColors;
        private bool _isForecastBuilt = false;

        public pok()
        {
            try
            {
                InitializeComponent();
                InitializeChart();
                InitializeDiseaseColors();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка инициализации: {ex.Message}");
            }
        }

        private void InitializeChart()
        {
            // Полностью очищаем график перед настройкой
            chart1.Series.Clear();
            chart1.Legends.Clear();
            chart1.ChartAreas[0].AxisY.IsLogarithmic = true; // Логарифмическая шкала
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0,0}"; // Формат чисел

            // Создаем новую область графика (если нужно)
            if (chart1.ChartAreas.Count == 0)
            {
                chart1.ChartAreas.Add(new ChartArea());
            }

            // Настраиваем оси
            chart1.ChartAreas[0].AxisX.Title = "Год";
            chart1.ChartAreas[0].AxisY.Title = "Количество случаев";
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            // Создаем и настраиваем легенду
            Legend legend = new Legend
            {
                Name = "MainLegend",
                Docking = Docking.Bottom,
                LegendStyle = LegendStyle.Row,
                Alignment = StringAlignment.Center
            };
            chart1.Legends.Add(legend);

            // Добавляем заголовок
            chart1.Titles.Clear();
            chart1.Titles.Add(new Title
            {
                Text = "Динамика инфекционных заболеваний в России",
                Font = new Font("Arial", 12, FontStyle.Bold)
            });
        }

        private void InitializeDiseaseColors()
        {
            _diseaseColors = new Dictionary<string, Color>
            {
                { "Грипп", Color.Blue },
                { "Корь", Color.Green },
                { "Туберкулез", Color.Orange },
                { "Ветряная оспа", Color.Purple },
                { "Коклюш", Color.Brown }
            };
        }

        private void DisplayDataInGrid()
        {
            dataGridView1.DataSource = _diseaseData
                .OrderBy(d => d.DiseaseName)
                .ThenBy(d => d.Year)
                .ToList();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BuildInitialCharts()
        {
            // Очищаем все существующие серии
            chart1.Series.Clear();

            foreach (var disease in _diseaseData.Select(d => d.DiseaseName).Distinct())
            {
                // Создаем новую серию
                var series = new Series(disease)
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 3,
                    Color = _diseaseColors.ContainsKey(disease) ? _diseaseColors[disease] : Color.Gray,
                    Legend = "MainLegend" // Явно указываем имя легенды
                };

                // Добавляем точки данных
                foreach (var point in _diseaseData.Where(d => d.DiseaseName == disease).OrderBy(d => d.Year))
                {
                    series.Points.AddXY(point.Year, point.CasesCount);
                }

                chart1.Series.Add(series);
            }
        }


        private void AnalyzeData()
        {
            // Пример простого анализа - можно расширить
            var maxCases = _diseaseData.OrderByDescending(d => d.CasesCount).First();
            label1.Text = $"Макс. случаев: {maxCases.DiseaseName} ({maxCases.CasesCount} в {maxCases.Year} г.";
        }



        // Остальные методы-заглушки
        private void label1_Click(object sender, EventArgs e) { }
        private void chart1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }

        private Dictionary<string, List<double>> _lastForecast = new Dictionary<string, List<double>>();
        private int _lastForecastYear;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (_lastForecast.Count == 0)
                {
                    MessageBox.Show("Сначала постройте прогноз (кнопка 2)");
                    return;
                }

                // Добавляем точки к существующим сериям
                foreach (var disease in _lastForecast.Keys)
                {
                    var series = chart1.Series.FindByName(disease);
                    if (series == null) continue;

                    var forecast = _lastForecast[disease];
                    for (int i = 0; i < forecast.Count; i++)
                    {
                        DataPoint point = new DataPoint(_lastForecastYear + i + 1, forecast[i])
                        {
                            Color = Color.Red,
                            BorderWidth = 2,
                            MarkerStyle = MarkerStyle.Circle,
                            MarkerSize = 8
                        };
                        series.Points.Add(point);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления точек: {ex.Message}");
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "JSON files (*.json)|*.json",
                    Title = "Выберите файл с данными"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _diseaseData = DataLoader.LoadData(openFileDialog.FileName);
                    DisplayDataInGrid();
                    BuildInitialCharts();
                    AnalyzeData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Проверка наличия данных
                if (_diseaseData == null || _diseaseData.Count == 0)
                {
                    MessageBox.Show("Нет данных для прогнозирования. Сначала загрузите данные.",
                                  "Ошибка",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                // Проверка ввода количества лет
                if (!int.TryParse(numericUpDown2.Text, out int forecastYears) || forecastYears <= 0)
                {
                    MessageBox.Show("Введите корректное число лет для прогноза (больше 0)",
                                  "Ошибка ввода",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                // Получаем размер окна для скользящего среднего
                int windowSize = (int)numericUpDown1.Value;
                if (windowSize <= 0 || windowSize > _diseaseData.Count)
                {
                    MessageBox.Show($"Размер окна должен быть от 1 до {_diseaseData.Count}",
                                  "Ошибка ввода",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                // Очищаем предыдущий прогноз
                _lastForecast.Clear();

                // Получаем последний год в данных
                _lastForecastYear = _diseaseData.Max(d => d.Year);

                // Удаляем старые прогнозные серии (если есть)
                var seriesToRemove = chart1.Series
                    .Where(s => s.Name.StartsWith("Прогноз"))
                    .ToList();

                foreach (var series in seriesToRemove)
                {
                    chart1.Series.Remove(series);
                }

                // Строим прогноз для каждого заболевания
                foreach (var disease in _diseaseData.Select(d => d.DiseaseName).Distinct())
                {
                    // Получаем исторические данные для заболевания
                    var diseaseData = _diseaseData
                        .Where(d => d.DiseaseName == disease)
                        .OrderBy(d => d.Year)
                        .Select(d => (double)d.CasesCount)
                        .ToList();

                    // Рассчитываем прогноз с учетом тренда
                    var forecast = MovingAverageCalculator.ForecastWithTrend(diseaseData, windowSize, forecastYears);

                    // Сохраняем прогноз для использования в button3_Click
                    _lastForecast[disease] = forecast;

                    // Находим соответствующую основную серию на графике
                    var mainSeries = chart1.Series.FindByName(disease);
                    if (mainSeries == null) continue;

                    // Создаем новую серию для прогноза
                    var forecastSeries = new Series($"Прогноз {disease}")
                    {
                        ChartType = SeriesChartType.Line,
                        Color = Color.Red,
                        BorderWidth = 2,
                        BorderDashStyle = ChartDashStyle.Dash,
                        MarkerStyle = MarkerStyle.Circle,
                        MarkerSize = 8,
                        MarkerColor = Color.Red,
                        Legend = "MainLegend"
                    };

                    // Добавляем точки прогноза
                    for (int i = 0; i < forecast.Count; i++)
                    {
                        forecastSeries.Points.AddXY(_lastForecastYear + i + 1, forecast[i]);
                    }

                    // Добавляем серию на график
                    chart1.Series.Add(forecastSeries);
                }

                // Обновляем график
                chart1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при построении прогноза: {ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

    }
}
