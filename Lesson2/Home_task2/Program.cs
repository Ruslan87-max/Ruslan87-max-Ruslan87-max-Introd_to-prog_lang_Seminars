Console.Write("Введите координату Х: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int numY = Convert.ToInt32(Console.ReadLine());

if ((numX == 0 && numY == 0) || numX == 0 || numY == 0) {
    Console.Write($"Координата точки не находится ни в одной из четвертей");
}
else if (numX > 0 && numY > 0) {
    Console.Write($"Координата точки находится в 1 четверти");
}

else if (numX < 0 && numY > 0) {
    Console.Write($"Координата точки находится во 2 четверти");
}

else if (numX < 0 && numY < 0) {
    Console.Write($"Координата точки находится в 3 четверти");
}

else {//if (numX > 0 && numY < 0) {
    Console.Write($"Координата точки находится в 4 четверти");
}

