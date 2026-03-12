using System;

var weatherData = new[]
{
    new { Days = "월요일", HighTemp = 12, LowTemp = 3, Rain = 20},
    new { Days = "화요일", HighTemp = 8, LowTemp = -1, Rain = 60},
    new { Days = "수요일", HighTemp = 5, LowTemp = -3, Rain = 80},
    new { Days = "목요일", HighTemp = 10, LowTemp = 2, Rain = 40},
    new { Days = "금요일", HighTemp = 15, LowTemp = 5, Rain = 10}
};

double tempAvg = 0;
int availableRain = 0;

Console.WriteLine("=== 5일간 날씨 예보 ===");
Console.WriteLine($"{"요일"} {"최고기온",8} {"최저기온",8} {"강수확률",8}");
Console.WriteLine("------------------------------------------");

foreach (var weather in weatherData)
{
    Console.WriteLine($"{weather.Days} {weather.HighTemp,8}도 {weather.LowTemp,8}도 {weather.Rain,8}%");
    tempAvg += weather.HighTemp;
    if (weather.Rain >= 50) availableRain++;
}
tempAvg /= weatherData.Length;

Console.WriteLine("------------------------------------------");
Console.WriteLine($"최고기온 평균: {tempAvg:F1}도");
Console.WriteLine($"비 올 가능성 높은 날(50% 이상): {availableRain}일");