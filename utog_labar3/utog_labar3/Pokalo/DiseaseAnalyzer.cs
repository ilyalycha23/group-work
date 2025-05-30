using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utog_labar3.Pokalo
{
    public static class DiseaseAnalyzer
    {
        public static (string maxDecreaseDisease, string minDecreaseDisease,
                      Dictionary<string, double> allDecreases)
            AnalyzeDiseaseDecrease(List<DiseaseData> data)
        {
            var diseases = data.Select(d => d.DiseaseName).Distinct();
            var results = new Dictionary<string, double>();

            foreach (var disease in diseases)
            {
                var diseaseData = data
                    .Where(d => d.DiseaseName == disease)
                    .OrderBy(d => d.Year)
                    .ToList();

                if (diseaseData.Count < 2) continue;

                double firstYear = diseaseData.First().CasesCount;
                double lastYear = diseaseData.Last().CasesCount;
                double decreasePercent = (firstYear - lastYear) / firstYear * 100;

                results[disease] = decreasePercent;
            }

            string maxDecrease = results.OrderByDescending(r => r.Value).First().Key;
            string minDecrease = results.OrderBy(r => r.Value).First().Key;

            return (maxDecrease, minDecrease, results);
        }
    }
}
