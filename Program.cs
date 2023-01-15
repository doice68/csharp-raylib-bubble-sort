using Raylib_cs;
using static Raylib_cs.Raylib;

InitWindow(500, 500, "hiii");
var values = new float[GetScreenWidth()];

for (int i = 0; i < values.Length; i++)
{
    values[i] = Random.Shared.Next(0, GetScreenHeight());
}

var k = 0;
//idk what comes after k
var l = 0;

// for (int i = 0; i < values.Length; i++)
// {
//     for (int j = 0; j < values.Length - i - 1; j++)
//     {

//     }
// }
while (WindowShouldClose() == false)
{
    var a = values[k];
    var b = values[k + 1];
    if (a > b)
    {
        var temp = a;
        values[k] = values[k + 1];
        values[k + 1] = a;
    }

    if (l < values.Length)
    {
        k++;
        if (k >= values.Length - l - 1)
        {
            k = 0;
            l++;
        }
    }


    BeginDrawing();
    ClearBackground(Color.BLACK);
    for (int i = 0; i < values.Length; i++)
    {
        DrawLine(i, 0, i, (int)values[i], Color.WHITE);
    }
    EndDrawing();
}
CloseWindow();