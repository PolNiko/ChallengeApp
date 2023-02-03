var name = "Ewa ";
bool female = true;
var age = 33;

if (female && name != "Ewa " && age > 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa " && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (female == false && age >= 18)
{
    Console.WriteLine("niepelnoletni mezczyzna");
}