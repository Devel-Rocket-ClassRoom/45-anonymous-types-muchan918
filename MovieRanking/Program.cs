using System;

string title = "인터스텔라";
string genre = "SF";
double rating = 9.2;
int releaseYear = 2014;

var MovieInfo = new
{
    title,
    genre,
    rating,
    releaseYear
};

Console.WriteLine("=== 영화 정보 ===");
Console.WriteLine($"제목: {MovieInfo.title}");
Console.WriteLine($"장르: {MovieInfo.genre}");
Console.WriteLine($"평점: {MovieInfo.rating}");
Console.WriteLine($"개봉연도: {MovieInfo.releaseYear}");
Console.WriteLine();

Console.WriteLine("ToString 결과:");
Console.WriteLine(MovieInfo.ToString());

