/*
 * 1. telebe balini daxil edir bu bala uygun, herf bali tapirsiniz.
   (Meselen: 91 -> A, 75 -> C)
   2. 2 eded daxil olunur, eger ededlerin her ikisi 2'ye galiqsiz bolunurse,
   cemini tapirsiniz, eks halda ekrana "daxil olunan ededler cut olmalidir!" yazisini yazdirirsiniz.
   3. maas ve kredit deyerleri daxil olur. Eger istifadecinin daxil etdiyi kredit deyeri,
   illik maasin 60%'den azdirsa, ekrana "Kredit goture bilmezsiniz!".
   eks halda "Kredit goture bilersiniz!" yazdirirsiniz.
   4. 2 reqemli bir eded daxil olunur, ededin onlugunun yoxsa,
   tekliyinin boyuk oldugunu ekrana yazdirirsiniz.
   5. duzbucaqlinin sahe ve perimetrini tapin.
   6. 2 variable daxil olunur value'larinin yerini deyishirsiniz.
   (Mes: a = 5; b = 10 => a =10; b = 5)
 */

// Task 1:
// Console.WriteLine("Balinizi daxil edin: ");
// int score = Convert.ToInt32(Console.ReadLine());
//
// if (score >= 91) {
//     Console.WriteLine("A");
// }else if (score >= 81) {
//     Console.WriteLine("B");
// }else if (score >= 71) {
//     Console.WriteLine("C");
// }else if (score >= 61) {
//     Console.WriteLine("D");
// }else if (score >= 51) {
//     Console.WriteLine("E");
// }else {
//     Console.WriteLine("F");
// }

// Task 2:
// Console.WriteLine("Birinci ededi daxil edin: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
//  
// Console.WriteLine("Ikinci ededi daxil edin: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
//
// if (num1 % 2 == 0 && num2 % 2 == 0) {
//     Console.WriteLine("Cem: " + (num1 + num2));
// }else {
//     Console.WriteLine("daxil olunan ededler cut olmalidir!");
// }

// Task 3:
// Console.WriteLine("Maasinizi daxil edin: ");
// double maas = Convert.ToDouble(Console.ReadLine());
//  
// Console.WriteLine("Kredit deyerini daxil edin: ");
// double kredit = Convert.ToDouble(Console.ReadLine());
//
// if (((maas * 12) * 0.6) < kredit) {
//     Console.WriteLine("Kredit goture bilmezsiniz!");
// }else {
//     Console.WriteLine("Kredit goture bilersiniz!");
// }

// Task 4:
// int num = Convert.ToInt32(Console.ReadLine());
//
// int count = 0;
// int temp = num;
//
// while(temp != 0){
//     temp /= 10;
//     count++;
// }
//
// if (count == 2)
// {
//     if (num / 10 > num % 10) {
//         Console.WriteLine("Onluq boyukdur.");
//     }else if (num / 10 < num % 10) {
//         Console.WriteLine("Teklik boyukdur.");
//     }else {
//         Console.WriteLine("Beraberdirler");
//     }
// }else {
//     Console.WriteLine("Zehmet olmasa 2 reqemli eded daxil edin!");
// }

// Task 5:
// Console.WriteLine("Duzbucaqlinin enini daxil edin: ");
// int en = Convert.ToInt32(Console.ReadLine());
//  
// Console.WriteLine("Duzbucaqlinin uzununu daxil edin: ");
// int uzun = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine("Duzbucaqlinin perimetri: " + (2 * (en + uzun)));
// Console.WriteLine("Duzbucaqlinin sahesi: " + (en * uzun));

// Task 6:
// Console.WriteLine("a: ");
// int a = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine("b: ");
// int b = Convert.ToInt32(Console.ReadLine());
//
// a = a + b;
// b = a - b;
// a = a - b;
//
// Console.WriteLine("a = " + a);
// Console.WriteLine("b = " + b);
