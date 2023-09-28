// task 1.  1 ilə 25 arasında kök altısı olan ədədləri tapın.


/*Console.WriteLine("1 ile 25 arasında kok altisi olan ededler:");

for (int i = 1; i <= 5; i++)
{
    int square = i * i;
    if (square <= 25)
    {
        Console.WriteLine(square);
    }
    else
    {
        break; // 25-boyuk kok altisi olan ededleri axtarmaga ehtiyac yoxdur.
    }
}*/


//task 2. Arraydaki yalnız tək ədədlərin cəmini çap edən alqoritm qurun.


/*Console.WriteLine("nece eded daxil edeceksiz= ");
int n=Convert.ToInt32(Console.ReadLine());
int[] numbers= new int[n];
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("numbers["+i+"]=" );
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
int sum = 0;
for (int i = 0;i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 1)
    {
        sum += numbers[i];

    }
}
Console.WriteLine(sum);*/



//task 3. Verilmiş massivin tək indeksində duran elementlərin cəmini tapan alqoritm yazın. Nəticəni konsola çıxarın. Məs. {1, 2, 1, 4, 3} => 6

/*Console.WriteLine("nece eded daxil edeceksiz= ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("numbers[" + i + "]=");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 == 1)
    {
        sum += numbers[i];

    }
}
Console.WriteLine("tek indeksde duran elementlerin cemi=>"+sum);*/


//task 4.Verilmiş sozun polindrom olub olmadigini göstərən alqoritm yazın (məs: "ata" sondan və baslanğıcdan eyni oxunur cavab true cixacaq)

/*string word = Console.ReadLine();

int left = 0;
int right = word.Length-1;
int count = 0;
while (left < right)
{
    if (word[left] == word[right])
    {
        count++;
    }
    else
    {
        break;
    }
    left++;
    right--;



}
if (count == word.Length/2){
    Console.WriteLine("polindromdur");

}
else
{
    Console.WriteLine("pol deyil");
}*/