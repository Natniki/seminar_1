Console.WriteLine("Vvedite chislo : ");
int n = Convert.ToInt32(Console.ReadLine());
Dictionary<int, string> map = new Dictionary<int, string>()
{
        { 1, "Ponedelnik"},
        { 2, "Vtornik"},
        { 3, "Sreda"},
        { 4, "Chetverg"},
        { 5, "Peatnica"},
        { 6, "Subbota"},
        { 7, "Voskresenie"}
};
if (n>0 && n<8)
{
    Console.WriteLine (map[n]);
}
else
{
    Console.WriteLine ($"Oshibka!!!");
}