string fileName = "file.bin";

int n = 154678;
double x = 654564.098987;
bool f = true;

//using(BinaryWriter writer = new BinaryWriter(File.OpenWrite(fileName)))
//{
//    writer.Write(n);
//    writer.Write(x);
//    writer.Write(f);
//}

using(BinaryReader reader = new BinaryReader(File.OpenRead(fileName)))
{
    Console.WriteLine(reader.ReadInt32());
    Console.WriteLine(reader.ReadDouble());
    Console.WriteLine(reader.ReadBoolean());
}