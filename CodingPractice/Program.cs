using System;
using System.ComponentModel;
using System.Security.Cryptography;

var student = new { Name = "김철수", Grade = 3, Score = 95.5 };
Console.WriteLine($"이름: {student.Name}");
Console.WriteLine($"학년: {student.Grade}");
Console.WriteLine($"점수: {student.Score}");

string name = "이영희";
int age = 28;
var person1 = new {Name = name, Age = age};
var person2 = new { name, age };
Console.WriteLine($"person1: {person1.Name}, {person1.Age}");
Console.WriteLine($"person2: {person2.name}, {person2.age}");

string text = "Hello";

var info = new {text, text.Length};
Console.WriteLine($"텍스트: {info.text}");
Console.WriteLine($"길이: {info.Length}");

int productId = 100;
string productName = "마우스";
double price = 25000.0;

var product = new
{
    productId,
    Name = productName,
    price,
    FormattedPrice = price.ToString("N0")
};
Console.WriteLine($"ID: {product.productId}");
Console.WriteLine($"상품명: {product.Name}");
Console.WriteLine($"가격: {product.price}");
Console.WriteLine($"포맷된 가격: {product.FormattedPrice}");

var point1 = new { X = 10, Y = 20 };
var point2 = new { X = 30, Y = 40 };
bool isSameType = point1.GetType() == point2.GetType();
Console.WriteLine($"같은 타입: {isSameType}");

point1 = point2;
Console.WriteLine($"point1: ({point1.X}, {point1.Y})");

var a = new { X = 2, Y = 4 };
var b = new { X = 2, Y = 4 };
var c = new { X = 2, Y = 5 };

Console.WriteLine($"a.Equals(b): {a.Equals(b)}"); 
Console.WriteLine($"a.Equals(c): {a.Equals(c)}");

Console.WriteLine($"a == b: {a == b}");

// 같은 참조를 할당
c = a;
Console.WriteLine($"a == c: {a == c}");

var students = new[]
{
    new { Name = "김철수", Score = 85 },
    new { Name = "이영희", Score = 92 },
    new { Name = "박민수", Score = 78 }
};
Console.WriteLine("=== 학생 점수 목록 ===");
foreach(var s in students)
{   
    Console.WriteLine($"{s.Name}: {s.Score}점");
}

var products = new[]
{
    new { Id = 1, Name = "키보드", Price = 50000 },
    new { Id = 2, Name = "마우스", Price = 25000 },
    new { Id = 3, Name = "모니터", Price = 300000 }
};

Console.WriteLine($"첫 번째 상품: {products[0].Name}");
Console.WriteLine($"상품 개수: {products.Length}");
int total = 0;
foreach (var p in products)
{
    total += p.Price;
}
Console.WriteLine($"총 가격: {total:N0}원");

var obj = new { Id = 1, Name = "Object 1" };
Console.WriteLine($"{obj.Id} - {obj.Name}");
 
obj = new { Id = 2, Name = "Object 2" };
Console.WriteLine($"{obj.Id} - {obj.Name}");

var anonymousPerson = new { Name = "홍길동", Age = 30 };
var tuplePerson = (Name: "홍길동", Age: 30);
Console.WriteLine($"익명 타입: {anonymousPerson.Name}, {anonymousPerson.Age}");
Console.WriteLine($"튜플: {tuplePerson.Name}, {tuplePerson.Age}");

var person = new { Name = "김영희", Age = 25, City = "서울" };
Console.WriteLine(person.ToString());
Console.WriteLine(person);

var employees = new[]
{
    new { Name = "김철수", Department = "개발팀", Salary = 5000 },
    new { Name = "이영희", Department = "기획팀", Salary = 4500 },
    new { Name = "박민수", Department = "개발팀", Salary = 5500 }
};

Console.WriteLine("=== 직원 정보 ===");
foreach (var emp in employees)
{
    Console.WriteLine($"{emp.Name} ({emp.Department}) - {emp.Salary:N0}만원");
}

string[] names = { "사과", "바나나", "오렌지" };
int[] prices = { 1000, 1500, 2000 };
 
var fruits = new[]
{
    new { Name = names[0], Price = prices[0] },
    new { Name = names[1], Price = prices[1] },
    new { Name = names[2], Price = prices[2] }
};

Console.WriteLine("=== 과일 가격표 ===");
foreach (var fruit in fruits)
{
    Console.WriteLine($"{fruit.Name}: {fruit.Price}원");
}