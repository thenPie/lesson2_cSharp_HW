int Input3D() {
    Console.Write("Input three-digit number: ");
    int threeD = int.Parse(Console.ReadLine());
    int count = threeD.ToString().Length;
    if (3 < count||3 > count) {
        Console.WriteLine("STOP RIGHT THERE");
        return 1;
    } else {
        return threeD;
    }
}

void Show2ndD(int number) {
    String str = number.ToString();
    Console.WriteLine("2nd number is: {0}", str[1]);
}

Show2ndD(Input3D());