using System;

var baseSetting = new 
{ 
    ResolutionWidth = 1920, 
    ResolutionHeight = 1080, 
    Volume = 50, 
    Difficulty = "보통" 
};

var userSetting = new
{
    ResolutionWidth = 1920,
    ResolutionHeight = 1080,
    Volume = 80,
    Difficulty = "어려움"
};

Console.WriteLine("=== 게임 설정 비교 ===");
Console.WriteLine("[기본 설정]");
Console.WriteLine(baseSetting);
Console.WriteLine();

Console.WriteLine("[사용자 설정]");
Console.WriteLine(userSetting);
Console.WriteLine();

Console.WriteLine("[타입 비교]");
Console.WriteLine($"같은 타입: {baseSetting.GetType() == userSetting.GetType()} (속성 구조가 동일)");
Console.WriteLine();

Console.WriteLine("[값 비교]");
Console.WriteLine($"Equals 결과: {baseSetting.Equals(userSetting)} (Volume, Difficulty 값이 다름)");
Console.WriteLine();

Console.WriteLine("백업 설정]");
var backUpSetting = baseSetting;
Console.WriteLine(backUpSetting);
Console.WriteLine($"기본 설정과 Equals: {baseSetting.Equals(backUpSetting)} (모든 값이 동일)");
Console.WriteLine();

var settingArray = new[]
{
    baseSetting,
    userSetting, 
    backUpSetting 
};

Console.WriteLine("=== 설정 목록 (배열) ===");
foreach( var setting in settingArray)
{
    Console.WriteLine($"설정 1: {setting.ResolutionWidth}x{setting.ResolutionHeight}, 볼륨 {setting.Volume}, 난이도 {setting.Difficulty}"); 
}
Console.WriteLine();

Console.WriteLine("=== 속성 순서가 다른 설정 ===");
var newSetting = new { Volume = 50, Difficulty = "보통", ResolutionWidth = 1920, ResolutionHeight = 1080 };
Console.WriteLine($"기본 설정과 같은 타입: {baseSetting.Equals(newSetting)} (속성 순서가 달라 다른 타입)");