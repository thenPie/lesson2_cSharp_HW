int RandNum() {
    return new Random().Next(100, 1000);
}

int Input3D() {
    Console.Write("Input three-digit number: ");
    int threeD = int.Parse(Console.ReadLine());
    int count = threeD.ToString().Length;
    if (3 < count||3 > count) {
        return 1;
    } else {
        return threeD;
    }
}

int ShowNum(int number) {
    Console.WriteLine("Three-digit number is: {0}", number);
    return number;
}

void Show2ndD(int number) {
    String str = number.ToString();
    Console.WriteLine("2nd number is: {0}", str[1]);
}

Show2ndD(ShowNum(RandNum()));
Console.WriteLine();
Show2ndD(ShowNum(Input3D()));