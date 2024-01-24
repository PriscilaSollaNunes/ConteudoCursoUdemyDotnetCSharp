//Demo
//DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
//DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
//Console.WriteLine("d1: " + d1);
//Console.WriteLine("d1 Kind: " + d1.Kind);
//Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
//Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
//Console.WriteLine();
//Console.WriteLine("d2: " + d2);
//Console.WriteLine("d2 Kind: " + d2.Kind);
//Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
//Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
//Console.WriteLine();
//Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
//Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

//Demo
//DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
//DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
//DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
//Console.WriteLine("d1: " + d1);
//Console.WriteLine("d1 Kind: " + d1.Kind);
//Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
//Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
//Console.WriteLine();
//Console.WriteLine("d2: " + d2);
//Console.WriteLine("d2 Kind: " + d2.Kind);
//Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
//Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
//Console.WriteLine();
//Console.WriteLine("d3: " + d3);
//Console.WriteLine("d3 Kind: " + d3.Kind);
//Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
//Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());

////Demo - operações
//TimeSpan t1 = new TimeSpan(1, 30, 10);
//TimeSpan t2 = new TimeSpan(0, 10, 5);
//TimeSpan sum = t1.Add(t2);
//TimeSpan dif = t1.Subtract(t2);
//TimeSpan mult = t2.Multiply(2.0);
//TimeSpan div = t2.Divide(2.0);
//Console.WriteLine(t1);
//Console.WriteLine(t2);
//Console.WriteLine(sum);
//Console.WriteLine(dif);
//Console.WriteLine(mult);
//Console.WriteLine(div);


// Demo - propriedades
//TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
//Console.WriteLine(t);
//Console.WriteLine("Days: " + t.Days);
//Console.WriteLine("Hours: " + t.Hours);
//Console.WriteLine("Minutes: " + t.Minutes);
//Console.WriteLine("Milliseconds: " + t.Milliseconds);
//Console.WriteLine("Seconds: " + t.Seconds);
//Console.WriteLine("Ticks: " + t.Ticks);
//Console.WriteLine("TotalDays: " + t.TotalDays);
//Console.WriteLine("TotalHours: " + t.TotalHours);
//Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
//Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
//Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);



//DateTime




//Operações com Datetime

//Formatação(DateTime-> string)
//DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);
//string s1 = d.ToLongDateString();
//string s2 = d.ToLongTimeString();
//string s3 = d.ToShortDateString();
//string s4 = d.ToShortTimeString();
//string s5 = d.ToString();
//string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
//string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
//Console.WriteLine(s1);
//Console.WriteLine(s2);
//Console.WriteLine(s3);
//Console.WriteLine(s4);
//Console.WriteLine(s5);
//Console.WriteLine(s6);
//Console.WriteLine(s7);




//Demo
//DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
//Console.WriteLine(d);
//Console.WriteLine("1) Date: " + d.Date);
//Console.WriteLine("2) Day: " + d.Day);
//Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
//Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
//Console.WriteLine("5) Hour: " + d.Hour);
//Console.WriteLine("6) Kind: " + d.Kind);
//Console.WriteLine("7) Millisecond: " + d.Millisecond);
//Console.WriteLine("8) Minute: " + d.Minute);
//Console.WriteLine("9) Month: " + d.Month);
//Console.WriteLine("10) Second: " + d.Second);
//Console.WriteLine("11) Ticks: " + d.Ticks);
//Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
//Console.WriteLine("13) Year: " + d.Year);


//Demo - construtores
//TimeSpan t1 = new TimeSpan();
//TimeSpan t2 = new TimeSpan(900000000L);
//TimeSpan t3 = new TimeSpan(2, 11, 21);
//TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
//TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
//Console.WriteLine(t1);
//Console.WriteLine(t2);
//Console.WriteLine(t3);
//Console.WriteLine(t4);
//Console.WriteLine(t5);

//using System.Globalization;


//TimeSpan t1 = new TimeSpan(0, 1, 30);
//Console.WriteLine(t1);
//Console.WriteLine(t1.Ticks);

//Demo - ParseExact
//DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
//CultureInfo.InvariantCulture);
//DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
//CultureInfo.InvariantCulture);
//Console.WriteLine(d1);
//Console.WriteLine(d2);

//Demo - Parse
//DateTime d1 = DateTime.Parse("2000-08-15");
//DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
//DateTime d3 = DateTime.Parse("15/08/2000");
//DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");
//Console.WriteLine(d1);
//Console.WriteLine(d2);
//Console.WriteLine(d3);
//Console.WriteLine(d4);


//Demo - Now, UtcNow, Today
//DateTime d1 = DateTime.Now;
//DateTime d2 = DateTime.UtcNow;
//DateTime d3 = DateTime.Today;
//Console.WriteLine(d1);
//Console.WriteLine(d2);
//Console.WriteLine(d3);

//DateTime d1 = DateTime.Now;
//Console.WriteLine(d1);



//Demo - construtores
//DateTime d1 = new DateTime(2000, 8, 15);
//DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
//DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
//Console.WriteLine(d1);
//Console.WriteLine(d2);
//Console.WriteLine(d3);




//Funções 

//string original = "abcde FGHIJ ABC abc DEFG ";
//string s1 = original.ToUpper();
//string s2 = original.ToLower();
//string s3 = original.Trim();
//int n1 = original.IndexOf("bc");
//int n2 = original.LastIndexOf("bc");
//string s4 = original.Substring(3);
//string s5 = original.Substring(3, 5);
//string s6 = original.Replace('a', 'x');
//string s7 = original.Replace("abc", "xy");
//bool b1 = String.IsNullOrEmpty(original);
//bool b2 = String.IsNullOrWhiteSpace(original);
//Console.WriteLine("Original: -" + original + "-");
//Console.WriteLine("ToUpper: -" + s1 + "-");
//Console.WriteLine("ToLower: -" + s2 + "-");
//Console.WriteLine("Trim: -" + s3 + "-");
//Console.WriteLine("IndexOf('bc'): " + n1);
//Console.WriteLine("LastIndexOf('bc'): " + n2);
//Console.WriteLine("Substring(3): -" + s4 + "-");
//Console.WriteLine("Substring(3, 5): -" + s5 + "-");
//Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
//Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
//Console.WriteLine("IsNullOrEmpty: " + b1);
//Console.WriteLine("IsNullOrWhiteSpace: " + b2);
