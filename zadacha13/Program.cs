int InputNum() {
    Console.Write("Input a number: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

void Show3rdD(int number) {
    String str = number.ToString();
    if (str.Length < 3) {
        Console.WriteLine("The 3rd digit doesn't exist.");
    } else {
        Console.WriteLine("The 3rd digit is {0}.", str[2]);
    }
}

Show3rdD(InputNum());